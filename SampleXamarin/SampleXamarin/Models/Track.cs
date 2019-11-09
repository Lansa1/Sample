using SampleXamarin.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleXamarin.Models
{
    public class Track : BaseNotify
    {


        public int Position { get; set; }
        public string Path { get; set; }
        public string Artist { get; set; }
        public string Name { get; set; }
    }
}
