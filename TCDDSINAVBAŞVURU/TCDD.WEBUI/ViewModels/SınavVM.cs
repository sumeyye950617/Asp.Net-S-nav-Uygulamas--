using TCDD.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCDD.WEBUI.ViewModels
{
    public class SınavVM
    {
        public Sınav Sınav { get; set; }
         public IEnumerable<Nitelik>  Nitelik{ get; set; }
         public IEnumerable<Unvanlar>  Unvanlar{ get; set; }
      
       
    }
}
