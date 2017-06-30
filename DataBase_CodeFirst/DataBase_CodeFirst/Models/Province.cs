﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_CodeFirst.Models
{
   public  class Province
    {
        [Key]
        public int ProvinceID { get; set; }

        public string ProvinceName { get; set; }

        public virtual Country country { get; set; }

        public ICollection<Town> towns { get; set; }
    }
}
