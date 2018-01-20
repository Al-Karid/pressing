namespace Pressing
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btnEtat = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnDepot = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.impUserControl1 = new Pressing.userControls.ImpUserControl();
            this.ajouterDepotUserControl1 = new Pressing.gestionUserControl();
            this.depotUserControl1 = new Pressing.depotUserControl();
            this.homeUserControl1 = new Pressing.homeUserControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btnEtat);
            this.panel1.Controls.Add(this.btnGestion);
            this.panel1.Controls.Add(this.btnDepot);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 475);
            this.panel1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DimGray;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = global::Pressing.Properties.Resources._012_power_64;
            this.btn_exit.Location = new System.Drawing.Point(0, 392);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(180, 83);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btnEtat
            // 
            this.btnEtat.AccessibleName = "btnEtat";
            this.btnEtat.BackColor = System.Drawing.Color.DimGray;
            this.btnEtat.FlatAppearance.BorderSize = 0;
            this.btnEtat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtat.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtat.ForeColor = System.Drawing.Color.Transparent;
            this.btnEtat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEtat.Location = new System.Drawing.Point(-3, 330);
            this.btnEtat.Name = "btnEtat";
            this.btnEtat.Size = new System.Drawing.Size(180, 50);
            this.btnEtat.TabIndex = 4;
            this.btnEtat.Text = "Etats";
            this.btnEtat.UseVisualStyleBackColor = false;
            this.btnEtat.Click += new System.EventHandler(this.btnEtat_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.BackColor = System.Drawing.Color.DimGray;
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.ForeColor = System.Drawing.Color.Transparent;
            this.btnGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestion.Location = new System.Drawing.Point(0, 274);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(180, 50);
            this.btnGestion.TabIndex = 4;
            this.btnGestion.Text = "Gestion";
            this.btnGestion.UseVisualStyleBackColor = false;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btnDepot
            // 
            this.btnDepot.BackColor = System.Drawing.Color.DimGray;
            this.btnDepot.FlatAppearance.BorderSize = 0;
            this.btnDepot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepot.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepot.ForeColor = System.Drawing.Color.Transparent;
            this.btnDepot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepot.Location = new System.Drawing.Point(0, 218);
            this.btnDepot.Name = "btnDepot";
            this.btnDepot.Size = new System.Drawing.Size(180, 50);
            this.btnDepot.TabIndex = 4;
            this.btnDepot.Text = "Depôts";
            this.btnDepot.UseVisualStyleBackColor = false;
            this.btnDepot.Click += new System.EventHandler(this.btnDepot_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DimGray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 162);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(180, 50);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Acceuil";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 166);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(57, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Central";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(42, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pressing";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pressing.Properties.Resources.Laundry_Services_64;
            this.pictureBox1.Location = new System.Drawing.Point(40, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // impUserControl1
            // 
            this.impUserControl1.Location = new System.Drawing.Point(180, 0);
            this.impUserControl1.Name = "impUserControl1";
            this.impUserControl1.Size = new System.Drawing.Size(739, 475);
            this.impUserControl1.TabIndex = 4;
            // 
            // ajouterDepotUserControl1
            // 
            this.ajouterDepotUserControl1.BackColor = System.Drawing.Color.RoyalBlue;
            this.ajouterDepotUserControl1.Location = new System.Drawing.Point(180, 0);
            this.ajouterDepotUserControl1.Name = "ajouterDepotUserControl1";
            this.ajouterDepotUserControl1.Size = new System.Drawing.Size(739, 475);
            this.ajouterDepotUserControl1.TabIndex = 3;
            // 
            // depotUserControl1
            // 
            this.depotUserControl1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.depotUserControl1.Location = new System.Drawing.Point(180, 0);
            this.depotUserControl1.Name = "depotUserControl1";
            this.depotUserControl1.Size = new System.Drawing.Size(739, 475);
            this.depotUserControl1.TabIndex = 2;
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.homeUserControl1.Location = new System.Drawing.Point(180, 0);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(739, 475);
            this.homeUserControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 475);
            this.Controls.Add(this.impUserControl1);
            this.Controls.Add(this.ajouterDepotUserControl1);
            this.Controls.Add(this.depotUserControl1);
            this.Controls.Add(this.homeUserControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceuil - Pressing Central";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnDepot;
        private System.Windows.Forms.Button btn_exit;
        private homeUserControl homeUserControl1;
        private depotUserControl depotUserControl1;
        private gestionUserControl ajouterDepotUserControl1;
        private System.Windows.Forms.Button btnEtat;
        private userControls.ImpUserControl impUserControl1;
    }
}