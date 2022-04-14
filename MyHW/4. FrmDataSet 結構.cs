using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmDataSet_結構 : Form
    {
        public FrmDataSet_結構()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter1.Fill(this.myDataSet1.Categories);
            this.dataGridView1.DataSource = this.myDataSet1.Categories;

            this.productsTableAdapter1.Fill(this.myDataSet1.Products);
            this.dataGridView2.DataSource = this.myDataSet1.Products;

            this.customersTableAdapter1.Fill(this.myDataSet1.Customers);
            this.dataGridView3.DataSource = this.myDataSet1.Customers;

            this.lBX資料.Items.Clear();

            for (int i = 0; i <= this.myDataSet1.Tables.Count - 1; i++)
            {
                DataTable table = this.myDataSet1.Tables[i];
                this.lBX資料.Items.Add(table.TableName);
                string s = "";
                for (int column = 0; column <= table.Columns.Count - 1; column++)
                {
                    s += $"{table.Columns[column].ColumnName,-60}";
                }
                this.lBX資料.Items.Add(s);

                string s1 = "";
                for (int row = 0; row <= table.Rows.Count - 1; row++)
                {
                    s1 = "";
                    for (int column = 0; column <= table.Columns.Count - 1; column++)
                    {

                        s1 += $"{table.Rows[row][column],-60}";
                    }
                    this.lBX資料.Items.Add(s1);
                }
                this.lBX資料.Items.Add("======================");
            }

        }

        private void btn抓資料_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.myDataSet1.Products.Rows[0]["ProductName"].ToString());
        }

        private void btnWriteXML_Click(object sender, EventArgs e)
        {
            this.myDataSet1.Products.WriteXml("Product.xml", XmlWriteMode.WriteSchema);
        }

        private void btnReadXML_Click(object sender, EventArgs e)
        {
            this.myDataSet1.Products.ReadXml("Product.xml");
            this.dataGridView1.DataSource = this.myDataSet1.Products;
        }

        private void btn收合_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel1Collapsed = !this.splitContainer2.Panel1Collapsed;
        }
    }
}
