﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject.Models
{
   public class Orders
   {
      [Key]
      public int OrderId { get; set; }
      public string OrderName { get; set; }

      public string orderQuantity { get; set; }

      public string orderTotal { get; set; }

   }
}
