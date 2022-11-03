using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    public class Router : IRouter
    {
        private Dictionary<string, string> functionMap = new Dictionary<string, string>();

        public Router()
        {


        }
        public string route(string path)
        {
            try
            {
                return functionMap[path];
            }
            catch (KeyNotFoundException ex)
            {
                throw new KeyNotFoundException("Invalid path present inputted");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void withRoute(string path, string result)
        {
            functionMap.Add(path, result);
        }
    }
}
