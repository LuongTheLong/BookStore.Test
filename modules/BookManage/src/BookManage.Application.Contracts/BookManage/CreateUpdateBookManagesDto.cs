using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookManage.BookManage
{
    public class CreateUpdateBookManagesDto
    {
        public Guid AuthorId { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public BookManagesType Type { get; set; } = BookManagesType.Undefined;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Required]
        public float Price { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}
