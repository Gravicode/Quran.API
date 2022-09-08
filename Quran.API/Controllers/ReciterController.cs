using System.Net;
using Microsoft.AspNetCore.Mvc;
using QFE.DAL;

namespace Quran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReciterController : ControllerBase
    {

        //[HttpGet(Name = "GetReciters")]
        [HttpGet("[action]")]
        public IEnumerable<reciter> GetReciters()
        {
            return QFE.BLL.quran_data.getReciters();
        }
        //[HttpGet(Name = "GetReciterByIndex")]
        [HttpGet("[action]")]
        public reciter GetReciterByIndex(int Index)
        {
            if (Index >= 0 )
            {
                return QFE.BLL.quran_data.getReciter(Index);
            }

            return null;
        }
        

    }
}
