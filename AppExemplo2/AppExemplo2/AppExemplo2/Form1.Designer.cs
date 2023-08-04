namespace AppExemplo2
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAlerta = new System.Windows.Forms.Button();
            this.BtnExemploAlerta = new System.Windows.Forms.Button();
            this.BtnAlteracaodeRota = new System.Windows.Forms.Button();
            this.BtnComboBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu de Opções";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAlerta
            // 
            this.BtnAlerta.BackColor = System.Drawing.Color.Violet;
            this.BtnAlerta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlerta.Location = new System.Drawing.Point(85, 96);
            this.BtnAlerta.Name = "BtnAlerta";
            this.BtnAlerta.Size = new System.Drawing.Size(415, 36);
            this.BtnAlerta.TabIndex = 1;
            this.BtnAlerta.Text = "Alertas";
            this.BtnAlerta.UseVisualStyleBackColor = false;
            this.BtnAlerta.Click += new System.EventHandler(this.BtnAlerta_Click);
            // 
            // BtnExemploAlerta
            // 
            this.BtnExemploAlerta.BackColor = System.Drawing.Color.IndianRed;
            this.BtnExemploAlerta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExemploAlerta.Location = new System.Drawing.Point(85, 138);
            this.BtnExemploAlerta.Name = "BtnExemploAlerta";
            this.BtnExemploAlerta.Size = new System.Drawing.Size(415, 36);
            this.BtnExemploAlerta.TabIndex = 2;
            this.BtnExemploAlerta.Text = "Exemplos com Alertas";
            this.BtnExemploAlerta.UseVisualStyleBackColor = false;
            this.BtnExemploAlerta.Click += new System.EventHandler(this.BtnExemploAlerta_Click);
            // 
            // BtnAlteracaodeRota
            // 
            this.BtnAlteracaodeRota.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnAlteracaodeRota.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlteracaodeRota.Location = new System.Drawing.Point(85, 180);
            this.BtnAlteracaodeRota.Name = "BtnAlteracaodeRota";
            this.BtnAlteracaodeRota.Size = new System.Drawing.Size(415, 36);
            this.BtnAlteracaodeRota.TabIndex = 3;
            this.BtnAlteracaodeRota.Text = "Exemplo alteração de rotas";
            this.BtnAlteracaodeRota.UseVisualStyleBackColor = false;
            this.BtnAlteracaodeRota.Click += new System.EventHandler(this.BtnAlteracaodeRota_Click);
            // 
            // BtnComboBox
            // 
            this.BtnComboBox.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComboBox.Location = new System.Drawing.Point(85, 222);
            this.BtnComboBox.Name = "BtnComboBox";
            this.BtnComboBox.Size = new System.Drawing.Size(415, 36);
            this.BtnComboBox.TabIndex = 4;
            this.BtnComboBox.Text = "Exemplo com combobox";
            this.BtnComboBox.UseVisualStyleBackColor = false;
            this.BtnComboBox.Click += new System.EventHandler(this.BtnComboBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.BtnComboBox);
            this.Controls.Add(this.BtnAlteracaodeRota);
            this.Controls.Add(this.BtnExemploAlerta);
            this.Controls.Add(this.BtnAlerta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAlerta;
        private System.Windows.Forms.Button BtnExemploAlerta;
        private System.Windows.Forms.Button BtnAlteracaodeRota;
        private System.Windows.Forms.Button BtnComboBox;
    }
}

