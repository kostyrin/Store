﻿using System.ComponentModel.DataAnnotations;

namespace Factory.StoreServicesModule.DTOs
{
    public class ShopperDTO
    {
        public string ShopperId { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50)]
        public string ShopperName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public bool IsActive { get; set; }
    }
}