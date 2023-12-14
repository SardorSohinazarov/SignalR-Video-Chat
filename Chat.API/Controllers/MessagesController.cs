using Chat.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Chat.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetMessagesAsync()
        {

            return Ok(new List<Message>()
            {
                new Message()
                {
                    Id = 1,
                    Text = "Message1",
                    CreatedAt = DateTime.Now
                },
                new Message()
                {
                    Id = 2,
                    Text = "Message2",
                    CreatedAt = DateTime.Now
                },
                new Message()
                {
                    Id = 3,
                    Text = "Message3",
                    CreatedAt = DateTime.Now
                },
            });
        }
    }
}
