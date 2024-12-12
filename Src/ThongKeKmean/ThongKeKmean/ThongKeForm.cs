using Accord.MachineLearning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ThongKeKmean.DAO;

namespace ThongKeKmean
{
    public partial class ThongKeForm : Form
    {
        private readonly string _connectionString;
        CustomerDao customerDao;
        ThuatToan tt;
        DataTable dataKmean = new DataTable();
        public ThongKeForm(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();
            customerDao = new CustomerDao(_connectionString);
            tt = new ThuatToan(customerDao);
        }
        private void LoadChart(DataTable data)
        {
            Chart chart = new Chart
            {
                Dock = DockStyle.Fill,
            };

            ChartArea chartArea = new ChartArea
            {
                AxisX = { Title = "Tuổi", IntervalAutoMode = IntervalAutoMode.VariableCount },
                AxisY = { Title = "Số tiền", IntervalAutoMode = IntervalAutoMode.VariableCount }
            };
            chart.ChartAreas.Add(chartArea);

            var clusters = data.AsEnumerable()
                               .Select(row => Convert.ToInt32(row["Cluster"]))
                               .Distinct()
                               .ToList();

            Dictionary<int, double[]> centroids = new Dictionary<int, double[]>();
            Dictionary<int, Color> centroidColors = new Dictionary<int, Color>();

            Random random = new Random();

            foreach (int cluster in clusters)
            {
                var rowsInCluster = data.AsEnumerable()
                                        .Where(row => Convert.ToInt32(row["Cluster"]) == cluster);

                double avgAge = rowsInCluster.Average(row => Convert.ToDouble(row["Age"]));
                double avgPurchase = rowsInCluster.Average(row => Convert.ToDouble(row["TotalPurchaseAmount"]));

                centroids[cluster] = new double[] { avgAge, avgPurchase };

                centroidColors[cluster] = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            }

            foreach (int cluster in clusters)
            {
                Series series = new Series($"Cluster {cluster}")
                {
                    ChartType = SeriesChartType.Point,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8,
                    Color = centroidColors[cluster]
                };

                var rowsInCluster = data.AsEnumerable()
                                        .Where(row => Convert.ToInt32(row["Cluster"]) == cluster);

                foreach (var row in rowsInCluster)
                {
                    double age = Convert.ToDouble(row["Age"]);
                    double totalPurchase = Convert.ToDouble(row["TotalPurchaseAmount"]);
                    series.Points.AddXY(age, totalPurchase);
                }

                chart.Series.Add(series);

                double centroidX = centroids[cluster][0];
                double centroidY = centroids[cluster][1];

                Series centroidSeries = new Series($"Centroid {cluster}")
                {
                    ChartType = SeriesChartType.Point,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 15,
                    Color = centroidColors[cluster]
                };
                centroidSeries.Points.AddXY(centroidX, centroidY);
                chart.Series.Add(centroidSeries);
            }

            pnlChart.Controls.Clear();
            pnlChart.Controls.Add(chart);
        }



        private void btnPhanCum_Click(object sender, EventArgs e)
        {
            if(txtCum.Value == 0)
            {
                MessageBox.Show("Nhập số cum trước khi chạy thuật toán, số cụm phải lớn hơn 0!");
                return;
            }
            int soCum = (int)txtCum.Value;
            dataKmean = tt.PhanCum(soCum);
            LoadChart(dataKmean);
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            DanhSachCustomerForm frm = new DanhSachCustomerForm(dataKmean);
            frm.ShowDialog();
        }
    }
}
