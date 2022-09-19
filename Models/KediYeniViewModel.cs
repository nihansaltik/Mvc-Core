using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KediApp.Models
{
    public class KediYeniViewModel
    {
        public KediModel Kedi { get; set; }
        public List<CinsModel> cinsler { get; set; }
    }
}
