namespace QLNV
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
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.textBoxMSSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.dateTimePickerNgVL = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgSinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.AllowUserToAddRows = false;
            this.dataGridViewNV.AllowUserToDeleteRows = false;
            this.dataGridViewNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewNV.Location = new System.Drawing.Point(0, 149);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.ReadOnly = true;
            this.dataGridViewNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNV.Size = new System.Drawing.Size(794, 413);
            this.dataGridViewNV.TabIndex = 0;
            this.dataGridViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNV_CellClick);
            // 
            // textBoxMSSV
            // 
            this.textBoxMSSV.BackColor = System.Drawing.Color.White;
            this.textBoxMSSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMSSV.Location = new System.Drawing.Point(59, 16);
            this.textBoxMSSV.Name = "textBoxMSSV";
            this.textBoxMSSV.ReadOnly = true;
            this.textBoxMSSV.Size = new System.Drawing.Size(211, 29);
            this.textBoxMSSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "MSNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.BackColor = System.Drawing.Color.White;
            this.textBoxHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTen.Location = new System.Drawing.Point(522, 16);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(211, 29);
            this.textBoxHoTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(536, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(536, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày vào làm";
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(357, 85);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(70, 34);
            this.buttonThem.TabIndex = 3;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(414, 29);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(70, 34);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(310, 29);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(70, 34);
            this.buttonSua.TabIndex = 3;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // dateTimePickerNgVL
            // 
            this.dateTimePickerNgVL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgVL.Location = new System.Drawing.Point(522, 104);
            this.dateTimePickerNgVL.Name = "dateTimePickerNgVL";
            this.dateTimePickerNgVL.Size = new System.Drawing.Size(211, 23);
            this.dateTimePickerNgVL.TabIndex = 14;
            // 
            // dateTimePickerNgSinh
            // 
            this.dateTimePickerNgSinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgSinh.Location = new System.Drawing.Point(59, 104);
            this.dateTimePickerNgSinh.Name = "dateTimePickerNgSinh";
            this.dateTimePickerNgSinh.Size = new System.Drawing.Size(211, 23);
            this.dateTimePickerNgSinh.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerNgVL);
            this.Controls.Add(this.dateTimePickerNgSinh);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMSSV);
            this.Controls.Add(this.dataGridViewNV);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.TextBox textBoxMSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgVL;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgSinh;
    }
}

