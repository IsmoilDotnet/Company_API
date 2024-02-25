using Company.Domain.Entities.DTOs;
using Company.Domain.Entities.Models;

namespace Company.Application.Services.UserProfileServices
{
    public interface IUserProfileService
    {
        public Task<string> CreateUserProfileAsync(UserProfileDTO userDTO, string picturePath);
        public Task<List<UserProfile>> GetAllProfileAsync();
        public Task<List<UserProfile>> GetByIdUserProfileAsync(int id);
        public Task<bool> DeleteUserProfileAsync(int id);
        public Task<UserProfile> UpdateUserProfileAsync(int id, UserProfileDTO modelDTO);
    }
}
