using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data.SqlClient;

namespace AN.Infra.CrossCutting.IoC
{
    public static class ConnectServer
    {
        static SqlConnection cnn;
        //public void Dependencies(this IServiceCollection service)
        //{

        //}

        public static SqlConnection OpenConnection()
        {
            
            cnn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=Anotacoes;");
            cnn.Open();
            return cnn;
        }

        public static void CloseConnection()
        {
            cnn.Close();
        }
    }
}
