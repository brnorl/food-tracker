using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace foodtracker_db.Models
{
    public class Restorant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public DateTime Establishment { get; set; }
        public virtual ICollection<Comment> Comments {get;set;}
    }
}