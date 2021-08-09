using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
    public class DonateDetailDto:IDto
    {
        public int DonateId { get; set; }
        public string DonateName { get; set; }
        public int DonateImageId{ get; set; }
        public int Price { get; set; }
        public int UsageTime { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }

    }
}
