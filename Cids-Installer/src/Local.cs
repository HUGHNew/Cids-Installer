using System;
using System.Collections.Generic;
using System.Text;

namespace Cids_Installer
{
    class Local
    {
        public const string MainEnv = "Cids";
        public const string Id = "CidsUUID";
        // ProgramFiles
        public const string PF = "ProgramFiles";
        public const EnvironmentVariableTarget Process = EnvironmentVariableTarget.Process;
        public const EnvironmentVariableTarget Machine = EnvironmentVariableTarget.Machine;
        
        //todo
        //set the json
        public String UuId { get; set; }
        static Local()
        {
            Environment.SetEnvironmentVariable(MainEnv,
                Environment.GetEnvironmentVariable(PF,Process));
        }
    }
}
