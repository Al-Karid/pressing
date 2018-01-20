namespace Pressing
{
    partial class depotUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAjouterDepot = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.depotBS = new System.Windows.Forms.BindingSource(this.components);
            this.pressingDBDataSet = new Pressing.PressingDBDataSet();
            this.depotTA = new Pressing.PressingDBDataSetTableAdapters.DEPOTTableAdapter();
            this.tableAdapterManager = new Pressing.PressingDBDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouterVetAuDep = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDEPOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSERVICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDRAYON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTARIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTYPEVETEMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATERETRAITDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETIREDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pressingDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vetementTableAdapter1 = new Pressing.PressingDBDataSetTableAdapters.VETEMENTTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATERETRAITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rETIREDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depotBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressingDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressingDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouterDepot
            // 
            this.btnAjouterDepot.BackColor = System.Drawing.Color.Navy;
            this.btnAjouterDepot.FlatAppearance.BorderSize = 0;
            this.btnAjouterDepot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterDepot.Font = new System.Drawing.Font("Segoe Marker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterDepot.ForeColor = System.Drawing.Color.White;
            this.btnAjouterDepot.Location = new System.Drawing.Point(680, 6);
            this.btnAjouterDepot.Name = "btnAjouterDepot";
            this.btnAjouterDepot.Size = new System.Drawing.Size(52, 30);
            this.btnAjouterDepot.TabIndex = 1;
            this.btnAjouterDepot.Text = "Ajouter";
            this.btnAjouterDepot.UseVisualStyleBackColor = false;
            this.btnAjouterDepot.Click += new System.EventHandler(this.btnAjouterDepot_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.btnAjouterDepot);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 42);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des depôts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dATEDataGridViewTextBoxColumn,
            this.dATERETRAITDataGridViewTextBoxColumn,
            this.pAYEDataGridViewCheckBoxColumn,
            this.rETIREDataGridViewCheckBoxColumn,
            this.iDCLIENTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.depotBS;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(739, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // depotBS
            // 
            this.depotBS.DataMember = "DEPOT";
            this.depotBS.DataSource = this.pressingDBDataSet;
            // 
            // pressingDBDataSet
            // 
            this.pressingDBDataSet.DataSetName = "PressingDBDataSet";
            this.pressingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depotTA
            // 
            this.depotTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CFDTableAdapter = null;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DEPOTTableAdapter = null;
            this.tableAdapterManager.RAYONTableAdapter = null;
            this.tableAdapterManager.SERVICETableAdapter = null;
            this.tableAdapterManager.TARIFTableAdapter = null;
            this.tableAdapterManager.TYPEVETEMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pressing.PressingDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VETEMENTTableAdapter = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAjouterVetAuDep);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 211);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vêtements du dépôt";
            // 
            // btnAjouterVetAuDep
            // 
            this.btnAjouterVetAuDep.FlatAppearance.BorderSize = 0;
            this.btnAjouterVetAuDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterVetAuDep.ForeColor = System.Drawing.Color.White;
            this.btnAjouterVetAuDep.Location = new System.Drawing.Point(680, 19);
            this.btnAjouterVetAuDep.Name = "btnAjouterVetAuDep";
            this.btnAjouterVetAuDep.Size = new System.Drawing.Size(52, 30);
            this.btnAjouterVetAuDep.TabIndex = 1;
            this.btnAjouterVetAuDep.Text = "Ajouter";
            this.btnAjouterVetAuDep.UseVisualStyleBackColor = true;
            this.btnAjouterVetAuDep.Click += new System.EventHandler(this.btnAjouterVetAuDep_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.CODE,
            this.IDDEPOT,
            this.IDSERVICE,
            this.IDRAYON,
            this.IDTARIF,
            this.IDTYPEVETEMENT,
            this.dATERETRAITDataGridViewTextBoxColumn1,
            this.rETIREDataGridViewCheckBoxColumn1});
            this.dataGridView2.DataMember = "FK_VETEMENT_IDDEP";
            this.dataGridView2.DataSource = this.depotBS;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.Location = new System.Drawing.Point(0, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(739, 148);
            this.dataGridView2.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // CODE
            // 
            this.CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODE.DataPropertyName = "CODE";
            this.CODE.HeaderText = "CODE";
            this.CODE.Name = "CODE";
            // 
            // IDDEPOT
            // 
            this.IDDEPOT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDDEPOT.DataPropertyName = "IDDEPOT";
            this.IDDEPOT.HeaderText = "IDDEPOT";
            this.IDDEPOT.Name = "IDDEPOT";
            // 
            // IDSERVICE
            // 
            this.IDSERVICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDSERVICE.DataPropertyName = "IDSERVICE";
            this.IDSERVICE.HeaderText = "IDSERVICE";
            this.IDSERVICE.Name = "IDSERVICE";
            // 
            // IDRAYON
            // 
            this.IDRAYON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDRAYON.DataPropertyName = "IDRAYON";
            this.IDRAYON.HeaderText = "IDRAYON";
            this.IDRAYON.Name = "IDRAYON";
            // 
            // IDTARIF
            // 
            this.IDTARIF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDTARIF.DataPropertyName = "IDTARIF";
            this.IDTARIF.HeaderText = "IDTARIF";
            this.IDTARIF.Name = "IDTARIF";
            // 
            // IDTYPEVETEMENT
            // 
            this.IDTYPEVETEMENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDTYPEVETEMENT.DataPropertyName = "IDTYPEVETEMENT";
            this.IDTYPEVETEMENT.HeaderText = "IDTYPEVETEMENT";
            this.IDTYPEVETEMENT.Name = "IDTYPEVETEMENT";
            // 
            // dATERETRAITDataGridViewTextBoxColumn1
            // 
            this.dATERETRAITDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dATERETRAITDataGridViewTextBoxColumn1.DataPropertyName = "DATERETRAIT";
            this.dATERETRAITDataGridViewTextBoxColumn1.HeaderText = "DATERETRAIT";
            this.dATERETRAITDataGridViewTextBoxColumn1.Name = "dATERETRAITDataGridViewTextBoxColumn1";
            // 
            // rETIREDataGridViewCheckBoxColumn1
            // 
            this.rETIREDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rETIREDataGridViewCheckBoxColumn1.DataPropertyName = "RETIRE";
            this.rETIREDataGridViewCheckBoxColumn1.HeaderText = "RETIRE";
            this.rETIREDataGridViewCheckBoxColumn1.Name = "rETIREDataGridViewCheckBoxColumn1";
            // 
            // pressingDBDataSetBindingSource
            // 
            this.pressingDBDataSetBindingSource.DataSource = this.pressingDBDataSet;
            this.pressingDBDataSetBindingSource.Position = 0;
            // 
            // vetementTableAdapter1
            // 
            this.vetementTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            this.dATEDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            this.dATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATERETRAITDataGridViewTextBoxColumn
            // 
            this.dATERETRAITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dATERETRAITDataGridViewTextBoxColumn.DataPropertyName = "DATERETRAIT";
            this.dATERETRAITDataGridViewTextBoxColumn.HeaderText = "DATERETRAIT";
            this.dATERETRAITDataGridViewTextBoxColumn.Name = "dATERETRAITDataGridViewTextBoxColumn";
            this.dATERETRAITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAYEDataGridViewCheckBoxColumn
            // 
            this.pAYEDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pAYEDataGridViewCheckBoxColumn.DataPropertyName = "PAYE";
            this.pAYEDataGridViewCheckBoxColumn.HeaderText = "PAYE";
            this.pAYEDataGridViewCheckBoxColumn.Name = "pAYEDataGridViewCheckBoxColumn";
            this.pAYEDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // rETIREDataGridViewCheckBoxColumn
            // 
            this.rETIREDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rETIREDataGridViewCheckBoxColumn.DataPropertyName = "RETIRE";
            this.rETIREDataGridViewCheckBoxColumn.HeaderText = "RETIRE";
            this.rETIREDataGridViewCheckBoxColumn.Name = "rETIREDataGridViewCheckBoxColumn";
            this.rETIREDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // iDCLIENTDataGridViewTextBoxColumn
            // 
            this.iDCLIENTDataGridViewTextBoxColumn.DataPropertyName = "IDCLIENT";
            this.iDCLIENTDataGridViewTextBoxColumn.HeaderText = "IDCLIENT";
            this.iDCLIENTDataGridViewTextBoxColumn.Name = "iDCLIENTDataGridViewTextBoxColumn";
            this.iDCLIENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCLIENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // depotUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "depotUserControl";
            this.Size = new System.Drawing.Size(739, 475);
            this.Enter += new System.EventHandler(this.depotUserControl_Enter);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depotBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressingDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressingDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterDepot;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource depotBS;
        private PressingDBDataSet pressingDBDataSet;
        private PressingDBDataSetTableAdapters.DEPOTTableAdapter depotTA;
        //private PressingDBDataSetTableAdapters.DDataTableTableAdapter dDataTableTableAdapter;
        private PressingDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjouterVetAuDep;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource pressingDBDataSetBindingSource;
        private PressingDBDataSetTableAdapters.VETEMENTTableAdapter vetementTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDEPOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSERVICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRAYON;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTARIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTYPEVETEMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATERETRAITDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rETIREDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATERETRAITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pAYEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rETIREDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTDataGridViewTextBoxColumn;
    }
}
