namespace WindowsFormsApp1
{
    partial class CRUD
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnCustomerId = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.TextBox();
            this.Fullname = new System.Windows.Forms.Label();
            this.btnFullname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEdit1 = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnNew1 = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer ID";
            // 
            // btnCustomerId
            // 
            this.btnCustomerId.Location = new System.Drawing.Point(155, 22);
            this.btnCustomerId.Name = "btnCustomerId";
            this.btnCustomerId.Size = new System.Drawing.Size(100, 20);
            this.btnCustomerId.TabIndex = 1;
            this.btnCustomerId.TextChanged += new System.EventHandler(this.btnCustomerId_TextChanged);
            // 
            // btnEmail
            // 
            this.btnEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Email", true));
            this.btnEmail.Location = new System.Drawing.Point(155, 110);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(100, 20);
            this.btnEmail.TabIndex = 5;
            // 
            // Fullname
            // 
            this.Fullname.AutoSize = true;
            this.Fullname.Location = new System.Drawing.Point(48, 70);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(49, 13);
            this.Fullname.TabIndex = 2;
            this.Fullname.Text = "Fullname";
            // 
            // btnFullname
            // 
            this.btnFullname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Fullname", true));
            this.btnFullname.Location = new System.Drawing.Point(155, 67);
            this.btnFullname.Name = "btnFullname";
            this.btnFullname.Size = new System.Drawing.Size(100, 20);
            this.btnFullname.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnAddress
            // 
            this.btnAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.btnAddress.Location = new System.Drawing.Point(155, 154);
            this.btnAddress.Multiline = true;
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.btnAddress.Size = new System.Drawing.Size(564, 79);
            this.btnAddress.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Address";
            // 
            // btnEdit1
            // 
            this.btnEdit1.Location = new System.Drawing.Point(268, 317);
            this.btnEdit1.Name = "btnEdit1";
            this.btnEdit1.Size = new System.Drawing.Size(75, 23);
            this.btnEdit1.TabIndex = 8;
            this.btnEdit1.Text = "Edit";
            this.btnEdit1.UseVisualStyleBackColor = true;
            this.btnEdit1.Click += new System.EventHandler(this.btnEdit1_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(467, 317);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(75, 23);
            this.btnSave1.TabIndex = 9;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(367, 317);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 10;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnNew1
            // 
            this.btnNew1.Location = new System.Drawing.Point(165, 317);
            this.btnNew1.Name = "btnNew1";
            this.btnNew1.Size = new System.Drawing.Size(75, 23);
            this.btnNew1.TabIndex = 11;
            this.btnNew1.Text = "New";
            this.btnNew1.UseVisualStyleBackColor = true;
            this.btnNew1.Click += new System.EventHandler(this.btnNew1_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(WindowsFormsApp1.Customer);
            // 
            // CRUD
            // 
            this.ClientSize = new System.Drawing.Size(749, 416);
            this.Controls.Add(this.btnNew1);
            this.Controls.Add(this.btnCancel1);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.btnEdit1);
            this.Controls.Add(this.btnAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFullname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.Fullname);
            this.Controls.Add(this.btnCustomerId);
            this.Controls.Add(this.label5);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox btnCustomerId;
        private System.Windows.Forms.TextBox btnEmail;
        private System.Windows.Forms.Label Fullname;
        private System.Windows.Forms.TextBox btnFullname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox btnAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEdit1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnNew1;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}

