using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiExample.Models;

namespace WebApiExample.Controllers
{
    public class KisiController : ApiController
    {
        [HttpGet]
        public List<KisiBilgileri> GetAllData()
        {
            var responseList = new List<KisiBilgileri>
            {
                new KisiBilgileri{
                    Ad="Ali",
                    Soyad="Artçı",
                    AktifMi=true,
                },
                new KisiBilgileri{
                    Ad="Mahmut",
                    Soyad="Okka",
                    AktifMi=true,
                },
                new KisiBilgileri{
                    Ad="Yusuf",
                    Soyad="Bahar",
                    AktifMi=true,
                },
                new KisiBilgileri{
                    Ad="Gürkan",
                    Soyad="Uygur",
                    AktifMi=true,
                },
                new KisiBilgileri{
                    Ad="Tarık",
                    Soyad="Mengi",
                    AktifMi=true,
                },
                new KisiBilgileri{
                    Ad="Cüneyt",
                    Soyad="Akkan",
                    AktifMi=true,
                },
            };

            return responseList;
        }
    }
}