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
        public int Money { get; set; }
        public string name { get; set; }
        public string skin { get; set; }
        public string Job { get; set; }
        public int jobGrade { get; set; }
        public string loadout { get; set; }
        public string position { get; set; }
        public int bank { get; set; }
        public int permissionlevel { get; set; }
        public string skilss { get; set; }
        public string group { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dateOfBirth { get; set; }
        public string sex { get; set; }
        public string height { get; set; }
        public string tattoos { get; set; }
        public string phoneNumber { get; set; }
        public string house { get; set; }
        public string bought_furniture { get; set; }
        public int jail { get; set; }
        public string lastdigits { get; set; }
        public string status { get; set; }
        public string last_property { get; set; }
        public string last_motel { get; set; }
        public string lastMotelRoom { get; set; }
        public int armour { get; set; }
        public string crypto { get; set; }
        public int isDead { get; set; }
    }
}
