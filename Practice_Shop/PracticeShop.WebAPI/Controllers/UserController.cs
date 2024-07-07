using Microsoft.AspNetCore.Mvc;
using PracticeShop.BLL.DTOs.User;
using PracticeShop.BLL.Services.Interfaces;

namespace PracticeShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly CancellationToken token;


        public UserController(IUserService userService)
        {
            this.userService = userService;

            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;
        }

        [HttpGet]
        public async Task<IResult> GetAll()
        {
            var users = await userService.GetAllAsync(token);
            return Results.Json(users);
        }

        [HttpPost]
        public async Task Create(UserDTO user)
        {
            await userService.CreateUserAsync(user, token);
        }

        [HttpPut]
        public async Task Update(UpdateUser user)
        {
            await userService.UpdateUserAsync(user, token);
        }

        [HttpDelete]
        public async Task Delete(Guid id)
        {
            await userService.DeleteUserAsync(id, token);
        }
    }
}
