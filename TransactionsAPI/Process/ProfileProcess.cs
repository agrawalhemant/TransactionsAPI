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
        public async Task<Guid> CreateProfileAsync(ProfileDto profile)
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

        public async Task<ProfileDto> GetProfileAsync(Guid profileId)
        {
            var prf = await _profileData.GetProfileAsync(profileId);
            if(prf is null)
            {
                return null;
            }
            ProfileDto profile = new ProfileDto()
            {
                ProfileId = prf.id,
                UserName = prf.name,
                Email = prf.email,
                ProfileImg = prf.img
            };
            return profile;
        }

        public async Task<bool> UpdateProfileAsync(ProfileDto profile)
        {
            Profile prf = new Profile()
            {
                id = profile.ProfileId,
                name = profile.UserName,
                email = profile.Email,
                img = profile.ProfileImg
            };
            return await _profileData.UpdateProfileAsync(prf);
        }
    }
}
