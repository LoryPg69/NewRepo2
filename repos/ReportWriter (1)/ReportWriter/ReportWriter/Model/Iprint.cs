using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportWriter.Model
{
    internal interface Iprint
    {
        FileInfo FileInfo { get; }
        string Name { get; }        
        
    }
}
