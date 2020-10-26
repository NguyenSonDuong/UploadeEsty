using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uploadetsy.MyObj
{
    class ObjList
    {

        public ObjList() { }

        public ObjList(string sku, string title, string section, string tag, string id, string link1, string link2, string link3, string link4, string link5)
        {
            SKU = sku.Trim(); 
            Title = title.Trim();

            Tag = tag.Trim();
            ID_Clone = id.Trim();
            Section = section.Trim();
            Link1 = link1.Trim();
            Link2 = link2.Trim();
            Link3 = link3.Trim();

            Link4 = link4.Trim();
            Link5 = link5.Trim();
        }


        public String SKU { get; set; }
        public String Title { get; set; }

        public String Section { get; set; }

        public String Tag { get; set; }

        public String ID_Clone { get; set; }

        public String Link1 { get; set; }

        public String Link2 { get; set; }

        public String Link3 { get; set; }

        public String Link4 { get; set; }

        public String Link5 { get; set; }
    }
}
