﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FA23_Convocation2023_API.Models
{
    public partial class Session
    {
        public Session()
        {
            Bachelors = new HashSet<Bachelor>();
            CheckIns = new HashSet<CheckIn>();
        }

        public int SessionId { get; set; }
        public int? Session1 { get; set; }

        public virtual ICollection<Bachelor> Bachelors { get; set; }
        public virtual ICollection<CheckIn> CheckIns { get; set; }
    }
}