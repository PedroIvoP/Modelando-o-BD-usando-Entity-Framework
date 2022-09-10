using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkEstudo
{
    public class DataContext : DbContext
    {
        //String de conexão com o Banco de dados
        public DataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial " +
            "Catalog=Estoque2;Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
            "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False") { }


        //Criar a tabela, baseado na classe 
        public DbSet<Produtos> Produtos { get; set; }

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Setores> Setores { get; set; } //Será acionada na classe FrmSetores


        //Sobrescreve o metodo, para que a tabela produto seja criada
        //baseada no que foi definido na classe de mapeamento (ProdutosMap, ClientesMap)
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutosMap());

            modelBuilder.Configurations.Add(new ClientesMap());

            modelBuilder.Configurations.Add(new SetoresMap());
        }

    }
}
