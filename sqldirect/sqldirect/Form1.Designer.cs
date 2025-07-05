namespace sqldirect
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editempID = new System.Windows.Forms.TextBox();
            this.editfname = new System.Windows.Forms.TextBox();
            this.editlname = new System.Windows.Forms.TextBox();
            this.editemail = new System.Windows.Forms.TextBox();
            this.editsalary = new System.Windows.Forms.TextBox();
            this.ediID = new System.Windows.Forms.Label();
            this.editf = new System.Windows.Forms.Label();
            this.editl = new System.Windows.Forms.Label();
            this.edite = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnload = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // editempID
            // 
            this.editempID.Location = new System.Drawing.Point(164, 243);
            this.editempID.Name = "editempID";
            this.editempID.Size = new System.Drawing.Size(344, 20);
            this.editempID.TabIndex = 1;
            // 
            // editfname
            // 
            this.editfname.Location = new System.Drawing.Point(164, 278);
            this.editfname.Name = "editfname";
            this.editfname.Size = new System.Drawing.Size(344, 20);
            this.editfname.TabIndex = 2;
            // 
            // editlname
            // 
            this.editlname.Location = new System.Drawing.Point(164, 313);
            this.editlname.Name = "editlname";
            this.editlname.Size = new System.Drawing.Size(344, 20);
            this.editlname.TabIndex = 3;
            // 
            // editemail
            // 
            this.editemail.Location = new System.Drawing.Point(164, 349);
            this.editemail.Name = "editemail";
            this.editemail.Size = new System.Drawing.Size(344, 20);
            this.editemail.TabIndex = 4;
            // 
            // editsalary
            // 
            this.editsalary.Location = new System.Drawing.Point(164, 384);
            this.editsalary.Name = "editsalary";
            this.editsalary.Size = new System.Drawing.Size(344, 20);
            this.editsalary.TabIndex = 5;
            // 
            // ediID
            // 
            this.ediID.AutoSize = true;
            this.ediID.Location = new System.Drawing.Point(70, 250);
            this.ediID.Name = "ediID";
            this.ediID.Size = new System.Drawing.Size(18, 13);
            this.ediID.TabIndex = 6;
            this.ediID.Text = "ID";
            // 
            // editf
            // 
            this.editf.AutoSize = true;
            this.editf.Location = new System.Drawing.Point(70, 281);
            this.editf.Name = "editf";
            this.editf.Size = new System.Drawing.Size(57, 13);
            this.editf.TabIndex = 7;
            this.editf.Text = "First Name";
            // 
            // editl
            // 
            this.editl.AutoSize = true;
            this.editl.Location = new System.Drawing.Point(70, 320);
            this.editl.Name = "editl";
            this.editl.Size = new System.Drawing.Size(58, 13);
            this.editl.TabIndex = 8;
            this.editl.Text = "Last Name";
            // 
            // edite
            // 
            this.edite.AutoSize = true;
            this.edite.Location = new System.Drawing.Point(70, 356);
            this.edite.Name = "edite";
            this.edite.Size = new System.Drawing.Size(32, 13);
            this.edite.TabIndex = 9;
            this.edite.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salary";
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(572, 240);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 23);
            this.btnload.TabIndex = 11;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(572, 274);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 12;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(572, 309);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(572, 346);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(572, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 489);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edite);
            this.Controls.Add(this.editl);
            this.Controls.Add(this.editf);
            this.Controls.Add(this.ediID);
            this.Controls.Add(this.editsalary);
            this.Controls.Add(this.editemail);
            this.Controls.Add(this.editlname);
            this.Controls.Add(this.editfname);
            this.Controls.Add(this.editempID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox editempID;
        private System.Windows.Forms.TextBox editfname;
        private System.Windows.Forms.TextBox editlname;
        private System.Windows.Forms.TextBox editemail;
        private System.Windows.Forms.TextBox editsalary;
        private System.Windows.Forms.Label ediID;
        private System.Windows.Forms.Label editf;
        private System.Windows.Forms.Label editl;
        private System.Windows.Forms.Label edite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnClear;
    }
}

