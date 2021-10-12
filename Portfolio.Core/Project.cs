using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ProjectType Type { get; set; }
        //For the deatils page
        public string Discription { get; set; }
        public string Link { get; set; }
    }
}
