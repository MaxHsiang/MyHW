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
    public partial class FrmPhoto : Form
    {
        public FrmPhoto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTool F = new FrmTool ();
            F.Show();
        }

        private void productPhotoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

    }
}