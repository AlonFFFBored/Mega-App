using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Categories:BaseEntity
    {
        private string category;

        public string Category { get => category; set => category = value; }

        public override string ToString()
        {
            return base.ToString() + $" Category: {category}";
        }
    }
}
