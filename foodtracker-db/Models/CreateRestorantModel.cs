using System;
using System.Collections;
using System.Collections.Generic;

namespace foodtracker_db.Models
{
    public class CreateRestorantModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public DateTime Establishment { get; set; }
    }
}