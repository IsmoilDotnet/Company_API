﻿using Company.Domain.Entities.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Company.Domain.Entities.DTOs
{
    public class UserProfileDTO
    {

        public string FullName { get; set; }
        public string Phone { get; set; }
        public int UserRole { get; set; }


        [MinLength(5)] [MaxLength(40)]
        public required string Login { get; set; }

        [MinLength(8)]
        public required string Password { get; set; }
    }
}
