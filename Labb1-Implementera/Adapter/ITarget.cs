using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Adapter
{
    public interface ITarget
    {
        //Adapter
        void ProcessPayCheck(string[,] employeeArray, string employeeName);
    }
}
