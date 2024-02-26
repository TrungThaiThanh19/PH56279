using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH56279
{
    internal class LapTop
    {
        private int ID {  get; set; }
        private string MaLapTop { get; set; }
        private double KichThuocManHinh { get; set;}

        public LapTop()
        {
            
        }

        public LapTop(int iD, string maLapTop, double kichThuocManHinh)
        {
            ID = iD;
            MaLapTop = maLapTop;
            KichThuocManHinh = kichThuocManHinh;
        }

        public void InThongTin()
        {
            Console.WriteLine($"ID : {this.ID} | Ma lap top : {this.MaLapTop} | Kich thuoc man hinh : {this.KichThuocManHinh}");
        }
    }
}
