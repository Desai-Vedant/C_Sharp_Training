﻿namespace MVCApp.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Cost { get; set; }
    }
}
