using System;
using System.Collections.Generic;
using System.Text;
using WebStore.ViewModels;

namespace WebStore.Domain.DTO.Product
{
    public class PagedProductDTO
    {
        public IEnumerable<ProductDTO> Products { get; set; }

        public int TotalCount { get; set; }

        public object Select(Func<object, ProductViewModel> p)
        {
            throw new NotImplementedException();
        }
    }
}
