using ApiNetV2.Data;
using ApiNetV2.DbConfig;
using System.Data;
using System.Data.SqlClient;

namespace ApiNetV2.Models
{
    public class ClienteInfo
    {
        public readonly IDbDatos LdbDatos;

        public ClienteInfo(IDbDatos dbDatos)
        {
            LdbDatos = dbDatos;
        }

        public List<DataClient> GetClientes()
        {
            DataClient dataClient = new DataClient();
            List<DataClient> arrDataClients = new List<DataClient>();

            using (SqlConnection connection = LdbDatos.GetOpenConnection())
            using (SqlCommand sqlCommand = LdbDatos.CreateCommand())
            {
                sqlCommand.CommandText = "SELECT * FROM Clientes";
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataClient.ClienteId = reader.GetInt32("ClienteId");
                        dataClient.Name = reader.GetString("Name");
                        dataClient.Edad = reader.GetInt32("Edad");
                        arrDataClients.Add(dataClient);
                    }
                }
            }


            return arrDataClients;
        }

    }

}
