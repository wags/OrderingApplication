﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderingApplication.Models
{
    public class Client
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        [EmailAddress]
        [Remote("VerifyEmail", "Client")]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public DateTime? ContactDate { get; set; }
        [Required]
        public string ClientType { get; set; }
        [Required]
        [MaxLength(25)]
        public string Notes { get; set; }
        public Address BillingAddress { get; set; }
        public Address MailingAddress { get; set; }
    }
}
