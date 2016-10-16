using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Style_Transfer.LogClasses
{
    class LogColorTransferData
    {
        public string Time { get; set; }
        public string ContentFilePath { get; set; }
        public string GeneratedFilePath { get; set; }
        public string ParameterList { get; set; }
    }
}
