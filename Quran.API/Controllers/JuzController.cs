using System.Net;
using Microsoft.AspNetCore.Mvc;
using QFE.DAL;

namespace Quran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JuzController : ControllerBase
    {
        //[HttpGet(Name = "GetJuz")]
        [HttpGet("[action]")]
        public IEnumerable<juz> GetJuz()
        {
            return QFE.BLL.quran_data.getJuz();
        }
        //[HttpGet(Name = "GetJuzByIndex")]
        [HttpGet("[action]")]
        public juz GetJuzByIndex(int Index)
        {
            if (Index > 0 && Index <= 30)
            {
                return QFE.BLL.quran_data.getJuz(Index);
            }

            return null;
        }
        //[HttpGet(Name = "GetJuzBySurahAyah")]
        [HttpGet("[action]")]
        public juz GetJuzBySurahAyah(int Surah,int Ayah)
        {
            if (Surah > 0 && Surah <= 114)
            {
                return QFE.BLL.quran_data.getJuz(Surah,Ayah);
            }
            
            return null;
        }

     

    }
}
