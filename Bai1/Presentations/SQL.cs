using System.Data;
using System.Data.SqlClient;

namespace Bai1.Presentations
{
    public static class SQL
    {
        public static readonly string ConString = "Server = localhost; Database= NONGTRAI; Integrated Security = true";
        public static SqlConnection Conn = new SqlConnection(ConString);
        public static void InsertGIASUCData(string loai, int socon, int sua)
        {
            DeleteGIASUCData(loai);
            var query = "INSERT INTO GIASUC VALUES (@Loai, @Socon, @Sua)";
            using (var conn = new SqlConnection(ConString))
            {
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Loai", loai);
                cmd.Parameters.AddWithValue("@Socon", socon);
                cmd.Parameters.AddWithValue("@Sua", sua);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private static void DeleteGIASUCData(string loai)
        {
            var query = "DELETE FROM GIASUC WHERE loai = @Loai";
            using (var conn = new SqlConnection(ConString))
            {
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Loai", loai);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static DataTable LoadGIASUCData()
        {
            var query = "SELECT * FROM GIASUC";
            using (var conn = new SqlConnection(ConString))
            {
                var cmd = new SqlCommand(query, conn);
                var dataTable = new DataTable();
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                conn.Close();
                return dataTable;
            }
        }
    }
}