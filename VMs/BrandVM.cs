﻿using AmalCollections.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmalCollections.VMs
{
    public class BrandVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string InitialName { get; set; }
        public bool IsActive { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }
    }
}
