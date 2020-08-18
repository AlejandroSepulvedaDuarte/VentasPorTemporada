namespace TemporadaPorVentas
{
    partial class Temp2
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
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.gbdescripcion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldescuento = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbdescripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temporada Halloween";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa el valor de la compra:";
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtvalor.ForeColor = System.Drawing.Color.Red;
            this.txtvalor.Location = new System.Drawing.Point(277, 61);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(188, 29);
            this.txtvalor.TabIndex = 3;
            this.txtvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_KeyPress);
            // 
            // btnmostrar
            // 
            this.btnmostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmostrar.ForeColor = System.Drawing.Color.White;
            this.btnmostrar.Location = new System.Drawing.Point(16, 120);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(157, 86);
            this.btnmostrar.TabIndex = 12;
            this.btnmostrar.Text = "Haz un Click Aqui para mostrar el valor a pagar";
            this.btnmostrar.UseVisualStyleBackColor = false;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // gbdescripcion
            // 
            this.gbdescripcion.Controls.Add(this.label3);
            this.gbdescripcion.Controls.Add(this.label4);
            this.gbdescripcion.Controls.Add(this.lbltotal);
            this.gbdescripcion.Controls.Add(this.label5);
            this.gbdescripcion.Controls.Add(this.lbldescuento);
            this.gbdescripcion.Controls.Add(this.lblsubtotal);
            this.gbdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbdescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbdescripcion.Location = new System.Drawing.Point(16, 239);
            this.gbdescripcion.Name = "gbdescripcion";
            this.gbdescripcion.Size = new System.Drawing.Size(546, 168);
            this.gbdescripcion.TabIndex = 15;
            this.gbdescripcion.TabStop = false;
            this.gbdescripcion.Text = "Descripción de pago";
            this.gbdescripcion.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subtotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descuento:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbltotal.Location = new System.Drawing.Point(131, 126);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(70, 24);
            this.lbltotal.TabIndex = 10;
            this.lbltotal.Text = "label10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total a pagar:";
            // 
            // lbldescuento
            // 
            this.lbldescuento.AutoSize = true;
            this.lbldescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbldescuento.ForeColor = System.Drawing.Color.Black;
            this.lbldescuento.Location = new System.Drawing.Point(131, 84);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(60, 24);
            this.lbldescuento.TabIndex = 9;
            this.lbldescuento.Text = "label9";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblsubtotal.ForeColor = System.Drawing.Color.Black;
            this.lblsubtotal.Location = new System.Drawing.Point(131, 40);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(60, 24);
            this.lblsubtotal.TabIndex = 8;
            this.lblsubtotal.Text = "label8";
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.White;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnborrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnborrar.Location = new System.Drawing.Point(203, 120);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(118, 86);
            this.btnborrar.TabIndex = 16;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnregresar.ForeColor = System.Drawing.Color.White;
            this.btnregresar.Location = new System.Drawing.Point(359, 122);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(203, 86);
            this.btnregresar.TabIndex = 17;
            this.btnregresar.Text = "\r\nClick Aquí para regresar a \r\n\"Ventas Por Temporada\"\r\n\r\n\r\n\r\n\r\n \r\n\r\n";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TemporadaPorVentas.Properties.Resources.png_clipart_costume_design_maleficent_fiction_outerwear_halloween_2017_child_fictional_character;
            this.pictureBox1.Location = new System.Drawing.Point(568, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Temp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.gbdescripcion);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Temp2";
            this.Text = "Temp2";
            this.gbdescripcion.ResumeLayout(false);
            this.gbdescripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.GroupBox gbdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldescuento;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}