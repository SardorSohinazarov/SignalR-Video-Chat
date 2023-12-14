using Chat.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Chat.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAccountsAsync()
        {

            return Ok(new List<Account>()
            {
                new Account()
                {
                    Id = 1,
                    FirstName = "Sardor",
                    LastName = "Sohinazarov",
                    PasswordHash = Guid.NewGuid().ToString(),
                    RefreshToken = Guid.NewGuid().ToString(),
                    ExpireDate = DateTime.Now,
                    CreatedAt = DateTime.Now,
                },
                new Account()
                {
                    Id = 2,
                    FirstName = "Sarvar",
                    LastName = "Sohinazarov",
                    PasswordHash = Guid.NewGuid().ToString(),
                    RefreshToken = Guid.NewGuid().ToString(),
                    ExpireDate = DateTime.Now,
                    CreatedAt = DateTime.Now,
                },
                new Account()
                {
                    Id = 3,
                    FirstName = "Sanjar",
                    LastName = "Sohinazarov",
                    PasswordHash = Guid.NewGuid().ToString(),
                    RefreshToken = Guid.NewGuid().ToString(),
                    ExpireDate = DateTime.Now,
                    CreatedAt = DateTime.Now,
                },
            });
        }
    }
}
