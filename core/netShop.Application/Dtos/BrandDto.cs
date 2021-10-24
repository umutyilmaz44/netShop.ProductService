using System;
using System.Collections.Generic;
using System.Text;
using netShop.Domain.Common;

namespace netShop.Application.Dtos
{
    public class BrandDto : BaseEntity
    {
        public string brandName { get; set; }
        public string description { get; set; }

        public BrandDto()
        {

        }
        public BrandDto(Guid id, string brandName, string description) {
            this.Id = id;
            this.brandName = brandName;
            this.description = description;
        }
    }
}