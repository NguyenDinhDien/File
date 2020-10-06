using MTIJ.Common;
using MTIJ.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MTIJ.Models
{
    public class ReceptRegisterModel
    {
        public string applicationId { get; set; }
        public string applicationSecret { get; set; }
        public ReceptRegistRequest ReceptRegistRequest { get; set; }
    }
    public class ReceptRegistRequest
    {
        [RegularExpression("([0-9])")]
        public UInt16 majorVersion { get; set; }

        [RegularExpression("([0-9])")]
        public UInt16 minorVersion { get; set; }

        [RegularExpression("([0-9])")]
        public UInt16 fixVersion { get; set; }
        public ReceptInfo ReceptInfo { get; set; }
        public DesireAmountsInfo DesireAmountsInfo { get; set; }
        public ReceptPersonalInfo PersonalInfo { get; set; }
        public ReceptHomeInfo HomeInfo { get; set; }
        public ReceptCompanyInfo CompanyInfo { get; set; }
        public TasyaKariireInfo TasyaKariireInfo { get; set; }
        public KeiyakuInfo KeiyakuInfo { get; set; }

        [RegularExpression("([1-9][0-9]{2})")]
        public int yobi1 { get; set; }

        [RegularExpression("([1-9][0-9]{2})")]
        public int yobi2 { get; set; }

        [RegularExpression("([1-9][0-9]{2})")]
        public int yobi3 { get; set; }

    }
    public class ReceptInfo
    {
        [RegularExpression("([1-9][0-9]{5})")]
        [JsonProperty("uketsukeNo")]
        public int YOBI12 { get; set; }

        [RegularExpression("([0-9])")]
        [JsonProperty("uketsukeKubun")]
        public int UKUBUN { get; set; }

        [RegularExpression("([0-9])")]
        [JsonProperty("uketsukeBaitai")]
        public int UBAITAI { get; set; }

        [StringLength(14)]
        public string uketsukeDate { get; set; }

        [StringLength(40)]
        [CustomSingleByte]
        [JsonProperty("hostName")]
        public string YOBI11 { get; set; }
    }
    public class DesireAmountsInfo
    {
        [RegularExpression("([1-9][0-9]{4})")]
        [JsonProperty("kibouKin")]
        public int MKIN { get; set; }

        [RegularExpression("([1-9][0-9])")]
        [JsonProperty("riyoMokuteki")]
        public int YOBI1 { get; set; }

        [RegularExpression("([1-9][0-9]{2})")]
        [JsonProperty("koukokuBaitai")]
        public int YOBI9 { get; set; }
    }
    public class ReceptPersonalInfo
    {
        [StringLength(40)]
        [CustomTwoByte]
        [JsonProperty("name")]
        public string NAME { get; set; }

        [StringLength(20)]
        [CustomSingleByte]
        [JsonProperty("nameX")]
        public string NAMEX { get; set; }

        [RegularExpression("([1-2])")]
        public int wareki { get; set; }

        [StringLength(8)]
        [JsonProperty("birthday")]
        public string BIRTHDAY { get; set; }

        [RegularExpression("([1-9])")]
        [JsonProperty("sex")]
        public short? SEX { get; set; }

        [RegularExpression("([1-9][0-9])")]
        [JsonProperty("dokuki")]
        public short? DOKI { get; set; }

        [EmailAddress, StringLength(40)]
        [RegularExpression(Const.PATTERN_EMAIL)]
        [JsonProperty("email")]
        public string EMAIL { get; set; }

        [RegularExpression("([1-2])")]
        [JsonProperty("mailKubun")]
        public short? JTELKBN { get; set; }
    }
    public class ReceptHomeInfo
    {
        [Required]
        [RegularExpression("([0-1])")]
        [JsonProperty("homeInfoChange")]
        public int YOBI7 { get; set; }

        [StringLength(8)]
        [JsonProperty("jitakuZip")]
        public string JZIP { get; set; }

        [StringLength(160)]
        [CustomTwoByte]
        [JsonProperty("jitakuAddr")]
        public string JADDR1 { get; set; }

        [StringLength(160)]
        [CustomTwoByte]
        [JsonProperty("jitakuAddr2")]
        public string JADDR2 { get; set; }

        [StringLength(80)]
        [CustomSingleByte]
        [JsonProperty("jitakuAddrX")]
        public string JADDRX1 { get; set; }

        [StringLength(80)]
        [CustomSingleByte]
        [JsonProperty("jitakuAddrX2")]
        public string JADDRX2 { get; set; }

        [StringLength(18)]
        [CustomSingleByte]
        [JsonProperty("keitaiTel")]
        public string RENTEL { get; set; }

        [StringLength(18)]
        [CustomSingleByte]
        [JsonProperty("jitakuTel")]
        public string JTEL { get; set; }

        [RegularExpression("([1-9][0-9])")]
        [JsonProperty("jyukyoKubun")]
        public short? JYUKYO { get; set; }

        [RegularExpression("([1-9][0-9])")]
        [JsonProperty("jyukyoMeigi")]
        public short? JMEIGI { get; set; }

        [StringLength(6)]
        [JsonProperty("nyukyoNentsuki")]
        public string NYUKYO { get; set; }

        [RegularExpression("([1-9][0-9])")]
        [JsonProperty("doukyoNinzu")]
        public short? DOUKYO { get; set; }

        [RegularExpression("([1-9][0-9])")]
        [JsonProperty("kazokuNinpi")]
        public short? NINPI { get; set; }
    }
    public class ReceptCompanyInfo
    {
        [Required]
        [RegularExpression("([0-1])")]
        [JsonProperty("companyInfoChange")]
        public int YOBI8 { get; set; }

        [StringLength(160)]
        [CustomTwoByte]
        [JsonProperty("kaisyaName")]
        public string KINNAME { get; set; }

        [StringLength(8)]
        [CustomSingleByte]
        [JsonProperty("kaisyaZip")]
        public string KZIP { get; set; }

        [StringLength(160)]
        [CustomTwoByte]
        [JsonProperty("kaisyaAddr")]
        public string KADDR1 { get; set; }

        [StringLength(160)]
        [CustomTwoByte]
        [JsonProperty("kaisyaAddr2")]
        public string KADDR2 { get; set; }

        [StringLength(80)]
        [CustomSingleByte]
        [JsonProperty("kaisyaAddrX")]
        public string KADDRX1 { get; set; }

        [StringLength(80)]
        [CustomSingleByte]
        [JsonProperty("kaisyaAddrX2")]
        public string KADDRX2 { get; set; }

        [StringLength(18)]
        [CustomSingleByte]
        [JsonProperty("kaisyaTelD")]
        public string KTELD { get; set; }

        [StringLength(18)]
        [CustomSingleByte]
        [JsonProperty("kaisyaTelC")]
        public string KTELC { get; set; }

        [RegularExpression("([1-9][0-9])")]
        [JsonProperty("yakusyoku")]
        public short? YAKUSYOKU { get; set; }

        [RegularExpression("([1-9][0-9])")]
        [JsonProperty("hoken")]
        public short? HOKEN { get; set; }

        [RegularExpression("([1-9][0-9])")]
        [JsonProperty("kyuryobi")]
        public short? KYURYO { get; set; }

        [RegularExpression("([1-9][0-9]{2})")]
        [JsonProperty("nensyuu")]
        public short? NENSYUU { get; set; }

        [RegularExpression("([1-9][0-9]{2})")]
        [JsonProperty("gessyu")]
        public int YOBI3 { get; set; }

        [RegularExpression("([1-9][0-9]{5})")]
        [JsonProperty("nyusya")]
        public string NYUSHA { get; set; }

        [RegularExpression("([1-9][0-9])")]
        [JsonProperty("koyou")]
        public short? KOYOU { get; set; }

        [RegularExpression("([1-9][0-9])")]
        [JsonProperty("gyosyu")]
        public short? GYOSHU { get; set; }

        [RegularExpression("([1-9][0-9])")]
        [JsonProperty("syokusyu")]
        public short? SYOKUSYU { get; set; }

        [RegularExpression("([0-9])")]
        [JsonProperty("syainsu")]
        public short? KKIBO { get; set; }
    }
    public class TasyaKariireInfo
    {
        [RegularExpression("([0-9])")]
        [JsonProperty("tasyaJiko")]
        public int YOBI2 { get; set; }

        [RegularExpression("([0-9])")]
        [JsonProperty("tasyaKariKen")]
        public short? RKEN { get; set; }

        [RegularExpression("([1-9][0-9]{3})")]
        [JsonProperty("tasyaKariKin")]
        public int? RKIN { get; set; }

    }
    public class KeiyakuInfo
    {
        [RegularExpression("([0-9])")]
        [JsonProperty("keiyakuHouhou")]
        public short? KEIYAKU { get; set; }

        [RegularExpression("([0-9])")]
        [JsonProperty("soufusaki")]
        public short? YUUSO { get; set; }

        [StringLength(8)]
        [CustomSingleByte]
        [JsonProperty("soufusakiZip")]
        public string OLDNAMEX { get; set; }

        [StringLength(160)]
        [CustomTwoByte]
        
        public string soufusakiAddr { get; set; }

        [StringLength(160)]
        [CustomTwoByte]
        public string soufusakiAddr2 { get; set; }

        [StringLength(40)]
        [CustomTwoByte]
        [JsonProperty("soufusakiName")]
        public string OLDNAME { get; set; }
    }
}