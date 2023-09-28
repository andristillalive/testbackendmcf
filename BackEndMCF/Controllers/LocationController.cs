using BackEndMCF.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEndMCF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private CodeMcfContext _context;
        public LocationController()
        {
            _context = new CodeMcfContext();
        }

        [HttpGet("GetListLocation")]
        public object GetListLocation()
        {
            try
            {
                List<MsLocationStorage> msLocationStorages = _context.MsLocationStorages.ToList();
                List<object> location = new List<object>();
                foreach (var m in msLocationStorages)
                {
                    location.Add(new { id = m.LocationId, name = m.LocationName });
                }
                return new { success = true, data = location };
            }
            catch
            {
                return new { success = false, message = "Something Wrong." };
            }
        }
    }
}
