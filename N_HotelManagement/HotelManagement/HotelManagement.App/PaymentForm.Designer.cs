namespace HotelManagement.App
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.payidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagementSystemDataSet1 = new HotelManagement.App.hotel_ManagementSystemDataSet1();
            this.paymentTableAdapter = new HotelManagement.App.hotel_ManagementSystemDataSet1TableAdapters.paymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementSystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payidDataGridViewTextBoxColumn,
            this.guestidDataGridViewTextBoxColumn,
            this.residDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(457, 167);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // payidDataGridViewTextBoxColumn
            // 
            this.payidDataGridViewTextBoxColumn.DataPropertyName = "pay_id";
            this.payidDataGridViewTextBoxColumn.HeaderText = "pay_id";
            this.payidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payidDataGridViewTextBoxColumn.Name = "payidDataGridViewTextBoxColumn";
            this.payidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestidDataGridViewTextBoxColumn
            // 
            this.guestidDataGridViewTextBoxColumn.DataPropertyName = "guest_id";
            this.guestidDataGridViewTextBoxColumn.HeaderText = "guest_id";
            this.guestidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guestidDataGridViewTextBoxColumn.Name = "guestidDataGridViewTextBoxColumn";
            // 
            // residDataGridViewTextBoxColumn
            // 
            this.residDataGridViewTextBoxColumn.DataPropertyName = "res_id";
            this.residDataGridViewTextBoxColumn.HeaderText = "res_id";
            this.residDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.residDataGridViewTextBoxColumn.Name = "residDataGridViewTextBoxColumn";
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "payment";
            this.paymentBindingSource.DataSource = this.hotel_ManagementSystemDataSet1;
            // 
            // hotel_ManagementSystemDataSet1
            // 
            this.hotel_ManagementSystemDataSet1.DataSetName = "hotel_ManagementSystemDataSet1";
            this.hotel_ManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 192);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementSystemDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private hotel_ManagementSystemDataSet1 hotel_ManagementSystemDataSet1;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private hotel_ManagementSystemDataSet1TableAdapters.paymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn payidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residDataGridViewTextBoxColumn;
    }
}