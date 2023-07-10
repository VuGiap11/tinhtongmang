using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinhtong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.Write("moi nhap vao slpt: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("nhap vao gia tri cua phan tu {0}", +i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int tong = 0;
            foreach (int item in a)
            {
                tong += item;
                Console.Write(item + " ");
            }
            Console.WriteLine("\n tong cua cac so la ", +tong);
        }
    }
}
