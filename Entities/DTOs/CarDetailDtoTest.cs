using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public  class CarDetailDtoTest :IDto
    {
        public int CarId { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public string ModelYear { get; set; }
        public string BrandName { get; set; }
        public string CarDescription { get; set; }
        public string CarColor { get; set; }
        public decimal CarDailyPrice { get; set; }
    }
}
