using AutoMapper;
using TransactionsAPI.DAL.ProfilesDAL;
using TransactionsAPI.DataModels;
using TransactionsAPI.ViewModels;

namespace TransactionsAPI.Process
{
    public class ProfileProcess : IProfileProcess
    {
        private readonly IProfileData _profileData;
        private readonly IMapper _mapper;
        public ProfileProcess(IProfileData profileData, IMapper mapper)
        {
            _profileData = profileData;
            _mapper = mapper;
        }
        public async Task<Guid> CreateProfileAsync(InputProfileDto profile)
        {
            var prf1 = _mapper.Map<Profiles>(profile);
            Profiles prf = new Profiles()
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

        public async Task<Profiles> GetProfileAsync(Guid profileId)
        {
            return await _profileData.GetProfileAsync(profileId);
        }

        public async Task<bool> UpdateProfileAsync(Profiles profile)
        {
            return await _profileData.UpdateProfileAsync(profile);
        }
    }
}
