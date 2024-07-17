using TransactionsAPI.DataModels;

namespace TransactionsAPI.DAL.ProfilesDAL
{
    public interface IProfileData
    {
        Task<Guid> CreateProfileAsync(Profile profile);
        Task<Profile> GetProfileAsync(Guid profileId);
        Task<bool> UpdateProfileAsync(Profile profile);
        Task<bool> DeleteProfileAsync(Guid profileId);
    }
}
