using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using static Cids_Installer.LocalTest;
using Microsoft.Win32;

namespace Cids_Installer
{
    class Local
    {
        public const string MainEnv = "Cids";
        public const string Id = "CidsUUID";
        public const string PF = "ProgramFiles"; // ProgramFiles
        private const string JsonFile = "CidsConf.json";
        public static readonly string ProgramFilesPath = Environment.GetEnvironmentVariable(PF, Process);
        public const EnvironmentVariableTarget Process = EnvironmentVariableTarget.Process;
        public const EnvironmentVariableTarget Machine = EnvironmentVariableTarget.Machine;

        public static string Cids => Environment.GetEnvironmentVariable(MainEnv, Machine);
        public static string CidsFile => Path.Combine(Cids, JsonFile);
        public static string CidsImage => Path.Combine(Cids, "image");
        public const string client = "cids-client.exe";
        public const string inst_file="cids";
        public const string uninstall = "unist.exe";
        public static string CidsClient => Path.Combine(Cids, client);
        public static string CidsUninst => Path.Combine(Cids, uninstall);


        public const string LoopBack = "127.0.0.1";
        #region Json Property Setting
        public static String UuId { get; set; }
        public static string Center {get;set;}
        public static int CenterPort { get; set; }
        public static int MirrorPort { get; set; }
        public static int UdpDelay { get; set; }
        public static int HeatBeatTime { get; set; }
        public static int HBLimit { get; set; }
        public static int SleepMax { get; set; }
        public static int SleepMin { get; set; }
        public static int ProtocolNum { get; set; }
        #endregion
        static Local()
        {
            //EnvironmentLoading();
        }
        public static void EnvironmentLoading(bool InstantSave)
        {
            #region Set Env Var
            Environment.SetEnvironmentVariable(MainEnv,
                Path.Combine(ProgramFilesPath,MainEnv),Machine); // Cids
            Environment.SetEnvironmentVariable(Id, UuId, Machine); // CidsUUID
            #endregion
            if(InstantSave)SaveDefault();
        }
        /// <summary>
        /// 将程序移动到Cids目录下
        /// </summary>
        public static void MoveExeToCids() {
            IgnoreMoveDirectory("client", Cids); // move client and dlls
            IgnoreMoveDirectory("unist",Cids); // move uninstaller and dlls ignoring the same dlls
            File.Move("favicon.ico",Path.Combine(Cids, "favicon.ico")); // move icon
        }
        /// <summary>
        /// 将目录下所有文件移动到目标文件夹 移动时忽略掉同名文件
        /// </summary>
        /// <param name="SrcDirName">源文件夹</param>
        /// <param name="DestDirName">目标文件夹</param>
        public static void IgnoreMoveDirectory(string SrcDirName,string DestDirName) {
            IEnumerable<String> files = Directory.EnumerateFiles(SrcDirName);
            static string BaseFile(string filename)
            {
                char[] sep = { '\\', '/' };
                string[] parts = filename.Split(sep);
                return parts[^1];
            }
            foreach (string file in files)
            {
                string dstfile = Path.Combine(DestDirName, BaseFile(file));
                if (! File.Exists(dstfile)) // if not exists
                {
                    File.Move(file, dstfile);
                }
            }
        }
        public static void SetAutoRun()
        {
            SetAutoRun(CidsClient,true);
        }
        /// <summary>
        /// 设置应用程序开机自动运行
        /// </summary>
        /// <param name="fileName">应用程序的文件名 程序的绝对路径</param>
        /// <param name="isAutoRun">是否自动运行，为false时，取消自动运行</param>
        /// <exception cref="System.Exception">设置不成功时抛出异常</exception>
        public static void SetAutoRun(string fileName, bool isAutoRun)
        {
            RegistryKey reg = null;
            try
            {
                if (!System.IO.File.Exists(fileName))
                    throw new Exception("该文件不存在!");
                String name = fileName[(fileName.LastIndexOf(@"\") + 1)..];
                reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (reg == null)
                    reg = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                if (isAutoRun)
                    reg.SetValue(name, fileName);
                else
                    reg.SetValue(name, false);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (reg != null)
                    reg.Close();
            }

        }
        #region Save Domain
        public static void SaveDefault()
        {
            SaveConfFile(Center, CidsFile);
        }
        public static void SaveLoopbackConf()
        {
            SaveLoopbackTest(CidsFile);
        }
        public static void SaveLoopbackTest(string savefile)
        {
            SaveConfFile(LoopBack, savefile);
        }
        #endregion
        /// <summary>
        /// Save Conf Json File
        /// </summary>
        /// <param name="center">IP of Center Server</param>
        /// <param name="savefile">File to Save</param>
        public static void SaveConfFile(string center,string savefile)
        {
            Conf configuration = new Conf
            {
                Net=new ConfComponent.NetData { 
                    Main_Ip=center,
                    Main_Port=CenterPort,
                    Mirror_Port=MirrorPort
                },
                Time=new ConfComponent.TimeData
                {
                    Delay= UdpDelay,
                    HeartBeat=HeatBeatTime,
                    Limit= HBLimit,
                    Sleep=new ConfComponent.SleepTime
                    {
                        Max=SleepMax,
                        Min=SleepMin
                    }
                },
                Protocol=ProtocolNum,
                Logo= "favicon.ico"
            };
            File.WriteAllText(savefile,JsonSerializer.Serialize(configuration));
        }
    }
}
