using Company.Domain.Entities.DTOs;
using Company.Domain.Entities.Models;
using Company.Infrastucture.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Application.Services.UserProfileServices
{
    public class UserProfileService : IUserProfileService
    {
        private readonly ApplicationDbContext _context;

        public UserProfileService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> CreateUserProfileAsync(UserProfileDTO userDTO, string picturePath)
        {
            var model = new UserProfile()
            {
                FullName = userDTO.FullName,
                Phone = userDTO.Phone,
                UserRole = userDTO.UserRole,
                Login = userDTO.Login,
                Password = userDTO.Password,
                PicturePath = picturePath
            };
            await _context.Users.AddAsync(model);

            await _context.SaveChangesAsync();

            return "Succesfully";
        }

        public Task<bool> DeleteUserProfileAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserProfile>> GetAllProfileAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserProfile>> GetByIdUserProfileAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> UpdateUserProfileAsync(int id, UserProfileDTO modelDTO)
        {
            throw new NotImplementedException();
        }
    }
}
