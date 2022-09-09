using System.Net;
using QFE.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Quran.API.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class SurahController : ControllerBase
    {

        //[HttpGet(Name = "GetSurah")]
        [HttpGet("[action]")]

        public IEnumerable<surah> GetSurah()
        {
            return LoadSurah(0);
        }
        //[HttpGet(Name = "GetSurahByIndex")]
        [HttpGet("[action]")]

        public surah GetSurahByIndex(int Index)
        {
            if(Index>0 && Index <= 114)
            {
                return QFE.BLL.quran_data.getSurah(Index);
            }

            return null;
        }
        //[HttpGet(Name = "GetSurahByJuz")]
        [HttpGet("[action]")]
        public IEnumerable<surah> GetSurahByJuz(int Juz)
        {
            return LoadSurah(Juz);
        }
        [HttpGet("[action]")]
        private IEnumerable<surah> LoadSurah(int Juz = 0)
        {
            IList<QFE.DAL.surah> data = null;
            if (Juz <= 0)
            {
                data = QFE.BLL.quran_data.getSurahNames();
            }
            else
            {
                data = QFE.BLL.quran_data.getSurahFromJuz(Juz);
            }
            return data;
        }

    }
}
