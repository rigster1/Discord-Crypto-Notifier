using System;

namespace Data
{
    public class Alert
    {
        public decimal Price { get; set; }
        public Condition Condition { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}