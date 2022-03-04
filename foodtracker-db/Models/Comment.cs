using System.ComponentModel.DataAnnotations.Schema;

namespace foodtracker_db.Models
{
    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RestorantId { get; set; }
        public string Commentator { get; set; }
        public string Value { get; set; }
        public int Score { get; set; }
    }
}