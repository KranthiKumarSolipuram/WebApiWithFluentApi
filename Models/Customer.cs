﻿using WebApiWithFluentApi.Models;

namespace WebApiWithFluentApi.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
