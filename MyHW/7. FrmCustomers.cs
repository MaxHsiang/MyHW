using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmCustomers : Form
    {
        private ComboBox comboBox1;
        private ListView listView1;

        public FrmCustomers()
        {
            InitializeComponent();
            LoadCountryToCombobox();
            LoadColumnToListview();
        }

        private void LoadColumnToListview()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    
                    SqlCommand command = new SqlCommand("select * from Customers", conn);
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    DataTable table = dataReader.GetSchemaTable();


                    for (int i = 0; i <= table.Rows.Count - 1; i++)
                    {
                        this.listView1.Columns.Add(table.Rows[i][0].ToString());
                    }

                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCountryToCombobox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select distinct Country from Customers", conn);

                    SqlDataReader dataReader = command.ExecuteReader();

                    this.comboBox1.Items.Clear();
                    while (dataReader.Read())
                    {
                        this.comboBox1.Items.Add(dataReader["Country"]);
                    }
                    this.comboBox1.SelectedIndex = 0;

                } // Auto conn.Close()
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(641, 276);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmCustomers
            // 
            this.ClientSize = new System.Drawing.Size(691, 365);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmCustomers";
            this.ResumeLayout(false);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select * from Customers where country='{this.comboBox1.Text}'";
                    command.Connection = conn;

                    SqlDataReader dataReader = command.ExecuteReader();

                    this.listView1.Items.Clear();

                    Random r = new Random();
                    while (dataReader.Read())
                    {

                        ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());

                        //lvi.ImageIndex = r.Next(0, this.ImageList1.Images.Count);

                        if (lvi.Index % 2 == 0)
                        {
                            lvi.BackColor = Color.Orange;
                        }
                        else
                        {
                            lvi.BackColor = Color.LightGray;
                        }


                        for (int i = 1; i <= dataReader.FieldCount - 1; i++)
                        {
                            if (dataReader.IsDBNull(i))
                            {
                                lvi.SubItems.Add("空值");
                            }
                            else
                            {
                                lvi.SubItems.Add(dataReader[i].ToString());
                            }

                        }
                    }
                } // Auto conn.Close()
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
