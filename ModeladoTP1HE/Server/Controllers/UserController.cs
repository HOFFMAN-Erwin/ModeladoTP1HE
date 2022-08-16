using Microsoft.AspNetCore.Mvc;

namespace ModeladoTP1HE.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        [HttpGet]
        public async Task<LoginDataDTO> Get()
        {
            LoginDataDTO loginDataDTO = new LoginDataDTO
            {
                User = new User
                {
                    UserName = "Nombre Completo",
                    Email = "adsfasf@tuqui.com",
                    Id = "euiadhf23",
                    NameCompleted = "asd"
                }
            };
        }
        return loginDataDTO;
    }
}
