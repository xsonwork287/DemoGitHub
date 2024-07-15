namespace QuanLiNhanSu
{
    partial class FormTimKiem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboTkQuequan = new ComboBox();
            cboTkDonvi = new ComboBox();
            cboTkHochamhocvi = new ComboBox();
            btn_TimKiemTheoData = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 21);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Theo quê quán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 66);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Theo đơn vị";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 108);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 2;
            label3.Text = "Theo học hàm/học vị";
            // 
            // cboTkQuequan
            // 
            cboTkQuequan.FormattingEnabled = true;
            cboTkQuequan.Items.AddRange(new object[] { "Nam Định", "Thái Bình", "Quảng Ninh", "Hải Dương", "Hà Nội" });
            cboTkQuequan.Location = new Point(223, 13);
            cboTkQuequan.Name = "cboTkQuequan";
            cboTkQuequan.Size = new Size(346, 28);
            cboTkQuequan.TabIndex = 4;
            cboTkQuequan.SelectedIndexChanged += cboTkQuequan_SelectedIndexChanged;
            // 
            // cboTkDonvi
            // 
            cboTkDonvi.FormattingEnabled = true;
            cboTkDonvi.Items.AddRange(new object[] { "Khoa công nghệ thông tin", "Khoa luật", "Khoa công trình" });
            cboTkDonvi.Location = new Point(223, 58);
            cboTkDonvi.Name = "cboTkDonvi";
            cboTkDonvi.Size = new Size(346, 28);
            cboTkDonvi.TabIndex = 5;
            // 
            // cboTkHochamhocvi
            // 
            cboTkHochamhocvi.FormattingEnabled = true;
            cboTkHochamhocvi.Items.AddRange(new object[] { "Giáo sư", "Tiến sĩ", "Thực tập", "Thạc sĩ" });
            cboTkHochamhocvi.Location = new Point(223, 100);
            cboTkHochamhocvi.Name = "cboTkHochamhocvi";
            cboTkHochamhocvi.Size = new Size(346, 28);
            cboTkHochamhocvi.TabIndex = 6;
            // 
            // btn_TimKiemTheoData
            // 
            btn_TimKiemTheoData.Location = new Point(296, 148);
            btn_TimKiemTheoData.Name = "btn_TimKiemTheoData";
            btn_TimKiemTheoData.Size = new Size(111, 53);
            btn_TimKiemTheoData.TabIndex = 7;
            btn_TimKiemTheoData.Text = "Tìm kiếm";
            btn_TimKiemTheoData.UseVisualStyleBackColor = true;
            btn_TimKiemTheoData.Click += btn_TimKiemTheoData_Click;
            // 
            // FormTimKiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 238);
            Controls.Add(btn_TimKiemTheoData);
            Controls.Add(cboTkHochamhocvi);
            Controls.Add(cboTkDonvi);
            Controls.Add(cboTkQuequan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTimKiem";
            Text = "FormTimKiem";
            Load += FormTimKiem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboTkQuequan;
        private ComboBox cboTkDonvi;
        private ComboBox cboTkHochamhocvi;
        private Button btn_TimKiemTheoData;
    }
}