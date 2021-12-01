using System;
using System.Collections.Generic;
using System.Text;

namespace LoveFinder.Models
{
    internal class Swipe
    {
        public int ID { get; set; }
        public int FirstUser_ID { get; set; }
        public int SecondUser_ID { get; set; }
        public User FirstUser { get; set; }
        public User SecondtUser { get; set; }
    }
}
