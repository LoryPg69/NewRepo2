using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportWriter.Model
{
    internal class OperationBad : Iprint
    {
        public FileInfo FileInfo => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public Exception Error => throw new NotImplementedException();
    }
}
