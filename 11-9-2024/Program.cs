using System;
namespace vonglap
{
    class tonghop
    {
        public static void bai1()
        {
            Console.WriteLine("moi nhap n");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("moi nhap phan tu: {0}", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("cac phan tu: {0}:", i + 1);
                Console.WriteLine(a[i]);
            }
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong = tong + a[i];
            }
            Console.WriteLine("tong cua mang tren: {0}", tong);
            Console.ReadKey();
        }
        public static void bai2()
        {
            string m = Console.ReadLine();
            int dem = 0;
            for (int i = 0; i < m.Length; i++)
            {
                dem++;
            }
            Console.WriteLine(dem);
        }
        public static void bai3()
        {
            Console.WriteLine("moi nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("moi nhap phan tu: {0}", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("phan tu {0} : ", i + 1);
                Console.WriteLine(a[i]);
            }
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("max: {0}", max);
        }
        public static void bai4()
        {
            Console.WriteLine("moi nhap chuoi: ");
            string m = Console.ReadLine();
            char[] marray = m.ToCharArray();
            Array.Reverse(marray);
            string reverse = new string(marray);
            Console.WriteLine("chuoi sao nguoc: {0}", reverse);
        }
        public static void bai5()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[m];
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("moi nhap phan tu: {0}", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            bool fount = false;
            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] == a[a.Length - 1 - i])
                {
                    fount = true; break;
                }
            }
            if (fount)
            {
                Console.WriteLine("doi xung");
            }
            else
            {
                Console.WriteLine("ko doi xung");
            }
        }
        public static void bai6()
        {
            string m = Console.ReadLine();
            char n = char.Parse(Console.ReadLine());
            int dem = 0;
            bool found = false;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == n) { dem++; found = true; }

            }
            if (found)
            {
                Console.WriteLine($"{n} xuat hien: {dem}");
            }
            else
            { Console.WriteLine("ko co trong chuoi"); }
        }

    }

    class program
    {
          static void Main(string[] args)
        {
            tonghop.bai1();
        }
        
    }
}