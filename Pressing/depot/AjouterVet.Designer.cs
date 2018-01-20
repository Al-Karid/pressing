namespace Pressing.depot
{
    partial class AjouterVet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterVet));
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.ComboBox();
            this.txtRayon = new System.Windows.Forms.ComboBox();
            this.txtTarif = new System.Windows.Forms.ComboBox();
            this.txtTypeVet = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serviceTableAdapter1 = new Pressing.PressingDBDataSetTableAdapters.SERVICETableAdapter();
            this.pressingDBDataSet = new Pressing.PressingDBDataSet();
            this.sERVICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rayonTableAdapter1 = new Pressing.PressingDBDataSetTableAdapters.RAYONTableAdapter();
            this.rAYONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarifTableAdapter1 = new Pressing.PressingDBDataSetTableAdapters.TARIFTableAdapter();
            this.tARIFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typevetementTableAdapter1 = new Pressing.PressingDBDataSetTableAdapters.TYPEVETEMENTTableAdapter();
            this.tYPEVETEMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.vetementTableAdapter1 = new Pressing.PressingDBDataSetTableAdapters.VETEMENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pressingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAYONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tARIFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEVETEMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(60, 48);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(211, 20);
            this.txtCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Code";
            // 
            // txtService
            // 
            this.txtService.DataSource = this.sERVICEBindingSource;
            this.txtService.DisplayMember = "LIBELLE";
            this.txtService.FormattingEnabled = true;
            this.txtService.Location = new System.Drawing.Point(60, 95);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(211, 21);
            this.txtService.TabIndex = 6;
            this.txtService.ValueMember = "ID";
            // 
            // txtRayon
            // 
            this.txtRayon.DataSource = this.rAYONBindingSource;
            this.txtRayon.DisplayMember = "CODE";
            this.txtRayon.FormattingEnabled = true;
            this.txtRayon.Location = new System.Drawing.Point(60, 146);
            this.txtRayon.Name = "txtRayon";
            this.txtRayon.Size = new System.Drawing.Size(211, 21);
            this.txtRayon.TabIndex = 7;
            this.txtRayon.ValueMember = "ID";
            // 
            // txtTarif
            // 
            this.txtTarif.DataSource = this.tARIFBindingSource;
            this.txtTarif.DisplayMember = "MONTANT";
            this.txtTarif.FormattingEnabled = true;
            this.txtTarif.Location = new System.Drawing.Point(60, 240);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.Size = new System.Drawing.Size(211, 21);
            this.txtTarif.TabIndex = 8;
            this.txtTarif.ValueMember = "ID";
            // 
            // txtTypeVet
            // 
            this.txtTypeVet.DataSource = this.tYPEVETEMENTBindingSource;
            this.txtTypeVet.DisplayMember = "LIBELLE";
            this.txtTypeVet.FormattingEnabled = true;
            this.txtTypeVet.Location = new System.Drawing.Point(60, 196);
            this.txtTypeVet.Name = "txtTypeVet";
            this.txtTypeVet.Size = new System.Drawing.Size(211, 21);
            this.txtTypeVet.TabIndex = 9;
            this.txtTypeVet.ValueMember = "ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(196, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serviceTableAdapter1
            // 
            this.serviceTableAdapter1.ClearBeforeFill = true;
            // 
            // pressingDBDataSet
            // 
            this.pressingDBDataSet.DataSetName = "PressingDBDataSet";
            this.pressingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sERVICEBindingSource
            // 
            this.sERVICEBindingSource.DataMember = "SERVICE";
            this.sERVICEBindingSource.DataSource = this.pressingDBDataSet;
            // 
            // rayonTableAdapter1
            // 
            this.rayonTableAdapter1.ClearBeforeFill = true;
            // 
            // rAYONBindingSource
            // 
            this.rAYONBindingSource.DataMember = "RAYON";
            this.rAYONBindingSource.DataSource = this.pressingDBDataSet;
            // 
            // tarifTableAdapter1
            // 
            this.tarifTableAdapter1.ClearBeforeFill = true;
            // 
            // tARIFBindingSource
            // 
            this.tARIFBindingSource.DataMember = "TARIF";
            this.tARIFBindingSource.DataSource = this.pressingDBDataSet;
            // 
            // typevetementTableAdapter1
            // 
            this.typevetementTableAdapter1.ClearBeforeFill = true;
            // 
            // tYPEVETEMENTBindingSource
            // 
            this.tYPEVETEMENTBindingSource.DataMember = "TYPEVETEMENT";
            this.tYPEVETEMENTBindingSource.DataSource = this.pressingDBDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rayon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Type du vêtement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tarif";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(60, 287);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(0, 13);
            this.txtID.TabIndex = 15;
            // 
            // vetementTableAdapter1
            // 
            this.vetementTableAdapter1.ClearBeforeFill = true;
            // 
            // AjouterVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 338);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTypeVet);
            this.Controls.Add(this.txtTarif);
            this.Controls.Add(this.txtRayon);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AjouterVet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouveau un vêtement";
            this.Load += new System.EventHandler(this.AjouterVet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pressingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAYONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tARIFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEVETEMENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtService;
        private System.Windows.Forms.ComboBox txtRayon;
        private System.Windows.Forms.ComboBox txtTarif;
        private System.Windows.Forms.ComboBox txtTypeVet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource sERVICEBindingSource;
        private PressingDBDataSet pressingDBDataSet;
        private PressingDBDataSetTableAdapters.SERVICETableAdapter serviceTableAdapter1;
        private System.Windows.Forms.BindingSource rAYONBindingSource;
        private PressingDBDataSetTableAdapters.RAYONTableAdapter rayonTableAdapter1;
        private System.Windows.Forms.BindingSource tARIFBindingSource;
        private PressingDBDataSetTableAdapters.TARIFTableAdapter tarifTableAdapter1;
        private System.Windows.Forms.BindingSource tYPEVETEMENTBindingSource;
        private PressingDBDataSetTableAdapters.TYPEVETEMENTTableAdapter typevetementTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtID;
        private PressingDBDataSetTableAdapters.VETEMENTTableAdapter vetementTableAdapter1;
    }
}