using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Folder
{
    public class EmploBEL
    {
        public int IdE { get; set; }
        public string Name { get; set; }
        public DateTime Db { get; set; }
        public bool Gd { get; set; }
        public string Pb { get; set; }
        public string IdD { get; set; }
        public List<CustomBEL> Employee_0223 { get; set; }
    }
}
