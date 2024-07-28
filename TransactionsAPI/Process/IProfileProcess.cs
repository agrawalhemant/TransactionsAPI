using TransactionsAPI.DataModels;
using TransactionsAPI.ViewModels;

namespace TransactionsAPI.Process
{
    public interface IProfileProcess
    {
        Task<Guid> CreateProfileAsync(InputProfileDto profile);
        Task<Profile> GetProfileAsync(Guid profileId);
        Task<bool> UpdateProfileAsync(Profile profile);
        Task<bool> DeleteProfileAsync(Guid profileId);
    }
}
