using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreTesting
{
    public partial class DataControls : Form
    {
        public DataControls()
        {
            InitializeComponent();
            dataGridView1.Rows[0].Cells[0].Value = "TextBox";
            dataGridView1.Rows[0].Cells[1].Value = "Link";

            dataGridView1.Rows[0].Cells[5].Value = "Button";
        }
        private void DataControls_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Id");
            dt.Columns.Add("Desc");
            for (int i = 0; i < 20; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = "Jack" + i.ToString();
                dr[1] = i * 10;
                dr[2] = "I like" + i.ToString();
                dt.Rows.Add(dr);
            }
            //this.dataGridView2.DataSource = dt;

            bindingSource1.DataSource = dt;
            dataGridView2.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

        }
    }
}
