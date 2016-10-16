using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Style_Transfer
{
    class LogDoodleData
    {
        public string Time { get; set; }
        public string ScriptType { get; set; }
        public string ContentFilePath { get; set; }
        public string StyleFilePath { get; set; }
        public string StyleMaskPath { get; set; }
        public string TargetMaskPath { get; set; }
        public string OutputFilePrefix { get; set; }
        public string ParameterList { get; set; }
    }
}
