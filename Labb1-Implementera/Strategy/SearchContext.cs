using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Strategy
{
    public class SearchContext
    {
        //Strategy
        private ISearch _searchStrategy;

        public void SetSearchStrategy(ISearch search)
        {
            this._searchStrategy = search;   
        }

        public void Search(string searchword, string[,] employeeArray)
        {
            _searchStrategy.Search(searchword, employeeArray);
        }
    }
}
