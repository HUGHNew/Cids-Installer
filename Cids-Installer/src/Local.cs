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
        public const string Center = "";
        //todo
        //set the json
        public static String UuId { get; set; }
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
        /**
         * @brief Save Conf Json File
         */
        public static void SaveConfFile(string center,string savefile)
        {
            Conf configuration = new Conf
            {
                Net=new ConfComponent.NetData { 
                    Main_Ip=center,
                    Main_Port=20800,
                    Mirror_Port=20801
                },
                Time=new ConfComponent.TimeData
                {
                    Delay=100,
                    HeartBeat=1000,
                    Limit=10,
                    Sleep=new ConfComponent.SleepTime
                    {
                        Max=5000,
                        Min=2000
                    }
                },
                Protocol=2,
                Logo= "favicon.ico"
            };
            File.WriteAllText(savefile,JsonSerializer.Serialize(configuration));
        }
    }
}
