namespace Pressing.client
{
    partial class Liste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liste));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientBS = new System.Windows.Forms.BindingSource(this.components);
            this.pressingDBDataSet = new Pressing.PressingDBDataSet();
            this.clientTA = new Pressing.PressingDBDataSetTableAdapters.CLIENTTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressingDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.pRENONDataGridViewTextBoxColumn,
            this.tELEPHONEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBS;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(448, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // clientBS
            // 
            this.clientBS.DataMember = "CLIENT";
            this.clientBS.DataSource = this.pressingDBDataSet;
            // 
            // pressingDBDataSet
            // 
            this.pressingDBDataSet.DataSetName = "PressingDBDataSet";
            this.pressingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTA
            // 
            this.clientTA.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMDataGridViewTextBoxColumn
            // 
            this.nOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
            this.nOMDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
            this.nOMDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pRENONDataGridViewTextBoxColumn
            // 
            this.pRENONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pRENONDataGridViewTextBoxColumn.DataPropertyName = "PRENON";
            this.pRENONDataGridViewTextBoxColumn.HeaderText = "PRENON";
            this.pRENONDataGridViewTextBoxColumn.Name = "pRENONDataGridViewTextBoxColumn";
            this.pRENONDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRENONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tELEPHONEDataGridViewTextBoxColumn
            // 
            this.tELEPHONEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tELEPHONEDataGridViewTextBoxColumn.DataPropertyName = "TELEPHONE";
            this.tELEPHONEDataGridViewTextBoxColumn.HeaderText = "TELEPHONE";
            this.tELEPHONEDataGridViewTextBoxColumn.Name = "tELEPHONEDataGridViewTextBoxColumn";
            this.tELEPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tELEPHONEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 399);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Liste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des clients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressingDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clientBS;
        private PressingDBDataSet pressingDBDataSet;
        private PressingDBDataSetTableAdapters.CLIENTTableAdapter clientTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEPHONEDataGridViewTextBoxColumn;
    }
}