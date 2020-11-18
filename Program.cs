using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace sortingByInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPv4:
            //UInt32 ip = 2149583361;
            //string BinaryCode = Convert.ToString(ip, 2);

            //string oc1 = BinaryCode.Substring(0, 8);
            //string oc2 = BinaryCode.Substring(8, 8);
            //string oc3 = BinaryCode.Substring(16, 8);
            //string oc4 = BinaryCode.Substring(24, 8);
            //Console.WriteLine(oc1);
            //Console.WriteLine(oc2);
            //Console.WriteLine(oc3);
            //Console.WriteLine(oc4);
            //Console.WriteLine("~~~~~~~~~~~~~~~");
            //Console.WriteLine(Solution(6.6));

            //Console.WriteLine(Add("123", "12314"));

            //long k = 2017;
            //string s = k.ToString();
            //string[] v = new string[s.Length];
            //for (int i = 0; i <= v.Length - 1; i++)
            //    v[i] = s[i].ToString();
            //Console.WriteLine(v[0]);


            Console.WriteLine(NextSmaller(154));
        }


        public static int find_it(int[] seq)
        {
            int sum = 0;
            for (int i = 0; i <= seq.Length - 1;)
            {
                int k = i + 1;
                while (k < seq.Length - 1)
                {
                    k++;
                    if (seq[i] == seq[k])
                        sum++;
                }
                if (sum % 2 == 0)
                    return i++;
                else return seq[k];
            }
            return -1;
        }
        public static int[] UpArray(int[] num)
        {
            string str = "";
            for (int i = 0; i <= num.Length - 1; i++)
                str += num[i];
            int n = int.Parse(str);
            n++;
            List<int> result = new List<int>();
            string[] s = n.ToString().Split();
            for (int k = 0; k <= s.Length - 1; k++)
                result.Add(int.Parse(s[k]));
            int[] arr = result.ToArray();
            return arr;
            
        }
        //The shortest
        public static double Solution(double n) => Math.Round(n * 2, MidpointRounding.AwayFromZero) / 2;
        public static string Add(string a, string b) => (long.Parse(a) + long.Parse(b)).ToString();




        public static long NextSmaller(long n)
        {
           int[] array1 = new int[n.ToString().Length];
            for (int i = 0; i <= n.ToString().Length - 1; i++)
                array1[i] = int.Parse(n.ToString()[i].ToString());
            Array.Sort(array1);
            string firstString = string.Empty;
            for (int k = 0; k <= array1.Length - 1; k++)
                firstString += array1[k];

            for (long n2 = n - 9; n2 != n - 5000; n2--)
            {
                string secondString = string.Empty;
                int[] array2 = new int[n2.ToString().Length];
                for (int l = 0; l <= n2.ToString().Length - 1; l++)
                    array2[l] = int.Parse(n2.ToString()[l].ToString());
                Array.Sort(array2);
                for (int j = 0; j <= array2.Length - 1; j++)
                    secondString += array2[j];
                if (firstString.Equals(secondString))
                    return n2;
                else if (n2 == 0 && !firstString.Equals(secondString))
                    return n;
            }
            return -1;
        }
            
    }
}
