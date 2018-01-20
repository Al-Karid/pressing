namespace Pressing.client
{
    partial class Ajouter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter));
            this.txtNonCLient = new System.Windows.Forms.TextBox();
            this.txtPrenomClient = new System.Windows.Forms.TextBox();
            this.txtNumeroClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.clientTableAdapter1 = new Pressing.PressingDBDataSetTableAdapters.CLIENTTableAdapter();
            this.SuspendLayout();
            // 
            // txtNonCLient
            // 
            this.txtNonCLient.Location = new System.Drawing.Point(78, 89);
            this.txtNonCLient.Name = "txtNonCLient";
            this.txtNonCLient.Size = new System.Drawing.Size(162, 20);
            this.txtNonCLient.TabIndex = 0;
            // 
            // txtPrenomClient
            // 
            this.txtPrenomClient.Location = new System.Drawing.Point(78, 141);
            this.txtPrenomClient.Name = "txtPrenomClient";
            this.txtPrenomClient.Size = new System.Drawing.Size(162, 20);
            this.txtPrenomClient.TabIndex = 1;
            // 
            // txtNumeroClient
            // 
            this.txtNumeroClient.Location = new System.Drawing.Point(78, 193);
            this.txtNumeroClient.Name = "txtNumeroClient";
            this.txtNumeroClient.Size = new System.Drawing.Size(162, 20);
            this.txtNumeroClient.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Téléphone";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEnregistrer.Location = new System.Drawing.Point(164, 232);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 30);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(318, 320);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroClient);
            this.Controls.Add(this.txtPrenomClient);
            this.Controls.Add(this.txtNonCLient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ajouter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouveau client";
            this.Load += new System.EventHandler(this.Ajouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNonCLient;
        private System.Windows.Forms.TextBox txtPrenomClient;
        private System.Windows.Forms.TextBox txtNumeroClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnregistrer;
        private PressingDBDataSetTableAdapters.CLIENTTableAdapter clientTableAdapter1;
    }
}