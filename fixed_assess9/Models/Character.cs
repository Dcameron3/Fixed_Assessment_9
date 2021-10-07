using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fixed_assess9.Models
{
    public class Character { 

        
            public string name { get; set; }
            public string gender { get; set; }
            public List<string> playedBy { get; set; }
            

            
      
        
    }
    public class ListOfCharacters
    {
        public List<Character> characters { get; set; }
    }
    

}

