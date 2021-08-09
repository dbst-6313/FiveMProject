using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class DonateImage:IEntity
    {
        [Key]
        public int DonateImageId { get; set; }
        public int DonateId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
