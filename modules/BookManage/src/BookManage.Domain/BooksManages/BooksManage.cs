using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookManage.BooksManages
{
    public class BooksManage : AuditedAggregateRoot<Guid>
    {
        public Guid AuthorId { get; set; }

        public string Name { get; set; }

        public BooksManageType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }

        public int Amount { get; set; }
    }
}
