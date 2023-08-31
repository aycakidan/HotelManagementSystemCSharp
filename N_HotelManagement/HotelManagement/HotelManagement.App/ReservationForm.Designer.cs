namespace HotelManagement.App
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.residDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementSystemDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagementSystemDataSet1 = new HotelManagement.App.hotel_ManagementSystemDataSet1();
            this.guestReservationTableAdapter = new HotelManagement.App.hotel_ManagementSystemDataSet1TableAdapters.guestReservationTableAdapter();
            this.save_btn = new System.Windows.Forms.Button();
            this.in_lbl = new System.Windows.Forms.Label();
            this.out_lbl = new System.Windows.Forms.Label();
            this.in_tb = new System.Windows.Forms.TextBox();
            this.out_tb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestReservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementSystemDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementSystemDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.residDataGridViewTextBoxColumn,
            this.guestidDataGridViewTextBoxColumn,
            this.roomNoDataGridViewTextBoxColumn,
            this.checkINDataGridViewTextBoxColumn,
            this.checkOUTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.guestReservationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // residDataGridViewTextBoxColumn
            // 
            this.residDataGridViewTextBoxColumn.DataPropertyName = "res_id";
            this.residDataGridViewTextBoxColumn.FillWeight = 94.9848F;
            this.residDataGridViewTextBoxColumn.HeaderText = "res_id";
            this.residDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.residDataGridViewTextBoxColumn.Name = "residDataGridViewTextBoxColumn";
            this.residDataGridViewTextBoxColumn.ReadOnly = true;
            this.residDataGridViewTextBoxColumn.Width = 125;
            // 
            // guestidDataGridViewTextBoxColumn
            // 
            this.guestidDataGridViewTextBoxColumn.DataPropertyName = "guest_id";
            this.guestidDataGridViewTextBoxColumn.FillWeight = 98.01553F;
            this.guestidDataGridViewTextBoxColumn.HeaderText = "guest_id";
            this.guestidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guestidDataGridViewTextBoxColumn.Name = "guestidDataGridViewTextBoxColumn";
            this.guestidDataGridViewTextBoxColumn.Width = 129;
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "room_No";
            this.roomNoDataGridViewTextBoxColumn.FillWeight = 100.4705F;
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "room_No";
            this.roomNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            this.roomNoDataGridViewTextBoxColumn.Width = 132;
            // 
            // checkINDataGridViewTextBoxColumn
            // 
            this.checkINDataGridViewTextBoxColumn.DataPropertyName = "checkIN";
            this.checkINDataGridViewTextBoxColumn.FillWeight = 102.4591F;
            this.checkINDataGridViewTextBoxColumn.HeaderText = "checkIN";
            this.checkINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkINDataGridViewTextBoxColumn.Name = "checkINDataGridViewTextBoxColumn";
            this.checkINDataGridViewTextBoxColumn.Width = 135;
            // 
            // checkOUTDataGridViewTextBoxColumn
            // 
            this.checkOUTDataGridViewTextBoxColumn.DataPropertyName = "checkOUT";
            this.checkOUTDataGridViewTextBoxColumn.FillWeight = 104.07F;
            this.checkOUTDataGridViewTextBoxColumn.HeaderText = "checkOUT";
            this.checkOUTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkOUTDataGridViewTextBoxColumn.Name = "checkOUTDataGridViewTextBoxColumn";
            this.checkOUTDataGridViewTextBoxColumn.Width = 137;
            // 
            // guestReservationBindingSource
            // 
            this.guestReservationBindingSource.DataMember = "guestReservation";
            this.guestReservationBindingSource.DataSource = this.hotelManagementSystemDataSet1BindingSource;
            // 
            // hotelManagementSystemDataSet1BindingSource
            // 
            this.hotelManagementSystemDataSet1BindingSource.DataSource = this.hotel_ManagementSystemDataSet1;
            this.hotelManagementSystemDataSet1BindingSource.Position = 0;
            // 
            // hotel_ManagementSystemDataSet1
            // 
            this.hotel_ManagementSystemDataSet1.DataSetName = "hotel_ManagementSystemDataSet1";
            this.hotel_ManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestReservationTableAdapter
            // 
            this.guestReservationTableAdapter.ClearBeforeFill = true;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.Black;
            this.save_btn.Location = new System.Drawing.Point(155, 98);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 41);
            this.save_btn.TabIndex = 22;
            this.save_btn.Text = "SAVE";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // in_lbl
            // 
            this.in_lbl.AutoSize = true;
            this.in_lbl.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_lbl.Location = new System.Drawing.Point(6, 38);
            this.in_lbl.Name = "in_lbl";
            this.in_lbl.Size = new System.Drawing.Size(76, 16);
            this.in_lbl.TabIndex = 18;
            this.in_lbl.Text = "CHECK-IN";
            // 
            // out_lbl
            // 
            this.out_lbl.AutoSize = true;
            this.out_lbl.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_lbl.Location = new System.Drawing.Point(6, 70);
            this.out_lbl.Name = "out_lbl";
            this.out_lbl.Size = new System.Drawing.Size(90, 16);
            this.out_lbl.TabIndex = 19;
            this.out_lbl.Text = "CHECK-OUT";
            // 
            // in_tb
            // 
            this.in_tb.Location = new System.Drawing.Point(98, 32);
            this.in_tb.Name = "in_tb";
            this.in_tb.Size = new System.Drawing.Size(266, 23);
            this.in_tb.TabIndex = 20;
            // 
            // out_tb
            // 
            this.out_tb.Location = new System.Drawing.Point(98, 67);
            this.out_tb.Name = "out_tb";
            this.out_tb.Size = new System.Drawing.Size(266, 23);
            this.out_tb.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.in_lbl);
            this.groupBox1.Controls.Add(this.save_btn);
            this.groupBox1.Controls.Add(this.out_lbl);
            this.groupBox1.Controls.Add(this.out_tb);
            this.groupBox1.Controls.Add(this.in_tb);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 139);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATE";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(738, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestReservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementSystemDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementSystemDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hotelManagementSystemDataSet1BindingSource;
        private hotel_ManagementSystemDataSet1 hotel_ManagementSystemDataSet1;
        private System.Windows.Forms.BindingSource guestReservationBindingSource;
        private hotel_ManagementSystemDataSet1TableAdapters.guestReservationTableAdapter guestReservationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn residDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label in_lbl;
        private System.Windows.Forms.Label out_lbl;
        private System.Windows.Forms.TextBox in_tb;
        private System.Windows.Forms.TextBox out_tb;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}