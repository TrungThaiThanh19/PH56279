using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH56279
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            int chon = -1;
            SERVICE sERVICE = new SERVICE();
            do
            {
                Console.WriteLine("-----MENU-----");
                Console.WriteLine("1.Nhap danh sach doi tuong");
                Console.WriteLine("2.Xuat danh sach doi tuong");
                Console.WriteLine("3.Xoa doi tuong theo ma lap top");
                Console.WriteLine("4.Xuat kich thuoc man hinh theo khoang nguoi dung nhap");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("Moi ban chon chuong trinh : ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        sERVICE.NhapDoiTuong();
                        break;
                    case 2:
                        sERVICE.XuatDoiTuong();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Chi duoc nhap tu 0 den 4. Xin moi ban nhap lai : ");
                        break;
                }
            } while (chon != 0);
        }
    }
}
