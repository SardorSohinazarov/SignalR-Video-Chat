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

            return Ok(new List<Domain.Entities.Chat>()
            {
                new Domain.Entities.Chat()
                {
                    Id = 1,
                    Name = "Chat1",
                    Link = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now,
                },
                new Domain.Entities.Chat()
                {
                    Id = 2,
                    Name = "Chat2",
                    Link = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now,
                },
                new Domain.Entities.Chat()
                {
                    Id = 3,
                    Name = "Chat3",
                    Link = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now,
                },
            });
        }
    }
}
