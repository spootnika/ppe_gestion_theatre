using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class PublicType
    {
        private int publicType_id;
        private string publicType_name;

        public int PublicType_id { get => publicType_id; set => publicType_id = value; }
        public string PublicType_name { get => publicType_name; set => publicType_name = value; }
    }
}
