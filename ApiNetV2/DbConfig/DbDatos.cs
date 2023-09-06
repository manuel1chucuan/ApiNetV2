using System.Data.SqlClient;

namespace ApiNetV2.DbConfig
{
    public interface IDbDatos
    {
        SqlConnection GetOpenConnection();
        SqlCommand CreateCommand();
        string ConnectionString { get; }
    }

    public class DbDatos : IDbDatos
    {
        private readonly string _cnString;
        public string ConnectionString => _cnString;

        public DbDatos()
        {
            SqlConnectionStringBuilder conn = new();
            conn.DataSource = "localhost";
            conn.InitialCatalog = "NetApiDb";
            conn.UserID = "sa";
            conn.Password = "as123456";
            _cnString = conn.ConnectionString;
        }

        public SqlConnection GetOpenConnection()
        {
            SqlConnection connection = new SqlConnection(_cnString);
            connection.Open();
            return connection;
        }

        public SqlCommand CreateCommand()
        {
            SqlConnection connection = GetOpenConnection();
            SqlCommand sqlCommand = connection.CreateCommand();
            return sqlCommand;
        }
    }
}
