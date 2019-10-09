using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Print_a_z();
            Console.WriteLine();
            Print_z_a();
            Console.WriteLine();
            Print_A_Z();
            Console.WriteLine();
            Output_ASCII('L');
            Console.ReadLine();
            
        }
        #region Print a-z
        public static void Print_a_z()
        {
            for(int i = 97; i <= 122; i++)
            {
                Console.Write((char)i+"  ");
            }
        }

        public static void Print_a_z_2()
        {
            for(char i = 'a'; i <= 'z'; i++)
            {
                Console.Write(i + "  ");
            }
        }

        public static void Print_a_z_3()
        {
            "abcdfghjklmno".ToCharArray().ToList().ForEach(i => Console.WriteLine(i));
        }
        #endregion 
        public static void Print_z_a()
        {
            for(int i=122; i >= 97; i--)
            {
                Console.Write((char)i +"  ");
            }
        }

        public static void Print_A_Z()
        {
            for(int i = 65; i <= 90; i++)
            {
                Console.Write((char)i + "  ");
            }
        }

        public static void Output_ASCII(char n)
        {
            Console.WriteLine("hệ cơ số 10: ");
            int m = (int)n;
            Console.WriteLine(m);

            Console.WriteLine("hệ cơ số 16: "); 
            string[] array = new string[100];
            int a = 0;
            while (m != 0)
            {
                int chuso = m % 16;
                if (chuso <= 9) array[a] = chuso.ToString();  // "{0}",chuso ??
                else if (chuso == 10) array[a] = "A";
                else if (chuso == 11) array[a] = "B";
                else if (chuso == 12) array[a] = "C";
                else if (chuso == 13) array[a] = "D";
                else if (chuso == 14) array[a] = "E";
                else if (chuso == 15) array[a] = "F";
                a++;
                m = m / 16;
            }
            for(int i=a; i >= 0; i--)
            {
                Console.Write(array[i]);
            }
           


        }


    }
}
