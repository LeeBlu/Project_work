﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_CodeFirst.Models
{
    class AddressType
    {
       [Key]
        public int AddressTypeID { get; set; }

        public string AddressTypeDecs { get; set; }
    }
}