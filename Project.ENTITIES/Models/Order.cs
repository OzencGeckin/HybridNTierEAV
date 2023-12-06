﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order : BaseEntity
    {
        public string ShippingAddress { get; set; } 
        public string Email { get; set; } 
        public string NameDescription { get; set; }
        public int? AppUserID { get; set; }       
        public decimal PriceOfOrder { get; set; } 

        //Relational Properties
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual AppUser AppUser { get; set; }


    }
}
