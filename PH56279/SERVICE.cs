using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH56279
{
    internal class SERVICE
    {
        List<LapTop> lapTop {  get; set; }

        public SERVICE()
        {
            lapTop = new List<LapTop>();
        }

        public void NhapDoiTuong()
        {
            int tieptuc = -1;
            do
            {
                Console.WriteLine("Nhap ID : ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ma lap top : ");
                string maLapTop = Console.ReadLine();
                Console.WriteLine("Nhap kich thuoc man hinh : ");
                double kichThuocManHinh = double.Parse(Console.ReadLine());
                
                LapTop lapTop = new LapTop(id,maLapTop,kichThuocManHinh);
                this.lapTop.Add(lapTop);

                Console.WriteLine("Ban co muon nhap tiep khong : (1-co/2-khong)");
                tieptuc = int.Parse(Console.ReadLine());
            } while (tieptuc == 1);
        }
        
        public void XuatDoiTuong()
        {
            foreach (LapTop lt in lapTop)
            {
                lt.InThongTin();
            }
        }
    }
}
