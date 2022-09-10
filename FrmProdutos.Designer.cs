namespace EntityFrameworkEstudo
{
    partial class FrmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AdicionarStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AlterarToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.VizualizarToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExcluirToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(765, 347);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdicionarStripButton1,
            this.toolStripSeparator1,
            this.AlterarToolStripButton1,
            this.toolStripSeparator2,
            this.VizualizarToolStripButton1,
            this.toolStripSeparator3,
            this.ExcluirToolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AdicionarStripButton1
            // 
            this.AdicionarStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AdicionarStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("AdicionarStripButton1.Image")));
            this.AdicionarStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AdicionarStripButton1.Name = "AdicionarStripButton1";
            this.AdicionarStripButton1.Size = new System.Drawing.Size(62, 22);
            this.AdicionarStripButton1.Text = "Adicionar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // AlterarToolStripButton1
            // 
            this.AlterarToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AlterarToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("AlterarToolStripButton1.Image")));
            this.AlterarToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlterarToolStripButton1.Name = "AlterarToolStripButton1";
            this.AlterarToolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.AlterarToolStripButton1.Text = "Alterar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // VizualizarToolStripButton1
            // 
            this.VizualizarToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.VizualizarToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("VizualizarToolStripButton1.Image")));
            this.VizualizarToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VizualizarToolStripButton1.Name = "VizualizarToolStripButton1";
            this.VizualizarToolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.VizualizarToolStripButton1.Text = "Vizualizar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ExcluirToolStripButton1
            // 
            this.ExcluirToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExcluirToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ExcluirToolStripButton1.Image")));
            this.ExcluirToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcluirToolStripButton1.Name = "ExcluirToolStripButton1";
            this.ExcluirToolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.ExcluirToolStripButton1.Text = "Excluir";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton AdicionarStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton AlterarToolStripButton1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton VizualizarToolStripButton1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton ExcluirToolStripButton1;
    }
}