﻿using API_EfCore.Domains;
using Microsoft.EntityFrameworkCore;


namespace API_EfCore.Context
{
    public class PedidoContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<PedidoItem> PedidosItens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source =.\SqlExpress; Initial Catalog=Db_Senai_Pedidos_Tarde_Dev; user id=sa; password=sa132");

            base.OnConfiguring(optionsBuilder);
        }

    }
}
