using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FunctionFixPointBuilder
{
    class Program
    {

        // static List<object[]> GenerateRange(int from, int to)
        // {
        //     List<object[]> res = new List<object[]>();
        //     for (int i = from; i < to; i++)
        //     {
        //         for (int j = from; j < to; j++)
        //         {
        //             res.Add(new object[] {i,j});
        //         }
        //     }
        //
        //     return res;
        // }

        static List<ITuple> GenerateCombinations(IEnumerable a1, IEnumerable a2)
        {
            List<ITuple> res = new List<ITuple>();

            foreach (object o1 in a1)
            {
                foreach (object o2 in a2)
                {
                    res.Add((o1, o2));
                }
            }

            return res;
        }

        static object[] arr(ITuple tuple)
        {
            object[] res = new object[tuple.Length];
            for (int i = 0; i < tuple.Length; i++)
            {
                res[i] = tuple[i];
            }

            return res;
        }

        static ITuple tup(object obj)
        {
            return new Tuple<object>(obj);
        }

        static void Main(string[] args)
        {
            FunctionFixPointBuilder builder = new FunctionFixPointBuilder();
            // builder.SetFunction(
            //     (data, level, F) =>
            //     {
            //         if ((int)data[0] == 0)
            //         {
            //             return data[1];
            //         }
            //         else
            //         {
            //             return F(((int)data[0]-1, data[1]), level);
            //         }
            //     }
            // );

            builder.SetFunctions(new Dictionary<string, FunctionFixPointBuilder.FixPointDelegate>{
                {"F", 
                    (data, level, F) =>
                    {
                        if ((bool?)F(tup(data[1]), level, "G") == true)
                        {
                            return data[0];
                        }
                        else
                        {
                            return F(((int) data[0] - 2, (int) data[1] - 2), level, "F");
                        }
                    }

                },
                {"G", 
                    (data, level, F) =>
                    {
                        if ((int)data[0] == 0)
                        {
                            return true;
                        }
                        else if((int)data[0] == 1)
                        {
                            return false;
                        }
                        else
                        {
                            return F(tup((int)data[0] - 2), level, "G");
                        }
                    }
                }
            });

            builder.Test(GenerateCombinations(Enumerable.Range(0,10), Enumerable.Range(0,10)), 2, "F");

            Console.ReadKey();
        }

    }
}
