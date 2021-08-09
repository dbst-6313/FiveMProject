using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
    public class DonateDetailDto
    {
        public int DonateId { get; set; }
        public int Id { get; set; } //user ıd
        public string DonateName { get; set; }
        public int Price { get; set; }
        public int UsageTime { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }

    }
}
