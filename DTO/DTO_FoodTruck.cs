using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_FoodTruckType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Schedule { get; set; }
        public DTO_MenuType Menu { get; set; }
    }
}
