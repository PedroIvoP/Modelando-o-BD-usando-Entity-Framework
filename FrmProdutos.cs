using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkEstudo
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();

            using(var context = new DataContext())
            {
                //Instrução para pegar dados apenas da tabela produtos
               // dataGridView1.DataSource = (from produtos in context.Produtos select produtos).ToList();
            

                //Instrução para pegar dados da tabela produtos, para que venha os nomes
                //dos setores da tabela setores, através do IdSetor, coluna comum entre
                //ambas as tabelas

                var lista = from produtos in context.Produtos
                            join setores in context.Setores
                            on produtos.IdSetor equals setores.IdSetor
                            into produtosGrupo
                            from setores in produtosGrupo.DefaultIfEmpty()
                            select new {setores, produtos};

                //Criando a tabela no DataGridView
                ConfigurarGrade();

                //Alimenta a tabela no DataGridView
                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(item.produtos.Id, item.produtos.Descricao,
                        item.produtos.Un, item.produtos.Unitario.ToString("N2"), 
                        item.produtos.IdSetor, item.setores.Descricao);
                }

            }

            
        }

        private void ConfigurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);

            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns["id"].Width = 80;
            dataGridView1.Columns["id"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns.Add("descricao", "Descrição");
            dataGridView1.Columns["descricao"].Width = 250;

            dataGridView1.Columns.Add("un", "UN");
            dataGridView1.Columns["un"].Width = 50;
            dataGridView1.Columns["un"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["un"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns.Add("Unitario", "Unitário");
            dataGridView1.Columns["Unitario"].Width = 90;
            dataGridView1.Columns["Unitario"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Unitario"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Unitario"].DefaultCellStyle.Format = "N2";

            dataGridView1.Columns.Add("idSetor", "Id do Setor");
            dataGridView1.Columns["idSetor"].Width = 80;
            dataGridView1.Columns["idSetor"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["idSetor"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns.Add("descricaoSetor", "Descrição do Setor");
            dataGridView1.Columns["descricao"].Width = 250;
        }
    }
}
