﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class CookType
    {
        public int CookTypeId { get; set; }
        public string Title { get; set; }
    }
}
