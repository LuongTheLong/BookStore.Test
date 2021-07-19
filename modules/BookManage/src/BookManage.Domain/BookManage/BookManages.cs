using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookManage.BookManage
{
    public class BookManages : AuditedAggregateRoot<Guid>
    {
        public Guid AuthorId { get; set; }

        public string Name { get; set; }

        public BookManagesType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }

        public int Amount { get; set; }
    }
}
