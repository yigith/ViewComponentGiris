using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponentGiris.Models
{
    public class Database
    {
        public List<string> GetCategories()
        {
            return new List<string>
            {
                "Giyim" , "Yiyecek", "Spor"
            };
        }
    }
}
