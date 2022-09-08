using System.Net;
using QFE.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Quran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {

        //[HttpGet(Name = "GetLanguage")]
        [HttpGet("[action]")]
        public IEnumerable<language> GetLanguage()
        {
            return QFE.BLL.quran_data.getLanguage();
        }
        //[HttpGet(Name = "GetLanguageById")]
        [HttpGet("[action]")]
        public language GetLanguageById(int Index)
        {
            if (Index >= 0)
            {
                return QFE.BLL.quran_data.getLanguage(Index);
            }

            return null;
        }

      

    }
}
