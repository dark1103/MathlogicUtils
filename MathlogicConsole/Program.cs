using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrimitiveRecursive.PR;
using static PrimitiveRecursive.BasicPR;

namespace MathlogicConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            // var g = new Func<int, int>((int x) => x);
            // var h = new Func<int, int, int, int>((int x, int y, int z) => z - 1);
            // var f = R(g, h);
            // Console.WriteLine(f(10,3));


            // Console.WriteLine(R(x=>x, 
            //     (x, y, z) =>
            //         {
            //             return z - 1;
            //         }
            //     )(10,5));

            var _sum = R(
                (x) => x,
                (x, y, prev) =>
                {
                    return prev + 1;
                }
            );

            var _mul = R(
                (x) => 0,
                (x, y, prev) => prev + x
            );

            var _q = F((x1, y1) => 
                R(
                    (x, y) => 0,
                    (x, y, n, prev) => prev + asg(s(n) * y - x)
                )(x1, y1, x1)
            );

            var _r = F((x,y) => x - y * _q(x,y));

            var _n = F(x1=> 
                R(
                    x => 0,
                    (x, m, prev) => prev + asg(_r(x, m))
                )(x1, s(x1))
            );

            var _a = F(x1 =>
                R(
                    x => 0,
                    (x, m, prev) => prev + m * asg(_r(x, m))
                )(x1, s(x1))
            );

            var _eq = F((x, y) => asg(x-y) * asg(y-x));

            var _b = F(x1 =>
                R(
                    x => 0,
                    (x, m, prev) => prev + asg(_r(x, m)) * asg(_n(m) - 2) * sg(m - 1)
                )(x1, s(x1))
            );

            var _pi = F(x1=> 
                R(
                    () => 0,
                    (m, prev) => prev + asg(_n(m) - 2) * sg(m - 1)
                )(s(x1))
            );
            

            // Console.WriteLine(_r(14,3));
            // Console.WriteLine(_b(14));
            Console.WriteLine(_sum(5, 1));
            // Console.WriteLine(_sum(3, 7));

            Console.ReadKey();
        }
    }
}
