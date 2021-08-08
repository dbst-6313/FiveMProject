using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class FivemUser:IEntity
    {
        [Key]
        public string identifier { get; set; }
        public string license { get; set; }
        public int money { get; set; }
        public string name { get; set; }
        public string skin { get; set; }
        public string job { get; set; }
        public int job_grade { get; set; }
        public string loadout { get; set; }
        public string position { get; set; }
        public int bank { get; set; }
        public int permission_level { get; set; }
        public string skills { get; set; }
        public string group { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string dateofbirth { get; set; }
        public string sex { get; set; }
        public string height { get; set; }
        public string tattoos { get; set; }
        public string phone_number { get; set; }
        public string house { get; set; }
        public string bought_furniture { get; set; }
        public int jail { get; set; }
        public string lastdigits { get; set; }
        public string status { get; set; }
        public string last_property { get; set; }
        public string last_motel { get; set; }
        public string last_motel_room { get; set; }
        public int armour { get; set; }
        public string crypto { get; set; }
        public int is_dead { get; set; }
    }
}
