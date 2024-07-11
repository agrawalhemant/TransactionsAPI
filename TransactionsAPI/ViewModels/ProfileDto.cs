namespace TransactionsAPI.ViewModels
{
    public class ProfileDto
    {
        public int ProfileId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string ProfileImg { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
