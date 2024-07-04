
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PracticeShop.BLL.DTOs.User;
using PracticeShop.BLL.Services.Interfaces;
using PracticeShop.DAL.Data;
using PracticeShop.DAL.Entities;
using FluentValidation.AspNetCore;

namespace PracticeShop.BLL.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork unitOfWork;
        private IHashService hashService;

        public UserService(IUnitOfWork unitOfWork, IHashService hashService) 
        {
            this.unitOfWork = unitOfWork;
            this.hashService = hashService;
        }

        public async Task CreateUserAsync(UserDTO user, CancellationToken cancellationToken)
        {
            var password = hashService.HashPassword(user.Password, out var salt);
            User entity = new User() { Id = Guid.NewGuid(), Name = user.Name, Email = user.Email, Password = password, PasswordSalt = salt, Balance = 0f };
            await unitOfWork.UserRepository.Add(entity);

        }

        public async Task DeleteUserAsync(Guid id, CancellationToken cancellationToken)
        {
            if (id == null)
            {
                throw new Exception("");
            }
            await unitOfWork.UserRepository.Delete(new User() { Id = id });

        }

        public async Task<IEnumerable<UserDTO>> GetAllAsync(CancellationToken cancellationToken)
        {
            var entities = await unitOfWork.UserRepository.GetAll();

            if (entities is null)
            {
                throw new Exception("");
            }

            List<UserDTO> users = new List<UserDTO>();

            foreach (var entity in entities)
            {
                var user = new UserDTO() { Name = entity.Name, Email = entity.Email, Password = entity.Password };
                users.Add(user);
            }

            return users;

        }

        public async Task UpdateUserAsync(UpdateUser user, CancellationToken cancellationToken)
        {
            var entity = await unitOfWork.UserRepository.GetById(user.Id);

            if (entity is null)
            {
                throw new Exception("");
            }
            entity.Balance = user.Balance;
            await unitOfWork.UserRepository.Update(entity);
        }
    }
}
