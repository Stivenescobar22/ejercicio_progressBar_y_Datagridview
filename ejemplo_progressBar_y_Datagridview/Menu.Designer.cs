namespace ejemplo_progressBar_y_Datagridview
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblmenu = new System.Windows.Forms.Label();
            this.btndatagrid = new System.Windows.Forms.Button();
            this.btnusogroupbox = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmenu
            // 
            this.lblmenu.AutoSize = true;
            this.lblmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenu.Location = new System.Drawing.Point(142, 38);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(53, 20);
            this.lblmenu.TabIndex = 0;
            this.lblmenu.Text = "Menu";
            // 
            // btndatagrid
            // 
            this.btndatagrid.Location = new System.Drawing.Point(76, 92);
            this.btndatagrid.Name = "btndatagrid";
            this.btndatagrid.Size = new System.Drawing.Size(199, 49);
            this.btndatagrid.TabIndex = 1;
            this.btndatagrid.Text = "Uso de Datagridview";
            this.btndatagrid.UseVisualStyleBackColor = true;
            this.btndatagrid.Click += new System.EventHandler(this.btndatagrid_Click);
            // 
            // btnusogroupbox
            // 
            this.btnusogroupbox.Location = new System.Drawing.Point(76, 162);
            this.btnusogroupbox.Name = "btnusogroupbox";
            this.btnusogroupbox.Size = new System.Drawing.Size(199, 48);
            this.btnusogroupbox.TabIndex = 2;
            this.btnusogroupbox.Text = "Uso de GroupBox";
            this.btnusogroupbox.UseVisualStyleBackColor = true;
            this.btnusogroupbox.Click += new System.EventHandler(this.btnusogroupbox_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(127, 225);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(79, 44);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 298);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnusogroupbox);
            this.Controls.Add(this.btndatagrid);
            this.Controls.Add(this.lblmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmenu;
        private System.Windows.Forms.Button btndatagrid;
        private System.Windows.Forms.Button btnusogroupbox;
        private System.Windows.Forms.Button btnsalir;
    }
}