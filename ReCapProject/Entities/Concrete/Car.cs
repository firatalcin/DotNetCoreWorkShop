using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }

        public Car(int BrandId, int ColorId, int ModelYear, int DailyPrice, string Description)
        {
            this.BrandId = BrandId;
            this.ColorId = ColorId;
            this.ModelYear = ModelYear;
            this.DailyPrice = DailyPrice;
            this.Description = Description;
        }
    }
}
