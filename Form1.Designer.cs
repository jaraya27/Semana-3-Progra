namespace WinForms_Semana_3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtHola = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txthola2 = new System.Windows.Forms.TextBox();
            this.txthola3 = new System.Windows.Forms.TextBox();
            this.txthola4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txthola4);
            this.panel1.Controls.Add(this.txthola3);
            this.panel1.Controls.Add(this.txthola2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TxtHola);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 139);
            this.panel1.TabIndex = 0;
            //this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto:";
            // 
            // TxtHola
            // 
            this.TxtHola.Location = new System.Drawing.Point(54, 34);
            this.TxtHola.Name = "TxtHola";
            this.TxtHola.Size = new System.Drawing.Size(100, 20);
            this.TxtHola.TabIndex = 1;
            this.TxtHola.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(180, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txthola2
            // 
            this.txthola2.Location = new System.Drawing.Point(160, 34);
            this.txthola2.Name = "txthola2";
            this.txthola2.Size = new System.Drawing.Size(100, 20);
            this.txthola2.TabIndex = 3;
            // 
            // txthola3
            // 
            this.txthola3.Location = new System.Drawing.Point(54, 63);
            this.txthola3.Name = "txthola3";
            this.txthola3.Size = new System.Drawing.Size(100, 20);
            this.txthola3.TabIndex = 4;
            // 
            // txthola4
            // 
            this.txthola4.Location = new System.Drawing.Point(160, 63);
            this.txthola4.Name = "txthola4";
            this.txthola4.Size = new System.Drawing.Size(100, 20);
            this.txthola4.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 141);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtHola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txthola2;
        private System.Windows.Forms.TextBox txthola3;
        private System.Windows.Forms.TextBox txthola4;
    }
}

