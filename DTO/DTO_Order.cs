using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_OrderType
    {
        public int Id { get; set; }
        public DTO_CustomerType Customer { get; set; }
        public IList<DTO_FoodItemType> Items { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
