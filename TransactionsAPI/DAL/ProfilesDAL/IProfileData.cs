using TransactionsAPI.DataModels;

namespace TransactionsAPI.DAL.ProfilesDAL
{
    public interface IProfileData
    {
        Task<Guid> CreateProfileAsync(Profiles profile);
        Task<Profiles> GetProfileAsync(Guid profileId);
        Task<bool> UpdateProfileAsync(Profiles profile);
        Task<bool> DeleteProfileAsync(Guid profileId);
    }
}
