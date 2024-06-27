using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ.Models
{
    public class Reviews
    {
        public int ID_item { get; set; }
        public int ID_order { get; set; }
        public int ID_user { get; set; }
        public int taste_rating { get; set; }
        public string comment { get; set; }
        
    }
}
