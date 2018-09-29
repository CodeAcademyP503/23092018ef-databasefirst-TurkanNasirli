namespace Bank_databasefirst
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(184, 97);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(461, 26);
            this.txt_name.TabIndex = 1;
            // 
            // txt_sname
            // 
            this.txt_sname.Location = new System.Drawing.Point(184, 163);
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(461, 26);
            this.txt_sname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(184, 227);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(461, 26);
            this.txt_pass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Passport Number:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(261, 297);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(227, 74);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_pass;
        public System.Windows.Forms.TextBox txt_name;
    }
}

