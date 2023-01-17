using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_InventoryType
    {
        public int Id { get; set; }
        public IList<DTO_IngredientType> Ingredients { get; set; }
    }
}
