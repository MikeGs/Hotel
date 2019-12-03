namespace Dual_Hotel_EX3.View
{
    partial class AfegirReserva
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
            this.SeleccionaHoste = new System.Windows.Forms.ComboBox();
            this.DataInici = new System.Windows.Forms.TextBox();
            this.DataFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Serveis = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ConfirmaReserva = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SeleccionaPensio = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Serveis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Afegeix una reserva";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SeleccionaHoste
            // 
            this.SeleccionaHoste.FormattingEnabled = true;
            this.SeleccionaHoste.Location = new System.Drawing.Point(60, 70);
            this.SeleccionaHoste.Name = "SeleccionaHoste";
            this.SeleccionaHoste.Size = new System.Drawing.Size(184, 21);
            this.SeleccionaHoste.TabIndex = 1;
            this.SeleccionaHoste.SelectedIndexChanged += new System.EventHandler(this.SeleccionaHoste_SelectedIndexChanged);
            // 
            // DataInici
            // 
            this.DataInici.Location = new System.Drawing.Point(60, 328);
            this.DataInici.Name = "DataInici";
            this.DataInici.Size = new System.Drawing.Size(184, 20);
            this.DataInici.TabIndex = 3;
            this.DataInici.TextChanged += new System.EventHandler(this.DataInici_TextChanged);
            // 
            // DataFinal
            // 
            this.DataFinal.Location = new System.Drawing.Point(60, 374);
            this.DataFinal.Name = "DataFinal";
            this.DataFinal.Size = new System.Drawing.Size(184, 20);
            this.DataFinal.TabIndex = 4;
            this.DataFinal.TextChanged += new System.EventHandler(this.DataFinal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hoste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Serveis Extra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Inici";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Import Reserva";
            // 
            // Serveis
            // 
            this.Serveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Serveis.Location = new System.Drawing.Point(60, 165);
            this.Serveis.Name = "Serveis";
            this.Serveis.Size = new System.Drawing.Size(184, 143);
            this.Serveis.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(280, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(110, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(280, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(110, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Import Base ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "IVA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Import Total";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ConfirmaReserva
            // 
            this.ConfirmaReserva.Location = new System.Drawing.Point(283, 372);
            this.ConfirmaReserva.Name = "ConfirmaReserva";
            this.ConfirmaReserva.Size = new System.Drawing.Size(163, 22);
            this.ConfirmaReserva.TabIndex = 17;
            this.ConfirmaReserva.Text = "Confirma Reserva";
            this.ConfirmaReserva.UseVisualStyleBackColor = true;
            this.ConfirmaReserva.Click += new System.EventHandler(this.ConfirmaReserva_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(283, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "ERROR EN LES DADES";
            // 
            // SeleccionaPensio
            // 
            this.SeleccionaPensio.FormattingEnabled = true;
            this.SeleccionaPensio.Location = new System.Drawing.Point(60, 121);
            this.SeleccionaPensio.Name = "SeleccionaPensio";
            this.SeleccionaPensio.Size = new System.Drawing.Size(184, 21);
            this.SeleccionaPensio.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tipus de pensio";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // AfegirReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 421);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SeleccionaPensio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ConfirmaReserva);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Serveis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataFinal);
            this.Controls.Add(this.DataInici);
            this.Controls.Add(this.SeleccionaHoste);
            this.Controls.Add(this.label1);
            this.Name = "AfegirReserva";
            this.Text = "AfegirReserva";
            this.Load += new System.EventHandler(this.AfegirReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Serveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SeleccionaHoste;
        private System.Windows.Forms.TextBox DataInici;
        private System.Windows.Forms.TextBox DataFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Serveis;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ConfirmaReserva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox SeleccionaPensio;
        private System.Windows.Forms.Label label11;
    }
}