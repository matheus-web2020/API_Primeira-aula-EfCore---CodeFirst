﻿using EfCore.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_EfCore.Domains
{
    public class PedidoItem : BaseDomains
    {
        
        public Guid IdPedido { get; set; }
        [ForeignKey("IdPedido")]
        public Pedido Pedido { get; set; }

        public Guid IdProduto { get; set; }
        [ForeignKey("IdProduto")]

        public Produto Produto { get; set; }

        [Required]
        public int Quantidade { get; set; }
       


    }
}
