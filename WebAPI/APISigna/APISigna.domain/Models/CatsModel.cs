using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace APISigna.domain.Models
{
    [Table("Cats")]
    public class CatsModel
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Age")]
        public int Age { get; set; }

        [Column("OwnerId")]
        public int OwnerId { get; set; }
    }
}
