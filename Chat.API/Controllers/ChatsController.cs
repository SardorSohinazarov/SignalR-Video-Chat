using Microsoft.AspNetCore.Mvc;

namespace Chat.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChatsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetChatsAsync()
        {

            return Ok(new List<Entities.Chat>()
            {
                new Entities.Chat()
                {
                    Id = 1,
                    Name = "Chat1",
                    CreatedAt = DateTime.Now,
                },
                new Entities.Chat()
                {
                    Id = 2,
                    Name = "Chat2",
                    CreatedAt = DateTime.Now,
                },
            });
        }
    }
}
