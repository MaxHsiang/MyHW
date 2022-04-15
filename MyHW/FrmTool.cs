﻿using System;
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
    public partial class FrmTool : Form
    {
        public FrmTool()
        {
            InitializeComponent();
        }

        private void photoTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.photoDatabaseDataSet);

        }

        private void FrmTool_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'photoDatabaseDataSet.PhotoTable' 資料表。您可以視需要進行移動或移除。
            this.photoTableTableAdapter.Fill(this.photoDatabaseDataSet.PhotoTable);

        }
    }
}
