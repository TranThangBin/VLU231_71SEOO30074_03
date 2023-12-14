using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class MonHocBUS
    {
        public static void InsertMonHoc(MonHoc monHoc,string maKhoa)
        {
            MonHoc mh = new MonHoc() { MaKhoa = maKhoa };
            using ( var db = new QLDKHPEntities())
            {
                db.MonHocs.Add(mh);
                db.SaveChanges();
            }
          
        }
        public static void UpdateMonHoc(string maMonHoc, MonHoc mhMoi)
        {
            using ( var db = new QLDKHPEntities() { })
            {
                MonHoc mh = db.MonHocs.Find(maMonHoc);
                if(mh== null)
                {
                    return;
                }
                mh.Ten = mhMoi.Ten;
                mh.SoTc = mhMoi.SoTc;
                mh.MaTienQuyet= mhMoi.MaTienQuyet;
                db.SaveChanges() ;


            }
        }
        public static void DeleteMonHoc( string maMonHoc )
        {
            using ( var db = new QLDKHPEntities() { })
            {
                MonHoc mh = db.MonHocs.Find(maMonHoc) ;
                if(mh== null)
                { return; }
                db.MonHocs.Remove(mh);
                db.SaveChanges() ;
            }
        }
    }
}
