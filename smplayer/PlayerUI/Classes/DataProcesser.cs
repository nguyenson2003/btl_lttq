using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLBanHang.Classes
{
    internal class DataProcesser
    {
        string strConnect = "Data Source=DESKTOP-1CHI5GD\\SQLEXPRESS;Initial " +
            "Catalog=[LTTQ_BTL_SMPlayer];Integrated Security=True";
        SqlConnection sqlCnn = null;
        //Hàm mở kết nối
        void OpenConnect()
        {
            sqlCnn = new SqlConnection(strConnect);
            if (sqlCnn.State != ConnectionState.Open)
                sqlCnn.Open();
        }
        //Hàm đóng kết nối
        void CloseConnect()
        {
            if (sqlCnn.State != ConnectionState.Closed)
                sqlCnn.Close();
            sqlCnn.Dispose();//dọn rác
        }
        //Hàm thưc hiện lệnh insert,update, delete
        public void ChangeData(string sql)
        {
            OpenConnect();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlCnn;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            CloseConnect();

        }
        //Hàm đọc dl
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, sqlCnn);
            adapter.Fill(dt);
            CloseConnect();
            return dt;
        }

    }
}
