using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Banda : BaseModel
    {
        public string Name { get; set; }
        public string Genero { get; set; }
        public int NumMembers { get; set; }
        public int YearFundation { get; set; }
    }
}
