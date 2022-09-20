using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ReviewBug
    {
        public Bug Bug { get; set; }
        public string Text { get; set; }

        public ReviewBug(Bug bug, string text)
        {
            Bug = bug;
            Text = text;
        }
    }
}
