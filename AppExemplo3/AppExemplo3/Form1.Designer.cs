namespace AppExemplo3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btExemploListBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btExemploGrid = new System.Windows.Forms.Button();
            this.btExemploCadastrarList = new System.Windows.Forms.Button();
            this.btExemploListarList = new System.Windows.Forms.Button();
            this.btExemploListarGrid = new System.Windows.Forms.Button();
            this.btExemploCadastrarTabela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btExemploListBox
            // 
            this.btExemploListBox.BackColor = System.Drawing.Color.YellowGreen;
            this.btExemploListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemploListBox.Location = new System.Drawing.Point(125, 90);
            this.btExemploListBox.Name = "btExemploListBox";
            this.btExemploListBox.Size = new System.Drawing.Size(543, 54);
            this.btExemploListBox.TabIndex = 0;
            this.btExemploListBox.Text = "EXEMPLO COM LIST BOX";
            this.btExemploListBox.UseVisualStyleBackColor = false;
            this.btExemploListBox.Click += new System.EventHandler(this.btExemploListBox_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORMULÁRIOS COM VETORES E VARIÁVEIS ESTÁTICAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btExemploGrid
            // 
            this.btExemploGrid.BackColor = System.Drawing.Color.Orange;
            this.btExemploGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemploGrid.Location = new System.Drawing.Point(125, 174);
            this.btExemploGrid.Name = "btExemploGrid";
            this.btExemploGrid.Size = new System.Drawing.Size(543, 54);
            this.btExemploGrid.TabIndex = 2;
            this.btExemploGrid.Text = "EXEMPLO COM GRID (TABELA)";
            this.btExemploGrid.UseVisualStyleBackColor = false;
            this.btExemploGrid.Click += new System.EventHandler(this.btExemploGrid_Click);
            // 
            // btExemploCadastrarList
            // 
            this.btExemploCadastrarList.BackColor = System.Drawing.Color.Gold;
            this.btExemploCadastrarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemploCadastrarList.Location = new System.Drawing.Point(125, 254);
            this.btExemploCadastrarList.Name = "btExemploCadastrarList";
            this.btExemploCadastrarList.Size = new System.Drawing.Size(543, 54);
            this.btExemploCadastrarList.TabIndex = 3;
            this.btExemploCadastrarList.Text = "CADASTRAR VEÍCULOS (VARIÁVEL ESTÁTICA)";
            this.btExemploCadastrarList.UseVisualStyleBackColor = false;
            this.btExemploCadastrarList.Click += new System.EventHandler(this.btExemploCadastrar_Click);
            // 
            // btExemploListarList
            // 
            this.btExemploListarList.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btExemploListarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemploListarList.Location = new System.Drawing.Point(125, 419);
            this.btExemploListarList.Name = "btExemploListarList";
            this.btExemploListarList.Size = new System.Drawing.Size(543, 54);
            this.btExemploListarList.TabIndex = 4;
            this.btExemploListarList.Text = "EXEMPLO LISTAR COM LIST BOX (VARIÁVEL ESTÁTICA)\r\n";
            this.btExemploListarList.UseVisualStyleBackColor = false;
            this.btExemploListarList.Click += new System.EventHandler(this.btExemploListarList_Click);
            // 
            // btExemploListarGrid
            // 
            this.btExemploListarGrid.BackColor = System.Drawing.Color.Coral;
            this.btExemploListarGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemploListarGrid.Location = new System.Drawing.Point(125, 507);
            this.btExemploListarGrid.Name = "btExemploListarGrid";
            this.btExemploListarGrid.Size = new System.Drawing.Size(543, 54);
            this.btExemploListarGrid.TabIndex = 5;
            this.btExemploListarGrid.Text = "EXEMPLO LISTAR  COM GRID (VARIÁVEL ESTÁTICA)\r\n";
            this.btExemploListarGrid.UseVisualStyleBackColor = false;
            this.btExemploListarGrid.Click += new System.EventHandler(this.btExemploListarGrid_Click);
            // 
            // btExemploCadastrarTabela
            // 
            this.btExemploCadastrarTabela.BackColor = System.Drawing.Color.DarkKhaki;
            this.btExemploCadastrarTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemploCadastrarTabela.Location = new System.Drawing.Point(125, 333);
            this.btExemploCadastrarTabela.Name = "btExemploCadastrarTabela";
            this.btExemploCadastrarTabela.Size = new System.Drawing.Size(543, 54);
            this.btExemploCadastrarTabela.TabIndex = 6;
            this.btExemploCadastrarTabela.Text = "CADASTRAR PRODUTOS (VARIÁVEL ESTÁTICA)";
            this.btExemploCadastrarTabela.UseVisualStyleBackColor = false;
            this.btExemploCadastrarTabela.Click += new System.EventHandler(this.btExemploCadastrarTabela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.btExemploCadastrarTabela);
            this.Controls.Add(this.btExemploListarGrid);
            this.Controls.Add(this.btExemploListarList);
            this.Controls.Add(this.btExemploCadastrarList);
            this.Controls.Add(this.btExemploGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExemploListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExemploListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExemploGrid;
        private System.Windows.Forms.Button btExemploCadastrarList;
        private System.Windows.Forms.Button btExemploListarList;
        private System.Windows.Forms.Button btExemploListarGrid;
        private System.Windows.Forms.Button btExemploCadastrarTabela;
    }
}

