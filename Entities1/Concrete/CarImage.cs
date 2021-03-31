using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities1.Concrete
{
    public class CarImage:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public DateTime ImageDate { get; set; }
        public string ImagePath { get; set; }
    }
}
