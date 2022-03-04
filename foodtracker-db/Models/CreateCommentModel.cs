using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foodtracker_db.Models
{
    public class CreateCommentModel
    {
        public string Commentator { get; set; }
        public string Value { get; set; }
        [Range(0,5,ErrorMessage="Value for {0} must be between 0-5.")]
        public int Score { get; set; }
    }
}