namespace AppConvert
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
            this.BtHectoAlqu = new System.Windows.Forms.Button();
            this.ConvertAlqToHEC = new System.Windows.Forms.Button();
            this.ConverMetrosToKm = new System.Windows.Forms.Button();
            this.ConvertKMtoMetros = new System.Windows.Forms.Button();
            this.ConvertHorasToMin = new System.Windows.Forms.Button();
            this.ConvertMinToHoras = new System.Windows.Forms.Button();
            this.ConvertHecToKm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(121, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtHectoAlqu
            // 
            this.BtHectoAlqu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtHectoAlqu.Location = new System.Drawing.Point(12, 95);
            this.BtHectoAlqu.Name = "BtHectoAlqu";
            this.BtHectoAlqu.Size = new System.Drawing.Size(213, 38);
            this.BtHectoAlqu.TabIndex = 1;
            this.BtHectoAlqu.Text = "Converter HEC para ALQ";
            this.BtHectoAlqu.UseVisualStyleBackColor = true;
            this.BtHectoAlqu.Click += new System.EventHandler(this.BtHectoAlqu_Click);
            // 
            // ConvertAlqToHEC
            // 
            this.ConvertAlqToHEC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertAlqToHEC.Location = new System.Drawing.Point(239, 95);
            this.ConvertAlqToHEC.Name = "ConvertAlqToHEC";
            this.ConvertAlqToHEC.Size = new System.Drawing.Size(213, 38);
            this.ConvertAlqToHEC.TabIndex = 2;
            this.ConvertAlqToHEC.Text = "Converter ALQ para HEC";
            this.ConvertAlqToHEC.UseVisualStyleBackColor = true;
            // 
            // ConverMetrosToKm
            // 
            this.ConverMetrosToKm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConverMetrosToKm.Location = new System.Drawing.Point(12, 163);
            this.ConverMetrosToKm.Name = "ConverMetrosToKm";
            this.ConverMetrosToKm.Size = new System.Drawing.Size(213, 38);
            this.ConverMetrosToKm.TabIndex = 3;
            this.ConverMetrosToKm.Text = "Converter M para KM";
            this.ConverMetrosToKm.UseVisualStyleBackColor = true;
            // 
            // ConvertKMtoMetros
            // 
            this.ConvertKMtoMetros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertKMtoMetros.Location = new System.Drawing.Point(239, 163);
            this.ConvertKMtoMetros.Name = "ConvertKMtoMetros";
            this.ConvertKMtoMetros.Size = new System.Drawing.Size(213, 38);
            this.ConvertKMtoMetros.TabIndex = 4;
            this.ConvertKMtoMetros.Text = "Converter KM para M";
            this.ConvertKMtoMetros.UseVisualStyleBackColor = true;
            // 
            // ConvertHorasToMin
            // 
            this.ConvertHorasToMin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertHorasToMin.Location = new System.Drawing.Point(12, 223);
            this.ConvertHorasToMin.Name = "ConvertHorasToMin";
            this.ConvertHorasToMin.Size = new System.Drawing.Size(213, 38);
            this.ConvertHorasToMin.TabIndex = 5;
            this.ConvertHorasToMin.Text = "Converter Horas para Min";
            this.ConvertHorasToMin.UseVisualStyleBackColor = true;
            // 
            // ConvertMinToHoras
            // 
            this.ConvertMinToHoras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertMinToHoras.Location = new System.Drawing.Point(239, 223);
            this.ConvertMinToHoras.Name = "ConvertMinToHoras";
            this.ConvertMinToHoras.Size = new System.Drawing.Size(213, 38);
            this.ConvertMinToHoras.TabIndex = 6;
            this.ConvertMinToHoras.Text = "Converter Min para Horas\r\n";
            this.ConvertMinToHoras.UseVisualStyleBackColor = true;
            // 
            // ConvertHecToKm
            // 
            this.ConvertHecToKm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertHecToKm.Location = new System.Drawing.Point(125, 281);
            this.ConvertHecToKm.Name = "ConvertHecToKm";
            this.ConvertHecToKm.Size = new System.Drawing.Size(213, 38);
            this.ConvertHecToKm.TabIndex = 7;
            this.ConvertHecToKm.Text = "Converter HEC para KM";
            this.ConvertHecToKm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 458);
            this.Controls.Add(this.ConvertHecToKm);
            this.Controls.Add(this.ConvertMinToHoras);
            this.Controls.Add(this.ConvertHorasToMin);
            this.Controls.Add(this.ConvertKMtoMetros);
            this.Controls.Add(this.ConverMetrosToKm);
            this.Controls.Add(this.ConvertAlqToHEC);
            this.Controls.Add(this.BtHectoAlqu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtHectoAlqu;
        private System.Windows.Forms.Button ConvertAlqToHEC;
        private System.Windows.Forms.Button ConverMetrosToKm;
        private System.Windows.Forms.Button ConvertKMtoMetros;
        private System.Windows.Forms.Button ConvertHorasToMin;
        private System.Windows.Forms.Button ConvertMinToHoras;
        private System.Windows.Forms.Button ConvertHecToKm;
    }
}

