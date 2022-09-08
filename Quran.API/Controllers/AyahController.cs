using System.Net;
using QFE.DAL;
using QFE.BLL;
using Microsoft.AspNetCore.Mvc;

namespace Quran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AyahController : ControllerBase
    {
        [HttpGet("[action]")]
        //[HttpGet(Name = "GetAyahFromSurah")]
        public IEnumerable<quran_data.AyahData> GetAyahFromSurah(int Surah, int LanguageId)
        {
            if (LanguageId < 0) LanguageId = 11;
            return QFE.BLL.quran_data.getVerses3(Surah, LanguageId);
        }

        [HttpGet("[action]")]
        // [HttpGet(Name = "GetAyahByIndex")]
        public quran_data.AyahData GetAyahByIndex(int Index,int Surah)
        {
            if (Surah > 0 && Surah <= 114)
            {
                return QFE.BLL.quran_data.getVerse(Surah, Index);
            }

            return null;
        }
        //[HttpGet(Name = "GetAyahCountBySurah")]
        [HttpGet("[action]")]
        public int GetAyahCountBySurah(int Surah)
        {
            if (Surah > 0 && Surah <= 114)
            {
                var Cnt =  QFE.BLL.quran_data.getVerses1(Surah);
                return Cnt.Count;
            }

            return 0;
        }
        //[HttpGet(Name = "GetMediaByAyah")]
        [HttpGet("[action]")]
        public MediaItem GetMediaByAyah(int Surah,int Ayah,int ReciterId)
        {
            try
            {
                var rec = QFE.BLL.quran_data.getReciter(ReciterId);
                string _Prefix = rec.mediaurl;
                string SurahKey = Surah.ToString().PadLeft(3, '0');
                string AyahKey = Ayah.ToString().PadLeft(3, '0');
                string MediaUrl = string.Format(_Prefix, SurahKey, AyahKey);
                string NamaFile = string.Format("{0}_{1}.mp3", SurahKey, AyahKey);

                return new MediaItem() { FileName = NamaFile, Url = MediaUrl };
            }
            catch { }
            return null;
        }

    }
}
