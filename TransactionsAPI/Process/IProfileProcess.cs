using TransactionsAPI.DataModels;
using TransactionsAPI.ViewModels;

namespace TransactionsAPI.Process
{
    public interface IProfileProcess
    {
        Task<Guid> CreateProfileAsync(InputProfileDto profile);
        Task<Profiles> GetProfileAsync(Guid profileId);
        Task<bool> UpdateProfileAsync(Profiles profile);
        Task<bool> DeleteProfileAsync(Guid profileId);
    }
}
