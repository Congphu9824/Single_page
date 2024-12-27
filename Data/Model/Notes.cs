using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Notes
    {
        [Key]
        public Guid Id { get; set; }
        public required string Text { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public Guid? StaffId { get; set; }
        public Staffs? Staff { get; set; }
    }
}
