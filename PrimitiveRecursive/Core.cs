using System;

namespace PrimitiveRecursive
{
    public static class PR
    {
        private static int invoke(Func<int> g, Func<int, int, int> h, int n)
        {
            if (n == 0)
            {
                return g();
            }

            int h_val = invoke(g, h, n - 1);

            return h(n - 1, h_val);
        }

        public static Func<int, int> R(Func<int> g, Func<int, int, int> h)
        {
            return (n) => invoke(g, h, n);
        }

        private static int invoke(Func<int, int> g, Func<int, int, int, int> h, int x, int n)
        {
            if (n == 0)
            {
                return g(x);
            }

            int h_val = invoke(g, h, x, n - 1);

            return h(x, n - 1, h_val);
        }

        public static Func<int, int, int> R(Func<int, int> g, Func<int, int, int, int> h)
        {
            return (x, n) => invoke(g, h, x, n);
        }

        private static int invoke(Func<int, int, int> g, Func<int, int, int, int, int> h, int x, int y, int n)
        {
            if (n == 0)
            {
                return g(x, y);
            }

            int h_val = invoke(g, h, x, y, n - 1);

            return h(x, y, n - 1, h_val);
        }

        public static Func<int, int, int, int> R(Func<int, int, int> g, Func<int, int, int, int, int> h)
        {
            return (x, y, n) => invoke(g, h, x, y, n);
        }

        public static Func<int> F(Func<int> f)
        {
            return f;
        }
        public static Func<int, int> F(Func<int, int> f)
        {
            return f;
        }
        public static Func<int, int, int> F(Func<int, int, int> f)
        {
            return f;
        }
        public static Func<int, int, int, int> F(Func<int, int, int, int> f)
        {
            return f;
        }

        public static Func<int> Minimize(Func<int, int> f, int r)
        {
            return () =>
            {
                int k = 0;
                while (f(k) != r)
                {
                    k++;
                }

                return k;
            };
        }

        public static Func<int, int> Minimize(Func<int, int, int> f, int r = 0)
        {
            return x =>
            {
                int k = 0;
                while (f(x, k) != r)
                {
                    k++;
                }

                return k;
            };
        }

        public static Func<int, int, int> Minimize(Func<int, int, int, int> f, int r = 0)
        {
            return (x,y) =>
            {
                int k = 0;
                while (f(x, y, k) != r)
                {
                    k++;
                }

                return k;
            };
        }
    }

    public class BasicPR
    {
        public static int asg(int x) => x > 0 ? 0 : 1;
        public static int sg(int x) => x > 0 ? 1 : 0;
        public static int s(int x) => ++x;
        public static int o(params int[] x) => 0;
        public static int i(int n, params int[] x) => x[n-1];
    }
}
