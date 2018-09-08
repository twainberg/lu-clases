using System;
using System.Data;
using System.Data.SqlClient;

namespace Conexion
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var conn = new SqlConnection("Server=TW;Database=Empresa;Trusted_Connection=True;"))
            {
                conn.Open();

                var cmd = new SqlCommand("SELECT * FROM CLIENTES");
                cmd.Connection = conn;

                using(var result = cmd.ExecuteReader())
                {
                    while(result.Read())
                    {
                        var id = result["Id"];
                        Console.Write(id);

                        var nombre = result["Nombre"];
                        Console.WriteLine(nombre);
                    }
                }

                string empresa = "' GO DELETE FROM Clientes --";

                cmd = new SqlCommand("INSERT INTO Clientes VALUES (@par1, @par2, @par3)");

                cmd.Parameters.Add( new SqlParameter("par1", 9));
                cmd.Parameters.Add( new SqlParameter("par2", empresa));
                cmd.Parameters.Add( new SqlParameter("par3", "80-80808080-8"));
                cmd.Connection = conn;

                var r = cmd.ExecuteNonQuery();
                Console.WriteLine(r);

                cmd = new SqlCommand("SELECT * FROM Clientes WHERE (Nombre = @Nombre)");
                cmd.Parameters.Add( new SqlParameter("Nombre", empresa));
                cmd.Connection = conn;

                using(var result = cmd.ExecuteReader())
                {
                    while(result.Read())
                    {
                        Console.WriteLine(result["Nombre"]);
                    }
                }

            }
        }
    }
}
