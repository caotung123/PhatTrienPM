namespace QLThietBi.Presentation
{
    partial class GUI_PhanQuyen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.labelâ = new System.Windows.Forms.Label();
            this.dtgMangHinhChon = new System.Windows.Forms.DataGridView();
            this.dtgMangHinhKoChon = new System.Windows.Forms.DataGridView();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnALLPhai = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnALLTrai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMangHinhChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMangHinhKoChon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 65);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÂN QUYỀN";
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(298, 135);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(243, 33);
            this.cbbNhanVien.TabIndex = 15;
            this.cbbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbbNhanVien_SelectedIndexChanged);
            // 
            // labelâ
            // 
            this.labelâ.AutoSize = true;
            this.labelâ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelâ.Location = new System.Drawing.Point(83, 143);
            this.labelâ.Name = "labelâ";
            this.labelâ.Size = new System.Drawing.Size(150, 25);
            this.labelâ.TabIndex = 16;
            this.labelâ.Text = "Tên Nhân Viên:";
            // 
            // dtgMangHinhChon
            // 
            this.dtgMangHinhChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMangHinhChon.Location = new System.Drawing.Point(27, 45);
            this.dtgMangHinhChon.Name = "dtgMangHinhChon";
            this.dtgMangHinhChon.RowTemplate.Height = 24;
            this.dtgMangHinhChon.Size = new System.Drawing.Size(285, 375);
            this.dtgMangHinhChon.TabIndex = 17;
            // 
            // dtgMangHinhKoChon
            // 
            this.dtgMangHinhKoChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMangHinhKoChon.Location = new System.Drawing.Point(29, 54);
            this.dtgMangHinhKoChon.Name = "dtgMangHinhKoChon";
            this.dtgMangHinhKoChon.RowTemplate.Height = 24;
            this.dtgMangHinhKoChon.Size = new System.Drawing.Size(288, 375);
            this.dtgMangHinhKoChon.TabIndex = 17;
            // 
            // btnPhai
            // 
            this.btnPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhai.Location = new System.Drawing.Point(411, 322);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(106, 52);
            this.btnPhai.TabIndex = 19;
            this.btnPhai.Text = ">";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnALLPhai
            // 
            this.btnALLPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnALLPhai.Location = new System.Drawing.Point(411, 380);
            this.btnALLPhai.Name = "btnALLPhai";
            this.btnALLPhai.Size = new System.Drawing.Size(106, 52);
            this.btnALLPhai.TabIndex = 19;
            this.btnALLPhai.Text = ">>";
            this.btnALLPhai.UseVisualStyleBackColor = true;
            this.btnALLPhai.Click += new System.EventHandler(this.btnALLPhai_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrai.Location = new System.Drawing.Point(411, 438);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(106, 52);
            this.btnTrai.TabIndex = 19;
            this.btnTrai.Text = "<";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btnALLTrai
            // 
            this.btnALLTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnALLTrai.Location = new System.Drawing.Point(411, 505);
            this.btnALLTrai.Name = "btnALLTrai";
            this.btnALLTrai.Size = new System.Drawing.Size(106, 52);
            this.btnALLTrai.TabIndex = 19;
            this.btnALLTrai.Text = "<<";
            this.btnALLTrai.UseVisualStyleBackColor = true;
            this.btnALLTrai.Click += new System.EventHandler(this.btnALLTrai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgMangHinhKoChon);
            this.groupBox1.Location = new System.Drawing.Point(546, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 445);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Không Chọn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgMangHinhChon);
            this.groupBox2.Location = new System.Drawing.Point(36, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 445);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Chọn";
            // 
            // GUI_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(920, 722);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnALLTrai);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnALLPhai);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.labelâ);
            this.Controls.Add(this.cbbNhanVien);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_PhanQuyen";
            this.Text = "GUI_PhanQuyen";
            this.Load += new System.EventHandler(this.GUI_PhanQuyen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMangHinhChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMangHinhKoChon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbNhanVien;
        private System.Windows.Forms.Label labelâ;
        private System.Windows.Forms.DataGridView dtgMangHinhChon;
        private System.Windows.Forms.DataGridView dtgMangHinhKoChon;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnALLPhai;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Button btnALLTrai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}