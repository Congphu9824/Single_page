using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Data.Enum;

namespace Data.Model
{
    public class Staff
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string NickName { get; set; } = string.Empty; // biệt danh
        public string? Place { get; set; } = string.Empty;
        public double? Salary { get; set; }
        public string? Gender {  get; set; } = string.Empty;
        public string? Position {  get; set; }
        public string? Status { get; set; } = string.Empty;
        public string? loacation {  get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; } = DateTime.Now;
        public DateTime? DateDeleted { get; set; } = DateTime.Now;
        public ICollection<Note>? notes { get; set; }

    }
}
