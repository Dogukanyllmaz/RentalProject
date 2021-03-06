﻿using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PaymentDto : IDto
    {
        public Rental rental { get; set; }
        public decimal amount { get; set; }
        public string cardNumber { get; set; }
    }
}