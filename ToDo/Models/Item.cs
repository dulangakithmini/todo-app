﻿using System;

namespace ToDo.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Due { get; set; }

        // public bool isActive { get; set; }
    }
}