using System;
using Volo.Abp.Application.Dtos;

namespace BookManage.BooksManages
{
    public class BooksManageDto : AuditedEntityDto<Guid>
    {
        public Guid AuthorId { get; set; }

        public string AuthorName { get; set; }

        public string Name { get; set; }

        public BooksManageType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }

        public int Amount { get; set; }
    }
}
