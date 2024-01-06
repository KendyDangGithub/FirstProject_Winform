using BUS;
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

namespace GUI
{
    public partial class fHoSoSinhVien : Form
    {
        public fHoSoSinhVien()
        {
            InitializeComponent();
            LoadSinhVien();
        }

        void LoadSinhVien()
        {
            dataGridViewContent.DataSource = BUSSinhVien.Instance.GetAllStudent().Tables["SinhVien"];
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "STT";
            sttColumn.HeaderText = "STT";
            dataGridViewContent.Columns.Insert(0, sttColumn);
            for (int i = 0; i < dataGridViewContent.Rows.Count; i++)
            {
                dataGridViewContent.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
        private void fHoSoSinhVien_Load(object sender, EventArgs e)
        {
            
        }
    }
}
