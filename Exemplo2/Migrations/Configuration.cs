namespace Exemplo2.Migrations
{
    using Exemplo2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Exemplo2.Models.Exemplo2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Exemplo2.Models.Exemplo2Context context)
        {
            context.Products.AddOrUpdate(
                  p => p.Id,
                  new Product { Id = 1, nome = "produto 1", codigo = "COD1", descricao = "descri��o produto 1", preco = 10, url = "www.google.com/1" },
                  new Product { Id = 2, nome = "produto 2", codigo = "COD2", descricao = "descri��o produto 2", preco = 20, url = "www.google.com/2" },
                  new Product { Id = 3, nome = "produto 3", codigo = "COD3", descricao = "descri��o produto 3", preco = 30, url = "www.google.com/3" }
              );
        }
    }
}
