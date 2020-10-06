namespace MTIJ.Models
{
    using MTIJ.Filters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data.Entity.Validation;
    using System.Linq;

    [Table("LWEB")]
    public partial class LWEB
    {
        public short? RECID { get; set; }

        [Key]
        public int UNO { get; set; }

        [StringLength(2)]
        public string UKUBUN { get; set; }

        [StringLength(4)]
        public string UBAITAI { get; set; }

        [StringLength(8)]
        public string UDATE { get; set; }

        [StringLength(6)]
        public string UTIME { get; set; }

        [StringLength(2)]
        public string ATTR { get; set; }

        public short? WSTATUS { get; set; }

        [StringLength(10)]
        public string CUSTNO { get; set; }

        [StringLength(80)]
        public string CREDITNO { get; set; }

        [StringLength(80)]
        public string PASS { get; set; }

        [StringLength(20)]
        public string NAME { get; set; }

        [StringLength(20)]
        public string NAMEX { get; set; }

        [StringLength(8)]
        public string BIRTHDAY { get; set; }

        public short? SEX { get; set; }

        [StringLength(18)]
        public string RENTEL { get; set; }

        public int? MKIN { get; set; }

        public int? NENSYUU { get; set; }

        public short? HOKEN { get; set; }

        [StringLength(8)]
        public string NYUSHA { get; set; }

        public short? KOYOU { get; set; }

        public short? GYOSHU { get; set; }

        public short? SYOKUSYU { get; set; }

        public short? KKIBO { get; set; }

        public short? DOKI { get; set; }

        [StringLength(40)]
        public string EMAIL { get; set; }

        public short? JTELKBN { get; set; }

        [StringLength(8)]
        public string JZIP { get; set; }

        [StringLength(80)]
        public string JADDR1 { get; set; }

        [StringLength(80)]
        public string JADDR2 { get; set; }

        [StringLength(80)]
        public string JADDRX1 { get; set; }

        [StringLength(80)]
        public string JADDRX2 { get; set; }

        [StringLength(18)]
        public string JTEL { get; set; }

        public short? JYUKYO { get; set; }

        public short? JMEIGI { get; set; }

        [StringLength(8)]
        public string NYUKYO { get; set; }

        public short? DOUKYO { get; set; }

        public short? NINPI { get; set; }

        [StringLength(80)]
        public string KINNAME { get; set; }

        [StringLength(8)]
        public string KZIP { get; set; }

        [StringLength(80)]
        public string KADDR1 { get; set; }

        [StringLength(80)]
        public string KADDR2 { get; set; }

        [StringLength(80)]
        public string KADDRX1 { get; set; }

        [StringLength(80)]
        public string KADDRX2 { get; set; }

        [StringLength(18)]
        public string KTELD { get; set; }

        [StringLength(18)]
        public string KTELC { get; set; }

        public short? YAKUSYOKU { get; set; }

        public short? KYURYO { get; set; }

        public short? RKEN { get; set; }

        public int? RKIN { get; set; }

        public short? KEIYAKU { get; set; }

        public short? YUUSO { get; set; }

        [StringLength(20)]
        public string OLDNAMEX { get; set; }

        [StringLength(160)]
        public string HONSEKI { get; set; }

        [StringLength(20)]
        public string OLDNAME { get; set; }

        [StringLength(40)]
        public string HMEIGI { get; set; }

        public double? YOBI1 { get; set; }

        public double? YOBI2 { get; set; }

        public double? YOBI3 { get; set; }

        public double? YOBI4 { get; set; }

        public double? YOBI5 { get; set; }

        public double? YOBI6 { get; set; }

        public double? YOBI7 { get; set; }

        public double? YOBI8 { get; set; }

        public double? YOBI9 { get; set; }

        public double? YOBI10 { get; set; }

        [StringLength(80)]
        public string YOBI11 { get; set; }

        [StringLength(80)]
        public string YOBI12 { get; set; }

        [StringLength(80)]
        public string YOBI13 { get; set; }

        [StringLength(80)]
        public string YOBI14 { get; set; }

        [StringLength(80)]
        public string YOBI15 { get; set; }

        [StringLength(1024)]
        public string YOBI16 { get; set; }

        [StringLength(1024)]
        public string YOBI17 { get; set; }

        [StringLength(1024)]
        public string YOBI18 { get; set; }

        [StringLength(1024)]
        public string YOBI19 { get; set; }

        [StringLength(1024)]
        public string YOBI20 { get; set; }
    }
    public static class LWEBModel
    {
        private static FKDBContext db = new FKDBContext();

        public static bool SaveErrorLog(int idInsertLWeb, Error error, int statusCode)
        {
            try
            {
                var lWeb = db.LWEBs.Where(l => l.UNO == idInsertLWeb).FirstOrDefault();
                if (lWeb != null)
                {
                    lWeb.WSTATUS = 2;
                    lWeb.YOBI20 = statusCode.ToString() + ":" + error.type + ":" + error.message;
                    db.SaveChanges();

                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
