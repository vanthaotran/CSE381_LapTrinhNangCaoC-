
namespace phepTinh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_so_a = new System.Windows.Forms.Label();
            this.lbl_so_b = new System.Windows.Forms.Label();
            this.lbl_tong = new System.Windows.Forms.Label();
            this.lbl_hieu = new System.Windows.Forms.Label();
            this.lbl_tich = new System.Windows.Forms.Label();
            this.lbl_thuong = new System.Windows.Forms.Label();
            this.txt_box_so_a = new System.Windows.Forms.TextBox();
            this.txt_box_so_b = new System.Windows.Forms.TextBox();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lbl_ketqua_tong = new System.Windows.Forms.Label();
            this.lbl_ketqua_hieu = new System.Windows.Forms.Label();
            this.lbl_ketqua_tich = new System.Windows.Forms.Label();
            this.lbl_ketqua_thuong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_so_a
            // 
            this.lbl_so_a.AutoSize = true;
            this.lbl_so_a.Location = new System.Drawing.Point(29, 48);
            this.lbl_so_a.Name = "lbl_so_a";
            this.lbl_so_a.Size = new System.Drawing.Size(32, 15);
            this.lbl_so_a.TabIndex = 0;
            this.lbl_so_a.Text = "Số a:";
            // 
            // lbl_so_b
            // 
            this.lbl_so_b.AutoSize = true;
            this.lbl_so_b.Location = new System.Drawing.Point(29, 94);
            this.lbl_so_b.Name = "lbl_so_b";
            this.lbl_so_b.Size = new System.Drawing.Size(33, 15);
            this.lbl_so_b.TabIndex = 1;
            this.lbl_so_b.Text = "Số b:";
            // 
            // lbl_tong
            // 
            this.lbl_tong.AutoSize = true;
            this.lbl_tong.Location = new System.Drawing.Point(29, 206);
            this.lbl_tong.Name = "lbl_tong";
            this.lbl_tong.Size = new System.Drawing.Size(34, 15);
            this.lbl_tong.TabIndex = 2;
            this.lbl_tong.Text = "Tổng";
            // 
            // lbl_hieu
            // 
            this.lbl_hieu.AutoSize = true;
            this.lbl_hieu.Location = new System.Drawing.Point(27, 245);
            this.lbl_hieu.Name = "lbl_hieu";
            this.lbl_hieu.Size = new System.Drawing.Size(32, 15);
            this.lbl_hieu.TabIndex = 3;
            this.lbl_hieu.Text = "Hiệu";
            // 
            // lbl_tich
            // 
            this.lbl_tich.AutoSize = true;
            this.lbl_tich.Location = new System.Drawing.Point(27, 287);
            this.lbl_tich.Name = "lbl_tich";
            this.lbl_tich.Size = new System.Drawing.Size(29, 15);
            this.lbl_tich.TabIndex = 4;
            this.lbl_tich.Text = "Tích";
            // 
            // lbl_thuong
            // 
            this.lbl_thuong.AutoSize = true;
            this.lbl_thuong.Location = new System.Drawing.Point(27, 324);
            this.lbl_thuong.Name = "lbl_thuong";
            this.lbl_thuong.Size = new System.Drawing.Size(48, 15);
            this.lbl_thuong.TabIndex = 5;
            this.lbl_thuong.Text = "Thương";
            // 
            // txt_box_so_a
            // 
            this.txt_box_so_a.Location = new System.Drawing.Point(85, 45);
            this.txt_box_so_a.Name = "txt_box_so_a";
            this.txt_box_so_a.Size = new System.Drawing.Size(224, 23);
            this.txt_box_so_a.TabIndex = 6;
            this.txt_box_so_a.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_box_so_b
            // 
            this.txt_box_so_b.Location = new System.Drawing.Point(85, 94);
            this.txt_box_so_b.Name = "txt_box_so_b";
            this.txt_box_so_b.Size = new System.Drawing.Size(224, 23);
            this.txt_box_so_b.TabIndex = 7;
            // 
            // btn_tinh
            // 
            this.btn_tinh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_tinh.Location = new System.Drawing.Point(400, 45);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(102, 73);
            this.btn_tinh.TabIndex = 8;
            this.btn_tinh.Text = "Tính";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_thoat.Location = new System.Drawing.Point(400, 224);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(102, 78);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lbl_ketqua_tong
            // 
            this.lbl_ketqua_tong.AutoSize = true;
            this.lbl_ketqua_tong.Location = new System.Drawing.Point(110, 206);
            this.lbl_ketqua_tong.Name = "lbl_ketqua_tong";
            this.lbl_ketqua_tong.Size = new System.Drawing.Size(32, 15);
            this.lbl_ketqua_tong.TabIndex = 10;
            this.lbl_ketqua_tong.Text = "tong";
            // 
            // lbl_ketqua_hieu
            // 
            this.lbl_ketqua_hieu.AutoSize = true;
            this.lbl_ketqua_hieu.Location = new System.Drawing.Point(110, 245);
            this.lbl_ketqua_hieu.Name = "lbl_ketqua_hieu";
            this.lbl_ketqua_hieu.Size = new System.Drawing.Size(30, 15);
            this.lbl_ketqua_hieu.TabIndex = 11;
            this.lbl_ketqua_hieu.Text = "hieu";
            // 
            // lbl_ketqua_tich
            // 
            this.lbl_ketqua_tich.AutoSize = true;
            this.lbl_ketqua_tich.Location = new System.Drawing.Point(110, 287);
            this.lbl_ketqua_tich.Name = "lbl_ketqua_tich";
            this.lbl_ketqua_tich.Size = new System.Drawing.Size(27, 15);
            this.lbl_ketqua_tich.TabIndex = 12;
            this.lbl_ketqua_tich.Text = "tich";
            // 
            // lbl_ketqua_thuong
            // 
            this.lbl_ketqua_thuong.AutoSize = true;
            this.lbl_ketqua_thuong.Location = new System.Drawing.Point(110, 324);
            this.lbl_ketqua_thuong.Name = "lbl_ketqua_thuong";
            this.lbl_ketqua_thuong.Size = new System.Drawing.Size(46, 15);
            this.lbl_ketqua_thuong.TabIndex = 13;
            this.lbl_ketqua_thuong.Text = "thuong";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_ketqua_thuong);
            this.Controls.Add(this.lbl_ketqua_tich);
            this.Controls.Add(this.lbl_ketqua_hieu);
            this.Controls.Add(this.lbl_ketqua_tong);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.txt_box_so_b);
            this.Controls.Add(this.txt_box_so_a);
            this.Controls.Add(this.lbl_thuong);
            this.Controls.Add(this.lbl_tich);
            this.Controls.Add(this.lbl_hieu);
            this.Controls.Add(this.lbl_tong);
            this.Controls.Add(this.lbl_so_b);
            this.Controls.Add(this.lbl_so_a);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cộng trừ nhân chia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_so_a;
        private System.Windows.Forms.Label lbl_so_b;
        private System.Windows.Forms.Label lbl_tong;
        private System.Windows.Forms.Label lbl_hieu;
        private System.Windows.Forms.Label lbl_tich;
        private System.Windows.Forms.Label lbl_thuong;
        private System.Windows.Forms.TextBox txt_box_so_a;
        private System.Windows.Forms.TextBox txt_box_so_b;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lbl_ketqua_tong;
        private System.Windows.Forms.Label lbl_ketqua_hieu;
        private System.Windows.Forms.Label lbl_ketqua_tich;
        private System.Windows.Forms.Label lbl_ketqua_thuong;
    }
}

