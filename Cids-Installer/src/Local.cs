using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using static Cids_Installer.LocalTest;
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
        public static void EnvironmentLoading()
        {
            #region Set Env Var
            Environment.SetEnvironmentVariable(MainEnv,
                Path.Combine(ProgramFilesPath,MainEnv),Machine); // Cids
            Environment.SetEnvironmentVariable(Id, UuId, Machine); // CidsUUID
            #endregion
            SaveDefault();
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
        /**
         * @brief Save Conf Json File
         */
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
