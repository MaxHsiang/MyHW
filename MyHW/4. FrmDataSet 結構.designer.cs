
namespace MyHW
{
    partial class FrmDataSet_結構
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn收合 = new System.Windows.Forms.Button();
            this.btnReadXML = new System.Windows.Forms.Button();
            this.btnWriteXML = new System.Windows.Forms.Button();
            this.btn抓資料 = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lBX資料 = new System.Windows.Forms.ListBox();
            this.productsTableAdapter1 = new MyHW.MyDataSetTableAdapters.ProductsTableAdapter();
            this.categoriesTableAdapter1 = new MyHW.MyDataSetTableAdapters.CategoriesTableAdapter();
            this.customersTableAdapter1 = new MyHW.MyDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager1 = new MyHW.MyDataSetTableAdapters.TableAdapterManager();
            this.myDataSet1 = new MyHW.MyDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn收合);
            this.splitContainer1.Panel1.Controls.Add(this.btnReadXML);
            this.splitContainer1.Panel1.Controls.Add(this.btnWriteXML);
            this.splitContainer1.Panel1.Controls.Add(this.btn抓資料);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoad);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn收合
            // 
            this.btn收合.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn收合.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn收合.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn收合.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn收合.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn收合.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn收合.Location = new System.Drawing.Point(7, 215);
            this.btn收合.Name = "btn收合";
            this.btn收合.Size = new System.Drawing.Size(149, 47);
            this.btn收合.TabIndex = 9;
            this.btn收合.Text = "收合";
            this.btn收合.UseVisualStyleBackColor = true;
            this.btn收合.Click += new System.EventHandler(this.btn收合_Click);
            // 
            // btnReadXML
            // 
            this.btnReadXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadXML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnReadXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReadXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadXML.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadXML.Location = new System.Drawing.Point(6, 162);
            this.btnReadXML.Name = "btnReadXML";
            this.btnReadXML.Size = new System.Drawing.Size(149, 47);
            this.btnReadXML.TabIndex = 8;
            this.btnReadXML.Text = "ReadXML";
            this.btnReadXML.UseVisualStyleBackColor = true;
            this.btnReadXML.Click += new System.EventHandler(this.btnReadXML_Click);
            // 
            // btnWriteXML
            // 
            this.btnWriteXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWriteXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteXML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnWriteXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnWriteXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteXML.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWriteXML.Location = new System.Drawing.Point(6, 109);
            this.btnWriteXML.Name = "btnWriteXML";
            this.btnWriteXML.Size = new System.Drawing.Size(149, 47);
            this.btnWriteXML.TabIndex = 7;
            this.btnWriteXML.Text = "WriteXML";
            this.btnWriteXML.UseVisualStyleBackColor = true;
            this.btnWriteXML.Click += new System.EventHandler(this.btnWriteXML_Click);
            // 
            // btn抓資料
            // 
            this.btn抓資料.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn抓資料.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn抓資料.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn抓資料.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn抓資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn抓資料.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn抓資料.Location = new System.Drawing.Point(6, 56);
            this.btn抓資料.Name = "btn抓資料";
            this.btn抓資料.Size = new System.Drawing.Size(149, 47);
            this.btn抓資料.TabIndex = 6;
            this.btn抓資料.Text = "[ ][ ]-抓資料";
            this.btn抓資料.UseVisualStyleBackColor = true;
            this.btn抓資料.Click += new System.EventHandler(this.btn抓資料_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoad.Location = new System.Drawing.Point(6, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(149, 47);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lBX資料);
            this.splitContainer2.Size = new System.Drawing.Size(639, 450);
            this.splitContainer2.SplitterDistance = 176;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(639, 176);
            this.splitContainer3.SplitterDistance = 205;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataGridView3);
            this.splitContainer4.Size = new System.Drawing.Size(430, 176);
            this.splitContainer4.SplitterDistance = 215;
            this.splitContainer4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(205, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(215, 176);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(211, 176);
            this.dataGridView3.TabIndex = 2;
            // 
            // lBX資料
            // 
            this.lBX資料.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBX資料.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBX資料.FormattingEnabled = true;
            this.lBX資料.HorizontalScrollbar = true;
            this.lBX資料.ItemHeight = 14;
            this.lBX資料.Location = new System.Drawing.Point(0, 0);
            this.lBX資料.Name = "lBX資料";
            this.lBX資料.Size = new System.Drawing.Size(639, 270);
            this.lBX資料.TabIndex = 0;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CategoriesTableAdapter = this.categoriesTableAdapter1;
            this.tableAdapterManager1.CustomersTableAdapter = this.customersTableAdapter1;
            this.tableAdapterManager1.ProductsTableAdapter = this.productsTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = MyHW.MyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // myDataSet1
            // 
            this.myDataSet1.DataSetName = "MyDataSet";
            this.myDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmDataSet_結構
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmDataSet_結構";
            this.Text = "FrmDataSet_結構";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btn收合;
        private System.Windows.Forms.Button btnReadXML;
        private System.Windows.Forms.Button btnWriteXML;
        private System.Windows.Forms.Button btn抓資料;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ListBox lBX資料;
        private MyDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private MyDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private MyDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private MyDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private MyDataSet myDataSet1;
    }
}