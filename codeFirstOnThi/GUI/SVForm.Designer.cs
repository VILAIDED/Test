
namespace codeFirstOnThi.GUI
{
    partial class SVForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picker_ns = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.radio_nam = new System.Windows.Forms.RadioButton();
            this.radio_nu = new System.Windows.Forms.RadioButton();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "HoTen :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lop :";
            // 
            // txt_mssv
            // 
            this.txt_mssv.Location = new System.Drawing.Point(100, 56);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(135, 22);
            this.txt_mssv.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(100, 112);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(135, 22);
            this.txt_name.TabIndex = 4;
            // 
            // cbb_lop
            // 
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Location = new System.Drawing.Point(100, 165);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(121, 24);
            this.cbb_lop.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "NS : ";
            // 
            // picker_ns
            // 
            this.picker_ns.Location = new System.Drawing.Point(480, 56);
            this.picker_ns.Name = "picker_ns";
            this.picker_ns.Size = new System.Drawing.Size(200, 22);
            this.picker_ns.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender : ";
            // 
            // radio_nam
            // 
            this.radio_nam.AutoSize = true;
            this.radio_nam.Location = new System.Drawing.Point(480, 161);
            this.radio_nam.Name = "radio_nam";
            this.radio_nam.Size = new System.Drawing.Size(58, 21);
            this.radio_nam.TabIndex = 9;
            this.radio_nam.TabStop = true;
            this.radio_nam.Text = "Nam";
            this.radio_nam.UseVisualStyleBackColor = true;
            this.radio_nam.CheckedChanged += new System.EventHandler(this.radio_nam_CheckedChanged);
            // 
            // radio_nu
            // 
            this.radio_nu.AutoSize = true;
            this.radio_nu.Location = new System.Drawing.Point(622, 161);
            this.radio_nu.Name = "radio_nu";
            this.radio_nu.Size = new System.Drawing.Size(47, 21);
            this.radio_nu.TabIndex = 10;
            this.radio_nu.TabStop = true;
            this.radio_nu.Text = "Nu";
            this.radio_nu.UseVisualStyleBackColor = true;
            this.radio_nu.CheckedChanged += new System.EventHandler(this.radio_nu_CheckedChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(276, 400);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(410, 400);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // SVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.radio_nu);
            this.Controls.Add(this.radio_nam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picker_ns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_lop);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_mssv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SVForm";
            this.Text = "SVForm";
            this.Load += new System.EventHandler(this.SVForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cbb_lop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker picker_ns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radio_nam;
        private System.Windows.Forms.RadioButton radio_nu;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}