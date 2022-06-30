using Labb1_Implementera.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Strategy
{
    public interface ISearch
    {
        //Strategy
        void Search(string searchword, string[,] employeeArray);
    }
}
