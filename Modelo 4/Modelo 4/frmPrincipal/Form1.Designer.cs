
namespace frmPrincipal
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lblElectrodomesticos = new System.Windows.Forms.Label();
            this.lblOferta = new System.Windows.Forms.Label();
            this.rtb_catalogo = new System.Windows.Forms.RichTextBox();
            this.rchOferta = new System.Windows.Forms.RichTextBox();
            this.btnNuevaOferta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(283, 27);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(266, 30);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Electrodomesticos Peposo";
            // 
            // lblElectrodomesticos
            // 
            this.lblElectrodomesticos.AutoSize = true;
            this.lblElectrodomesticos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblElectrodomesticos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblElectrodomesticos.Location = new System.Drawing.Point(151, 71);
            this.lblElectrodomesticos.Name = "lblElectrodomesticos";
            this.lblElectrodomesticos.Size = new System.Drawing.Size(92, 28);
            this.lblElectrodomesticos.TabIndex = 1;
            this.lblElectrodomesticos.Text = "Catalogo";
            // 
            // lblOferta
            // 
            this.lblOferta.AutoSize = true;
            this.lblOferta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOferta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOferta.Location = new System.Drawing.Point(511, 74);
            this.lblOferta.Name = "lblOferta";
            this.lblOferta.Size = new System.Drawing.Size(181, 25);
            this.lblOferta.TabIndex = 2;
            this.lblOferta.Text = "Oferta de la semana";
            // 
            // rtb_catalogo
            // 
            this.rtb_catalogo.Location = new System.Drawing.Point(36, 114);
            this.rtb_catalogo.Name = "rtb_catalogo";
            this.rtb_catalogo.Size = new System.Drawing.Size(320, 324);
            this.rtb_catalogo.TabIndex = 3;
            this.rtb_catalogo.Text = "";
            // 
            // rchOferta
            // 
            this.rchOferta.Location = new System.Drawing.Point(462, 114);
            this.rchOferta.Name = "rchOferta";
            this.rchOferta.Size = new System.Drawing.Size(260, 174);
            this.rchOferta.TabIndex = 4;
            this.rchOferta.Text = "";
            // 
            // btnNuevaOferta
            // 
            this.btnNuevaOferta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNuevaOferta.Location = new System.Drawing.Point(536, 352);
            this.btnNuevaOferta.Name = "btnNuevaOferta";
            this.btnNuevaOferta.Size = new System.Drawing.Size(121, 29);
            this.btnNuevaOferta.TabIndex = 5;
            this.btnNuevaOferta.Text = "Nueva Oferta";
            this.btnNuevaOferta.UseVisualStyleBackColor = true;
            this.btnNuevaOferta.Click += new System.EventHandler(this.btnNuevaOferta_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevaOferta);
            this.Controls.Add(this.rchOferta);
            this.Controls.Add(this.rtb_catalogo);
            this.Controls.Add(this.lblOferta);
            this.Controls.Add(this.lblElectrodomesticos);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suetta.Valentin";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lblElectrodomesticos;
        private System.Windows.Forms.Label lblOferta;
        private System.Windows.Forms.RichTextBox rtb_catalogo;
        private System.Windows.Forms.RichTextBox rchOferta;
        private System.Windows.Forms.Button btnNuevaOferta;
    }
}

