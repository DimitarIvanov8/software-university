﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FastFood.Models.Enums;

namespace FastFood.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string Customer { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public OrderType Type { get; set; }

        [Required]
        [NotMapped]
        public decimal TotalPrice { get; set; }

        public int EmployeeId  { get; set; }

        [Required]
        public Employee Employee { get; set; }

        public ICollection<OrderItem> OrderItems  { get; set; }
    }
}
