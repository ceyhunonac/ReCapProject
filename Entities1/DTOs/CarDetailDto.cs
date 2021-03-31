using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities1.DTOs
{
    public class CarDetailsDto:IDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public string ModelYear { get; set; }
        public string Descriptions { get; set; }
    }
}
