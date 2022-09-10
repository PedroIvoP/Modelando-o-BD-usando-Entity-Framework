namespace EntityFrameworkEstudo
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSetores_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmSetores())
            {
                frm.ShowDialog();
            }

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            using(var frm = new FrmProdutos())
            {
                frm.ShowDialog();
            }
        }

    }
}