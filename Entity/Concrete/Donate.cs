using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Donate:IEntity
    {
        public int DonateId { get; set; }
        public string DonateName{ get; set; }
        public int Price { get; set; }
        public int UsageTime { get; set; }
        public string Description { get; set; }
    }
}
