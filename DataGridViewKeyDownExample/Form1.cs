using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewKeyDownExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * SetupDataGridView()
         * DataGridView의 기본적인 설정을 합니다.
         */
        private void SetupDataGridView()
        {
            this.Controls.Add(dataGridView1);

            // DataGridView의 컬럼 갯수를 5개로 설정합니다.
            dataGridView1.ColumnCount = 5;

            // DatagridView에 컬럼을 추가합니다.
            dataGridView1.Columns[0].Name = "Release Date";
            dataGridView1.Columns[1].Name = "Track";
            dataGridView1.Columns[2].Name = "Title";
            dataGridView1.Columns[3].Name = "Artist";
            dataGridView1.Columns[4].Name = "Album";

            dataGridView1.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(DataGridView_EditingControlShowing);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }


        public void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            dataGridView1.EditingControl.KeyUp += new KeyEventHandler(EditingControl_KeyUp);
        }

        private void EditingControl_KeyUp(object sender, KeyEventArgs e)
        {
            DataGridViewTextBoxEditingControl editText = (DataGridViewTextBoxEditingControl)sender;

            // KeyDown 이벤트에 대한 처리를 한다. 
            MessageBox.Show("당신은 숫자 " + editText.Text + " 키를 눌렀습니다.");
        }
    }
}
