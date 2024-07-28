using TransactionsAPI.DAL.ProfilesDAL;
using TransactionsAPI.DataModels;
using TransactionsAPI.ViewModels;

namespace TransactionsAPI.Process
{
    public class ProfileProcess : IProfileProcess
    {
        private readonly IProfileData _profileData;
        public ProfileProcess(IProfileData profileData)
        {
            _profileData = profileData;
        }
        public async Task<Guid> CreateProfileAsync(InputProfileDto profile)
        {
            Profile prf = new Profile()
            {
                name = profile.UserName,
                email = profile.Email,
                img = profile.ProfileImg,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };
            return await _profileData.CreateProfileAsync(prf);
        }

        public async Task<bool> DeleteProfileAsync(Guid profileId)
        {
            return await _profileData.DeleteProfileAsync(profileId);
        }

        public async Task<Profile> GetProfileAsync(Guid profileId)
        {
            return await _profileData.GetProfileAsync(profileId);
        }

        public async Task<bool> UpdateProfileAsync(Profile profile)
        {
            return await _profileData.UpdateProfileAsync(profile);
        }
    }
}
