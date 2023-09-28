using BackEndMCF.Models;
using BackEndMCF.RequestModel;
using Microsoft.AspNetCore.Mvc;

namespace BackEndMCF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private CodeMcfContext _context;
        public HomeController()
        {
            _context = new CodeMcfContext();
        }

        [HttpPost("InsertData")]
        public object InsertData(RequestInsertData rid)
        {
            try
            {
                TrBpkb locationStorage = new TrBpkb()
                {
                    AgreementNumber = rid.AgreementNumber,
                    BpkbDate = rid.BpkbDate,
                    BpkbDateIn = rid.BpkbDateIn,
                    BpkbNo = rid.BpkbNo,
                    BranchId = rid.BranchId,
                    CreatedBy = rid.CreatedBy,
                    CreatedOn = rid.CreatedOn,
                    FakturDate = rid.FakturDate,
                    FakturNo = rid.FakturNo,
                    LastUpdateBy = rid.LastUpdateBy,
                    LastUpdateOn = rid.LastUpdateOn,
                    PoliceNo = rid.PoliceNo,
                    LocationId = rid.LocationId
                };
                return new { success = true };
            }
            catch(Exception ex)
            {
                return new { success = false, message = "Something Wrong" };
            }
        }
    }
}
