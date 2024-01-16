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
using System.Windows.Forms.DataVisualization.Charting;


namespace GUI
{
    public partial class fThongKe : Form
    {
        static string connectionString = @"Data Source=localhost;
                                                Initial Catalog=QuanLySinhVienKhoaCNTT
                                                ;User ID=sa;Password=Kendydang19082004";
        public fThongKe()
        {
            InitializeComponent();
            //CreateChartStudent(connectionString);
            CreateChartScore(connectionString);
        }

        void CreateChartScore(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu từ bảng diemthi và nhóm theo điểm làm tròn
                string query = @"SELECT ROUND(diem, 0) AS DiemLamTron, COUNT(*) AS SoLuong " +
                               "FROM DiemThi " +
                               "GROUP BY ROUND(diem, 0)";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Tạo biểu đồ
                Series series = new Series("Số Lượng Sinh Viên");
                series.ChartType = SeriesChartType.Column;
                series.Name = "Số Lượng Sinh Viên";


                // Đọc dữ liệu từ SqlDataReader và thêm vào biểu đồ
                while (reader.Read())
                {
                    double diemLamTron = reader.GetDouble(0);
                    int soLuong = reader.GetInt32(1);

                    // Thêm dữ liệu vào Series
                    series.Points.AddXY(diemLamTron, soLuong);
                }

                // Thêm Series vào biểu đồ
                chartThongKe.Series.Add(series);

                // Đặt tên cho trục x và y
                chartThongKe.ChartAreas[0].AxisX.Title = "Điểm ";
                chartThongKe.ChartAreas[0].AxisY.Title = "Số Lượng";

                chartThongKe.ChartAreas[0].AxisX.Minimum = 0;  // Giá trị tối thiểu trục x
                chartThongKe.ChartAreas[0].AxisX.Maximum = 11; // Giá trị tối đa trục x

                chartThongKe.ChartAreas[0].AxisY.Minimum = 0;  // Giá trị tối thiểu trục y
                chartThongKe.ChartAreas[0].AxisY.Maximum = 100;

                // Cập nhật biểu đồ
                chartThongKe.Update();


                // Đóng kết nối
                reader.Close();
                connection.Close();
            }
        }

        void CreateChartStudent(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu từ bảng sinhvien và nhóm theo lớp
                string query = "SELECT malop, COUNT(*) AS SoLuongSinhVien " +
                               "FROM sinhvien " +
                               "GROUP BY malop";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Tạo biểu đồ
                Series series = new Series("Số Lượng Sinh Viên");
                series.ChartType = SeriesChartType.Column;

                // Đọc dữ liệu từ SqlDataReader và thêm vào biểu đồ
                while (reader.Read())
                {
                    string lop = reader.GetString(0);
                    int soLuongSinhVien = reader.GetInt32(1);

                    // Thêm dữ liệu vào Series
                    series.Points.AddXY(lop, soLuongSinhVien);
                }

                // Thêm Series vào biểu đồ
                chartThongKe.Series.Add(series);
                
                // Đặt tên cho trục x và y
                chartThongKe.ChartAreas[0].AxisX.Title = "Lớp";
                chartThongKe.ChartAreas[0].AxisY.Title = "Số Lượng Sinh Viên";

                chartThongKe.ChartAreas[0].AxisX.Minimum = 0;  // Giá trị tối thiểu trục x
                chartThongKe.ChartAreas[0].AxisX.Maximum = 10; // Giá trị tối đa trục x

                chartThongKe.ChartAreas[0].AxisY.Minimum = 0;  // Giá trị tối thiểu trục y
                chartThongKe.ChartAreas[0].AxisY.Maximum = 10;

                // Cập nhật biểu đồ
                chartThongKe.Update();


                // Đóng kết nối
                reader.Close();
                connection.Close();
            }
        }

        private void comboBoxDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
  

            if (chartThongKe.Series.Any())
            {
                // Xóa tất cả các Series khỏi biểu đồ
                chartThongKe.Series.Clear();
            }

            // Thêm logic xử lý khi có phần tử được chọn trong comboBoxDiem
            if (comboBoxSelect.SelectedIndex == 0)
            {
                // Thêm logic xử lý cho selectedIndex == 0
                CreateChartScore(connectionString);
            }
            else if (comboBoxSelect.SelectedIndex == 1)
            {
                // Thêm logic xử lý cho selectedIndex == 1
                CreateChartStudent(connectionString);

            }

        }
    }
}
