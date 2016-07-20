namespace WindowsFormsApplication9F
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database9DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database9DataSet1 = new WindowsFormsApplication9F.Database9DataSet1();
            this.database9DataSet = new WindowsFormsApplication9F.Database9DataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new WindowsFormsApplication9F.Database9DataSetTableAdapters.TableTableAdapter();
            this.create = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.personTableAdapter = new WindowsFormsApplication9F.Database9DataSet1TableAdapters.PersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database9DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database9DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.database9DataSet1BindingSource;
            // 
            // database9DataSet1BindingSource
            // 
            this.database9DataSet1BindingSource.DataSource = this.database9DataSet1;
            this.database9DataSet1BindingSource.Position = 0;
            // 
            // database9DataSet1
            // 
            this.database9DataSet1.DataSetName = "Database9DataSet1";
            this.database9DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database9DataSet
            // 
            this.database9DataSet.DataSetName = "Database9DataSet";
            this.database9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database9DataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(38, 264);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 1;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(144, 263);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 23);
            this.read.TabIndex = 2;
            this.read.Text = "read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(38, 226);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 3;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(144, 226);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(100, 20);
            this.textFirstName.TabIndex = 4;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(250, 225);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(100, 20);
            this.textLastName.TabIndex = 5;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(356, 226);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 20);
            this.textAge.TabIndex = 6;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(250, 263);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 7;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.read);
            this.Controls.Add(this.create);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database9DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database9DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database9DataSet database9DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database9DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource database9DataSet1BindingSource;
        private Database9DataSet1 database9DataSet1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private Database9DataSet1TableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}

