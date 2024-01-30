using Myforum.Areas.Identity.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Myforum.Model
{
    public class Topic
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Text { get; set; } = string.Empty;

        [Required]
        public string RazorUsersId { get; set; } 

        public DateTime DateCreated { get; set; } = DateTime.Now.ToUniversalTime();
        public DateTime DateUpdated { get; set; } = DateTime.Now.ToUniversalTime();
    }
}
