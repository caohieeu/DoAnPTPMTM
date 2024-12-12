using Accord.MachineLearning;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThongKeKmean.DAO;

namespace ThongKeKmean
{
    public class ThuatToan
    {
        CustomerDao customerDao;
        public ThuatToan(CustomerDao customerDao)
        {
            this.customerDao = customerDao;
        }
        public DataTable PhanCum(int soCum)
        {
            DataTable customers = customerDao.GetCustomerPurchaseData();

            double[][] inputs = customers.AsEnumerable()
                .Select(row => new double[]
                {
            Convert.ToDouble(row["Age"]),
            Convert.ToDouble(row["TotalPurchaseAmount"])
                })
                .ToArray();

            KMeans kmeans = new KMeans(soCum);
            KMeansClusterCollection clusters = kmeans.Learn(inputs);

            int[] labels = clusters.Decide(inputs);

            customers.Columns.Add("Cluster", typeof(int));
            for (int i = 0; i < customers.Rows.Count; i++)
            {
                customers.Rows[i]["Cluster"] = labels[i];
            }

            return customers;
        }

    }
}
