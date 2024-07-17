using TransactionsAPI.ViewModels;

namespace TransactionsAPI.Process
{
    public interface IProfileProcess
    {
        Task<Guid> CreateProfileAsync(ProfileDto profile);
        Task<ProfileDto> GetProfileAsync(Guid profileId);
        Task<bool> UpdateProfileAsync(ProfileDto profile);
        Task<bool> DeleteProfileAsync(Guid profileId);
    }
}
