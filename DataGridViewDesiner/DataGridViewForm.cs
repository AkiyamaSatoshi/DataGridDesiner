using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewDesiner
{
    public partial class DataGridViewForm : Form
    {
        public DataGridViewForm()
        {
            InitializeComponent();
        }

        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'tESTRDBDataSet.MU_MATERIAL' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.mU_MATERIALTableAdapter.Fill(this.tESTRDBDataSet.MU_MATERIAL);

        }
    }
}
