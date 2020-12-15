using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyElector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stackholdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stackholdersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.Stackholders' table. You can move, or remove it, as needed.
            this.stackholdersTableAdapter.Fill(this.mydbDataSet.Stackholders);

        }
    }
}
