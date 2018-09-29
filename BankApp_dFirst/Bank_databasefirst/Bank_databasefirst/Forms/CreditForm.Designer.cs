namespace Bank_databasefirst.Forms
{
    partial class CreditForm
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
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(131, 308);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(227, 74);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(211, 218);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(461, 26);
            this.txt_amount.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Disburs:";
            // 
            // txt_cname
            // 
            this.txt_cname.Location = new System.Drawing.Point(211, 88);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.ReadOnly = true;
            this.txt_cname.Size = new System.Drawing.Size(461, 26);
            this.txt_cname.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(448, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(445, 308);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(227, 74);
            this.btn_show.TabIndex = 15;
            this.btn_show.Text = "Show all";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cname);
            this.Controls.Add(this.label1);
            this.Name = "CreditForm";
            this.Text = "CreditForm";
            this.Load += new System.EventHandler(this.CreditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_show;
        public System.Windows.Forms.TextBox txt_cname;
    }
}