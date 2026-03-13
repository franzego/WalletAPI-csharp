

using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using WalletApi.Enums;

namespace WalletApi.Entities
{
    public class Transaction
    {
        public Guid Id {get; set;}
        [ForeignKey("UserId")]
        public Guid UserId {get; set;}
        [ForeignKey("WalletId")]
        public Guid WalletID {get; set;}
        public required TransactionType Type {get; set;}

        public required Decimal Amount {get; set;}
        public required TransactionStatus Status {get; set;}

        public String? Reference {get; set;}
        public String? Description {get; set;}

        public JsonDocument? Metadata { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}