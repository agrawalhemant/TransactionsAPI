
using TransactionsAPI.DataModels;

namespace TransactionsAPI.DAL.ProfilesDAL
{
    public class ProfileData : IProfileData
    {
        private TransactionDbContext _context;
        public ProfileData(TransactionDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> CreateProfileAsync(Profiles profile)
        {
            var txn = _context.Database;
            try
            {
                await txn.BeginTransactionAsync();
                await _context.Profile.AddAsync(profile);
                await _context.SaveChangesAsync();
                await txn.CommitTransactionAsync();
                return profile.id;
            }
            catch (Exception)
            {
                await txn.RollbackTransactionAsync();
                throw;
            }
        }

        public async Task<bool> DeleteProfileAsync(Guid profileId)
        {
            var txn = _context.Database;
            try
            {
                await txn.BeginTransactionAsync();
                var prf = await _context.Profile.FindAsync(profileId);
                if(prf is null)
                {
                    return false;
                }
                _context.Remove(prf);
                await _context.SaveChangesAsync();
                await txn.CommitTransactionAsync();
                return true;

            }
            catch (Exception)
            {
                await txn.RollbackTransactionAsync();
                throw;
            }
        }

        public async Task<Profiles> GetProfileAsync(Guid profileId)
        {
            try
            {
                return await _context.Profile.Where(x => x.id == profileId).FirstOrDefaultAsync();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdateProfileAsync(Profiles profile)
        {
            var txn = _context.Database;
            try
            {
                await txn.BeginTransactionAsync();
                var prf = await _context.Profile.FindAsync(profile.id);
                if(prf is null)
                {
                    return false;
                }
                prf.name = profile.name;
                prf.email = profile.email;
                prf.img = profile.img;
                prf.updated_at = DateTime.Now;
                await _context.SaveChangesAsync();
                await txn.CommitTransactionAsync();
                return true;
            }
            catch(Exception)
            {
                await txn.RollbackTransactionAsync();
                throw;
            }
        }
    }
}
