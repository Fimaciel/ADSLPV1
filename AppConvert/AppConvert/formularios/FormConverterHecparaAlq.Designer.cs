namespace AppConvert.formularios
{
    partial class FormConverterHecparaAlq
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHectoAlq = new System.Windows.Forms.TextBox();
            this.TxtAlqresult = new System.Windows.Forms.TextBox();
            this.BtnConverter = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a quantidade de Hectares:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado em Alqueiro:";
            // 
            // TxtHectoAlq
            // 
            this.TxtHectoAlq.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHectoAlq.Location = new System.Drawing.Point(30, 82);
            this.TxtHectoAlq.Name = "TxtHectoAlq";
            this.TxtHectoAlq.Size = new System.Drawing.Size(160, 26);
            this.TxtHectoAlq.TabIndex = 2;
            this.TxtHectoAlq.TextChanged += new System.EventHandler(this.TxtHectoAlq_TextChanged);
            // 
            // TxtAlqresult
            // 
            this.TxtAlqresult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAlqresult.Location = new System.Drawing.Point(30, 163);
            this.TxtAlqresult.Name = "TxtAlqresult";
            this.TxtAlqresult.Size = new System.Drawing.Size(160, 26);
            this.TxtAlqresult.TabIndex = 3;
            this.TxtAlqresult.TextChanged += new System.EventHandler(this.TxtAlqresult_TextChanged);
            // 
            // BtnConverter
            // 
            this.BtnConverter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConverter.Location = new System.Drawing.Point(30, 227);
            this.BtnConverter.Name = "BtnConverter";
            this.BtnConverter.Size = new System.Drawing.Size(99, 32);
            this.BtnConverter.TabIndex = 4;
            this.BtnConverter.Text = "Converter";
            this.BtnConverter.UseVisualStyleBackColor = true;
            this.BtnConverter.Click += new System.EventHandler(this.BtnConverter_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(154, 227);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 32);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FormConverterHecparaAlq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 349);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnConverter);
            this.Controls.Add(this.TxtAlqresult);
            this.Controls.Add(this.TxtHectoAlq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConverterHecparaAlq";
            this.Text = "FormConverterHecparaAlq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHectoAlq;
        private System.Windows.Forms.TextBox TxtAlqresult;
        private System.Windows.Forms.Button BtnConverter;
        private System.Windows.Forms.Button BtnCancelar;
    }
}