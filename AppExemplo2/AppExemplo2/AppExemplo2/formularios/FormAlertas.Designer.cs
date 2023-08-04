namespace AppExemplo2.formularios
{
    partial class FormAlertas
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
            this.BtnExemplo = new System.Windows.Forms.Button();
            this.BtnPergunta = new System.Windows.Forms.Button();
            this.BtnError = new System.Windows.Forms.Button();
            this.BtnAtencao = new System.Windows.Forms.Button();
            this.BtnInformacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnExemplo
            // 
            this.BtnExemplo.BackColor = System.Drawing.Color.SlateGray;
            this.BtnExemplo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExemplo.Location = new System.Drawing.Point(175, 279);
            this.BtnExemplo.Name = "BtnExemplo";
            this.BtnExemplo.Size = new System.Drawing.Size(216, 52);
            this.BtnExemplo.TabIndex = 4;
            this.BtnExemplo.Text = "Exemplo";
            this.BtnExemplo.UseVisualStyleBackColor = false;
            this.BtnExemplo.Click += new System.EventHandler(this.BtnExemplo_Click);
            // 
            // BtnPergunta
            // 
            this.BtnPergunta.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnPergunta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPergunta.Location = new System.Drawing.Point(175, 221);
            this.BtnPergunta.Name = "BtnPergunta";
            this.BtnPergunta.Size = new System.Drawing.Size(216, 52);
            this.BtnPergunta.TabIndex = 3;
            this.BtnPergunta.Text = "Pergunta";
            this.BtnPergunta.UseVisualStyleBackColor = false;
            this.BtnPergunta.Click += new System.EventHandler(this.BtnPergunta_Click);
            // 
            // BtnError
            // 
            this.BtnError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnError.Location = new System.Drawing.Point(175, 163);
            this.BtnError.Name = "BtnError";
            this.BtnError.Size = new System.Drawing.Size(216, 52);
            this.BtnError.TabIndex = 2;
            this.BtnError.Text = "Erro";
            this.BtnError.UseVisualStyleBackColor = false;
            this.BtnError.Click += new System.EventHandler(this.BtnError_Click);
            // 
            // BtnAtencao
            // 
            this.BtnAtencao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnAtencao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtencao.Location = new System.Drawing.Point(175, 105);
            this.BtnAtencao.Name = "BtnAtencao";
            this.BtnAtencao.Size = new System.Drawing.Size(216, 52);
            this.BtnAtencao.TabIndex = 1;
            this.BtnAtencao.Text = "Atenção";
            this.BtnAtencao.UseVisualStyleBackColor = false;
            this.BtnAtencao.Click += new System.EventHandler(this.BtnAtencao_Click);
            // 
            // BtnInformacao
            // 
            this.BtnInformacao.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnInformacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInformacao.Location = new System.Drawing.Point(175, 47);
            this.BtnInformacao.Name = "BtnInformacao";
            this.BtnInformacao.Size = new System.Drawing.Size(216, 52);
            this.BtnInformacao.TabIndex = 0;
            this.BtnInformacao.Text = "Informações";
            this.BtnInformacao.UseVisualStyleBackColor = false;
            this.BtnInformacao.Click += new System.EventHandler(this.BtnInformacao_Click);
            // 
            // FormAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.BtnExemplo);
            this.Controls.Add(this.BtnPergunta);
            this.Controls.Add(this.BtnError);
            this.Controls.Add(this.BtnAtencao);
            this.Controls.Add(this.BtnInformacao);
            this.Name = "FormAlertas";
            this.Text = "FormAlertas";
            this.Load += new System.EventHandler(this.FormAlertas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExemplo;
        private System.Windows.Forms.Button BtnPergunta;
        private System.Windows.Forms.Button BtnError;
        private System.Windows.Forms.Button BtnAtencao;
        private System.Windows.Forms.Button BtnInformacao;
    }
}