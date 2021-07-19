using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BookManage.BookManage
{
    public class BookManagesDto : AuditedEntityDto<Guid>
    {
        public Guid AuthorId { get; set; }

        public string AuthorName { get; set; }

        public string Name { get; set; }

        public BookManagesType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }

        public int Amount { get; set; }
    }
}
