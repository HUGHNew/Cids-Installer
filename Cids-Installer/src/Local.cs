using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace Cids_Installer
{
    class Local
    {
        public const string MainEnv = "Cids";
        public const string Id = "CidsUUID";
        public const string PF = "ProgramFiles"; // ProgramFiles
        public static readonly string ProgramFilesPath = Environment.GetEnvironmentVariable(PF, Process);
        public const EnvironmentVariableTarget Process = EnvironmentVariableTarget.Process;
        public const EnvironmentVariableTarget Machine = EnvironmentVariableTarget.Machine;

        //todo
        //set the json
        public static String UuId = Database.GetId;
        static Local()
        {
            #region Set Env Var
            Environment.SetEnvironmentVariable(MainEnv,
                Path.Combine(ProgramFilesPath,MainEnv),Machine); // Cids
            Environment.SetEnvironmentVariable(Id, UuId, Machine); // CidsUUID
            #endregion
        }
        public static void SaveConfFile()
        {

        }
    }
}
