using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class KhoaBUS
    {
        public static void InsertKhoa(Khoa khoa)
        {
            Khoa k = new Khoa() { };
            using (var db =new QLDKHPEntities())
            {
                db.Khoas.Add(k);
                db.SaveChanges();
            }
        }
        public static void UpdateKhoa(string maKhoa,Khoa khoaMoi)
        {
            using( var db = new QLDKHPEntities())
            {
                Khoa k = db.Khoas.Find(maKhoa);
                if (k == null)
                {
                    return;
                }
                k.Ten = khoaMoi.Ten;
                k.Sdt = khoaMoi.Sdt;
                k.DiadiemVp = khoaMoi.DiadiemVp;
                db.SaveChanges();
            }
        }
        public static void DeleteKhoa( string maKhoa)
        {
           using( var db = new QLDKHPEntities())
            {
                Khoa k = db.Khoas.Find(maKhoa);
                if(k == null)
                { return; }
                db.Khoas.Remove(k);
                db.SaveChanges();
            }
        }
    }
}
