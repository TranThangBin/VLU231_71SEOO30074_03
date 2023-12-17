using System;
using System.Linq;

namespace VLU231_71SEOO30074_03.src.BUS
{
    internal class MonHocBUS
    {
        public static void UseMonHocs(Action<IQueryable<MonHoc>> callback)
        {
            using (var db = new QLDKHPEntities())
            {
                callback(db.MonHocs);
            }
        }

        public static void InsertMonHoc(MonHoc monHoc)
        {
            using (var db = new QLDKHPEntities())
            {
                db.MonHocs.Add(
                    new MonHoc()
                    {
                        Ma = monHoc.Ma,
                        Ten = monHoc.Ten,
                        MaKhoa = monHoc.MaKhoa,
                        MaTienQuyet = monHoc.MaTienQuyet,
                        SoTc = monHoc.SoTc,
                    }
                );
                db.SaveChanges();
            }
        }

        public static void UpdateMonHoc(string maMonHoc, MonHoc mhMoi)
        {
            using (var db = new QLDKHPEntities())
            {
                MonHoc mh = db.MonHocs.Find(maMonHoc);
                if (mh?.Ma != mhMoi.Ma)
                {
                    return;
                }
                mh.Ten = mhMoi.Ten;
                mh.SoTc = mhMoi.SoTc;
                if (mh.MaTienQuyet != mhMoi.MaTienQuyet)
                {
                    mh.MaTienQuyet = mhMoi.MaTienQuyet;
                }
                db.SaveChanges();
            }
        }

        public static void DeleteMonHoc(string maMonHoc)
        {
            using (var db = new QLDKHPEntities())
            {
                MonHoc mh = db.MonHocs.Find(maMonHoc);
                if (mh == null)
                {
                    return;
                }
                db.MonHocs.Remove(mh);
                db.SaveChanges();
            }
        }
    }
}
