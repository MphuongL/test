using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class NhanVien
    {
        public string ten;
        public string diachi;
        public double luong;
        public DateTime ngsinh;
        public void sxuat()
        { }
    }
    public class DSNV
    {
        List<NhanVien> a = new List<NhanVien>();
        public void them()
        {
            for(int i=0;i<1;i++)
            {
                NhanVien nv = new NhanVien();
                Console.WriteLine("nhap ten");
                nv.ten = Console.ReadLine();
                Console.WriteLine("nhap ngsinh");
                string ns = Console.ReadLine();
                nv.ngsinh = DateTime.ParseExact(ns,"dd/MM/yyyy",null);
                a.Add(nv);
            }
        }
        public void xuat()
        {
            foreach(NhanVien nv in a)
            {
                Console.WriteLine(nv.ten);
                Console.WriteLine(nv.ngsinh.Day);
            }
                
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DSNV dsnv = new DSNV();
            dsnv.them();
            dsnv.xuat();
            Console.ReadKey();
        }
    }
}
