1º Criar o objeto que será utilizado para criar as tabelas no BD (Produtos)

2º Criar a classe de mapeamento da classe criada anterior, na qual vai definir os tipos de valores no BD, 
por exemplo, varchar. E importando a super classe EntityTypeConfiguration<Produtos> (ProdutosMap)

2º Criar a classe DataContext (onde será colocada a string de conexão do BD) e referenciar com a super classe DbContext

3º Abrir o Packager Manager Console, e inserir os comandos: 

 - "enable-migrations" (para habilitar as migrações) (Só é necessário na primeira migração)
 - "add-migration estoque01" (para fazer a migração)
 - "update-database" (para atualizar o banco de dados) 
