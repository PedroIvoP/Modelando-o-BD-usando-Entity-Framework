using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkEstudo
{
    internal class ProdutosMap : EntityTypeConfiguration<Produtos>
    {
        public ProdutosMap()
        {
            //Definindo o nome da tabela
            ToTable("Produtos");

            //Definindo a chave primária (Sempre baseado no atributos da classe Produto)
            HasKey(x => x.Id);

            //Definindo as colunas da tabela (Sempre baseado no atributos da classe Produto)
            Property(x => x.Descricao).IsRequired().HasColumnType
                ("varchar").HasMaxLength(70);

            Property(x => x.Un).IsRequired().HasColumnType
                ("varchar").HasMaxLength(3);

            Property(x => x.Unitario).HasColumnType("decimal").HasPrecision(10, 2);

            Property(x => x.IdSetor).HasColumnType("int");

        }
    }
}
