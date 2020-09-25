
using EfCore.Domains;
using System;
using System.ComponentModel.DataAnnotations;

namespace API_EfCore.Domains
{
    public class Pedido : BaseDomains
    {
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
            
        
    }
}
