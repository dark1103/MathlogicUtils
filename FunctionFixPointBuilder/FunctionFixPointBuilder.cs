using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FunctionFixPointBuilder
{
    public class FunctionFixPointBuilder
    {
        public delegate object InvokeDelegate(ITuple data, int level, string funNumber);
        public delegate object FixPointDelegate(ITuple data, int level, InvokeDelegate invoker);

        private FixPointDelegate emptyFunction = (data, level, funcSupplier) => null;

        private Dictionary<string, FixPointDelegate> defaultFunctions = new Dictionary<string, FixPointDelegate>();


        public void SetFunction(FixPointDelegate func)
        {
            defaultFunctions = new Dictionary<string, FixPointDelegate>(){{"F", func}};
        }

        public void SetFunctions(Dictionary<string, FixPointDelegate> func)
        {
            defaultFunctions = func;
        }

        public object Invoke(ITuple data, int level, string funcNumber = "F")
        {
            if (level == 0)
            {
                return null;
            }
            else
            {
                return defaultFunctions[funcNumber](data, level - 1, Invoke);
            }
        }


        public void Test(List<ITuple> dataSet, int level, string funcNumber = "F")
        {
            Console.WriteLine($"---------------------Test of {funcNumber}, level {level}---------------------");
            for (int i = 0; i < dataSet.Count; i++)
            {
                object res = Invoke(dataSet[i], level, funcNumber);
                if (res != null)
                {
                    string inp;

                    if (dataSet[i].Length > 1)
                    {
                        inp = dataSet[i].ToString();
                    }
                    else
                    {
                        inp = dataSet[i][0].ToString();
                    }
                    Console.WriteLine($"({inp}, {res})");
                }
            }
            Console.WriteLine($"----------------------Test end-------------------------");

        }

    }
}
