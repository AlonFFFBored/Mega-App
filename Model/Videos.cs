using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Videos:BaseEntity
    {
        private string video_name;
        private string video_link;
        private Products product_id;

        public string Video_Name { get => video_name; set => video_name = value; }
        public string Video_Link { get => video_link; set => video_link = value; }
        public Products Product_Id { get => product_id; set => product_id = value; }
    }
}
