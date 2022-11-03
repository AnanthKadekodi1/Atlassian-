using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    public interface IRouter
    {
        public void withRoute(string path, string result);
  
        public string route(string path) ; 
    }

}
