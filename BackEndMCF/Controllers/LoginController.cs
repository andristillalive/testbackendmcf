using BackEndMCF.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEndMCF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private CodeMcfContext _context;
        public LoginController()
        {
            _context = new CodeMcfContext();
        }

        [HttpGet("Login")]
        public object Login(string username, string password)
        {
            try
            {
                username = (username == null) ? "" : username;
                password = (password == null) ? "" : password;
                MsUser user = _context.MsUsers.SingleOrDefault(p => p.UserName == username);
                if(user != null)
                {
                    if(user.Password == password)
                    {
                        return new { success = true };
                    }
                    else
                    {
                        return new { success = false, message = "Password Wrong." };
                    }
                }
                else
                {
                    return new { success = false, message = "User Not Found." };
                }
            }
            catch (Exception ex)
            {
                return new { success = false, message = "Something Wrong." };
            }
        }
    }
}
