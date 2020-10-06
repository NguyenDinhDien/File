using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MTIJ.Models;
using MTIJ.Common;
using MTIJ.Filters;
using System.Data.Entity.Validation;
using AutoMapper;

namespace MTIJ.Controllers
{
    [RoutePrefix(Const.API_PREFIX_RECEPTS)]
    public class ReceptsController : ApiController
    {
        [HttpPost]
        [Route("")]
        public IHttpActionResult Recepts([FromBody] ReceptRegisterModel recepts)
        {
            Error error = new Error();
            try
            {
                //Check maintenance service
                if (!Utils.CheckMaintenance())
                {
                    error.message = Const.MESSAGE_MAINTENANCE;
                    error.type = Const.TYPE_MAINTENANCE;

                    return new ErrorResult(error, HttpStatusCode.ServiceUnavailable);
                }
                //if (!ModelState.IsValid) // check isValid parameter model
                //{
                //    foreach (var modelStateKey in ModelState.Keys)
                //    {
                //        var modelStateVal = ModelState[modelStateKey];
                //        foreach (var errorModel in modelStateVal.Errors)
                //        {
                //            string[] element = modelStateKey.Split(".".ToCharArray());
                //            error.type = "ApplicationFormDataError";
                //            error.message = "Application Form Data (" + element.LastOrDefault() + ") are invalid or missing.";
                //            return new ErrorResult(error, HttpStatusCode.BadRequest);
                //        }
                //    }
                //}

                ////get object ReceptRegistRequest 
                //var receptRegistRequest = recepts.ReceptRegistRequest;
                ////init ReceptIndo
                //ReceptInfo receptInfo = new ReceptInfo();
                //receptInfo = receptRegistRequest.ReceptInfo;
                ////init DesireAmountsInfo
                //DesireAmountsInfo desireAmountsInfo = new DesireAmountsInfo();
                //desireAmountsInfo = receptRegistRequest.DesireAmountsInfo;
                ////init PersonalInfo
                //ReceptPersonalInfo personalInfo = new ReceptPersonalInfo();
                //personalInfo = receptRegistRequest.PersonalInfo;
                ////init HomeInfo
                //ReceptHomeInfo homeInfo = new ReceptHomeInfo();
                //homeInfo = receptRegistRequest.HomeInfo;
                ////init CompanyInfo
                //ReceptCompanyInfo companyInfo = new ReceptCompanyInfo();
                //companyInfo = receptRegistRequest.CompanyInfo;
                ////init TasyaKariireInfo
                //TasyaKariireInfo tasyaKariireInfo = new TasyaKariireInfo();
                //tasyaKariireInfo = receptRegistRequest.TasyaKariireInfo;
                ////init KeiyakuInfo
                //KeiyakuInfo keiyakuInfo = new KeiyakuInfo();
                //keiyakuInfo = receptRegistRequest.KeiyakuInfo;

                try
                {
                    //LWEB lWEB = new LWEB();
                    //lWEB.RECID = 0;
                    //lWEB.UKUBUN = receptInfo.uketsukeKubun.ToString();
                    //lWEB.UBAITAI = receptInfo.uketsukeBaitai.ToString();
                    //lWEB.YOBI11 = receptInfo.hostName;
                    //lWEB.YOBI12 = receptInfo.uketsukeNo.ToString();

                    //DateTime uketsukeDate = Utils.ParseDateTime(receptInfo.uketsukeDate, "yyyyMMddHHmmss");
                    //lWEB.UDATE = uketsukeDate.ToString("yyyyMMdd");
                    //lWEB.UTIME = uketsukeDate.ToString("HHmmss");

                    //lWEB.ATTR = "14";
                    //lWEB.WSTATUS = 1;
                    //lWEB.NAME = personalInfo.name;
                    //lWEB.NAMEX = personalInfo.nameX;
                    //lWEB.BIRTHDAY = personalInfo.birthday;
                    //lWEB.SEX = personalInfo.sex;
                    //lWEB.DOKI = personalInfo.dokuki;
                    //lWEB.EMAIL = personalInfo.email;
                    //lWEB.JTELKBN = personalInfo.mailKubun;

                    //lWEB.NENSYUU = companyInfo.nensyuu;
                    //lWEB.HOKEN = companyInfo.hoken;
                    //lWEB.NYUSHA = companyInfo.nyusya;
                    //lWEB.KOYOU = companyInfo.koyou;
                    //lWEB.GYOSHU = companyInfo.gyosyu;
                    //lWEB.SYOKUSYU = companyInfo.syokusyu;
                    //lWEB.KKIBO = companyInfo.syainsu;
                    //lWEB.KINNAME = companyInfo.kaisyaName;
                    //lWEB.KZIP = companyInfo.kaisyaZip;
                    //lWEB.KADDR1 = companyInfo.kaisyaAddr;
                    //lWEB.KADDR2 = companyInfo.kaisyaAddr2;
                    //lWEB.KADDRX1 = companyInfo.kaisyaAddrX;
                    //lWEB.KADDRX2 = companyInfo.kaisyaAddrX2;
                    //lWEB.KTELD = companyInfo.kaisyaTelD;
                    //lWEB.KTELC = companyInfo.kaisyaTelC;
                    //lWEB.YAKUSYOKU = companyInfo.yakusyoku;
                    //lWEB.KYURYO = companyInfo.kyuryobi;
                    //lWEB.YOBI3 = companyInfo.gessyu;
                    //lWEB.YOBI8 = companyInfo.companyInfoChange;

                    //lWEB.RENTEL = homeInfo.keitaiTel;
                    //lWEB.JZIP = homeInfo.jitakuZip;
                    //lWEB.JADDR1 = homeInfo.jitakuAddr;
                    //lWEB.JADDR2 = homeInfo.jitakuAddr2;
                    //lWEB.JADDRX1 = homeInfo.jitakuAddrX;
                    //lWEB.JADDRX2 = homeInfo.jitakuAddrX2;
                    //lWEB.JTEL = homeInfo.jitakuTel;
                    //lWEB.JYUKYO = homeInfo.jyukyoKubun;
                    //lWEB.JMEIGI = homeInfo.jyukyoMeigi;
                    //lWEB.NYUKYO = homeInfo.nyukyoNentsuki;
                    //lWEB.DOUKYO = homeInfo.doukyoNinzu;
                    //lWEB.NINPI = homeInfo.kazokuNinpi;
                    //lWEB.YOBI7 = homeInfo.homeInfoChange;

                    //lWEB.RKEN = tasyaKariireInfo.tasyaKariKen;
                    //lWEB.RKIN = tasyaKariireInfo.tasyaKariKin;
                    //lWEB.KEIYAKU = keiyakuInfo.keiyakuHouhou;
                    //lWEB.YOBI2 = tasyaKariireInfo.tasyaJiko;

                    //lWEB.YUUSO = keiyakuInfo.soufusaki;
                    //lWEB.OLDNAMEX = keiyakuInfo.soufusakiZip;
                    //lWEB.HONSEKI = keiyakuInfo.soufusakiAddr + " " + keiyakuInfo.soufusakiAddr2;
                    //lWEB.OLDNAME = keiyakuInfo.soufusakiName;

                    //lWEB.MKIN = desireAmountsInfo.kibouKin;
                    //lWEB.YOBI1 = desireAmountsInfo.riyoMokuteki;
                    //lWEB.YOBI9 = desireAmountsInfo.koukokuBaitai;
                    FKDBContext db = new FKDBContext();
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<ReceptRegisterModel, LWEB>();
                    });
                    IMapper iMapper = config.CreateMapper();
                    LWEB destination = iMapper.Map<LWEB>(recepts);
                    
                    db.LWEBs.Add(destination);
                    db.SaveChanges();



                    return Ok(recepts);
                }
                catch (DbEntityValidationException)
                {
                    error.message = Const.MESSAGE_ERROR_SAVE;
                    error.type = Const.TYPE_ERROR_SAVE;

                    return new ErrorResult(error, HttpStatusCode.InternalServerError);
                }
            }
            catch (Exception)
            {
                error.message = Const.MESSAGE_SERVERERROR;
                error.type = Const.TYPE_SERVERERROR;
                return new ErrorResult(error, HttpStatusCode.InternalServerError);
            }
        }
    }
}
