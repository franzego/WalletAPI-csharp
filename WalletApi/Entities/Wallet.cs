

using System.ComponentModel.DataAnnotations.Schema;

namespace WalletApi.Entities
{
    public class Wallet
    {
        public Guid Id {get; set;}
        [ForeignKey("UserId")]
        public Guid UserId {get; set;}

        public required String WalletNumber {get; set;}

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        
    }
}