using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Security.Policy;
using System.ComponentModel.Design;

namespace EccomerceDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=localhost; Database=Order; User Id=sa; Password=Pioggia04;";
            SqlConnection con = new SqlConnection(connStr);     

            Console.WriteLine($"connessione = {con}");
            con.Open();
            Console.WriteLine("connessione aperta");
            // QUERY SCALARE
            string q = "select count(*)  orders";
            var cmd = new SqlCommand(q, con);
            cmd.ExecuteScalar(); //restituisce un valore numerico
            var n = cmd.ExecuteScalar();
            Console.WriteLine($"ci sono {n} ordini");
            //////// QUERY CON READER

            //cmd = new SqlCommand("select * from orders",con);
            //var orders = cmd.ExecuteReader();
            //while (orders.Read())
            //{
            //    Console.WriteLine("{0} {1}", orders["orderid"], orders["customer"]);
            //}

            string user = "Jack";
            cmd = new SqlCommand("select * from orders where customer = @user", con);
            SqlParameter par = new SqlParameter("@user", SqlDbType.VarChar);
            cmd.Parameters.Add(par);
            par.Value = user;
            using (var orders = cmd.ExecuteReader())
            {
                while (orders.Read())
                {
                    Console.WriteLine("{0} {1}", orders["orderid"], orders["customer"]);
                }
            }

            #region DML 
            //Console.WriteLine("DML UPDATE");
            //cmd = new SqlCommand("update orderitems set price=price+100 where orderid = @order", con);
            //cmd.Parameters.Add(new SqlParameter("@order", 1));
            //Console.WriteLine($"ho modificato {cmd.ExecuteNonQuery()} righe");
            #endregion


            #region Query con data set

            //SqlDataAdapter a = new SqlDataAdapter("select * from customers", con);
            //DataSet model = new DataSet();
            //a.Fill(model, "customers");
            //Console.WriteLine("CARICO IL DATASET");
            //foreach (DataRow c in model.Tables["customers"].Rows)
            //{
            //    Console.WriteLine("{0} {1}", c["customer"], c["country"]);


            //}

            //SqlTransaction tr = null;
            //try
            //{
            //    tr = con.BeginTransaction();
            //    Console.WriteLine("CONSOLE UPDATE");
            //    cmd = new SqlCommand("update orderitems set price = price + 100 where orderid = @order", con, tr);
            //    cmd.Parameters.Add(new SqlParameter("@order", 1));
            //    Console.WriteLine($"ho modificato {cmd.ExecuteNonQuery()} righe");
            //    tr.Commit();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    tr.Rollback();
            //}
            #endregion


            //HashPassword(password);
            Login(cmd);
            CreaUtente(cmd);
            CreaOrdine(cmd,user);
            DettaglioOrdine(cmd);





            con.Close();
            Console.WriteLine("connessione chiusa");
            Console.ReadLine();


        }


        static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static int Login(SqlCommand cmd)
        {

            

                Console.Write("Inserisci il nome utente: ");
                string login = Console.ReadLine();
                Console.Write("Inserisci la password: ");
                string password = Console.ReadLine();
                string passwordHashed = HashPassword(password);

                cmd.CommandText = "SELECT ID FROM Utenti WHERE Login = @login AND Password = @password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", passwordHashed);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int utenteId = Convert.ToInt32(result);
                    Console.WriteLine("Accesso effettuato con successo.");
                    return utenteId;
                }
                else
                {
                    Console.WriteLine("Credenziali non valide.");
                    return -1;
                }
            

        }

        public static void CreaUtente(SqlCommand cmd)
        {

            Console.Write("Inserisci il nome utente: ");
            string login = Console.ReadLine();
            Console.Write("Inserisci la password: ");
            string password = Console.ReadLine();
            string passwordHashed = HashPassword(password);

            cmd.CommandText = "INSERT INTO Utenti (Login, Password) VALUES (@login, @password)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", passwordHashed);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Utente creato con successo.");

        }


        //public static List<T> ListaOrdini <T>(List<string> lines, SqlCommand cmd, SqlConnection con) where T : class, new() 
        //{
        //    cmd = new SqlCommand("select o.orderid, customer, orderdate, sum(price*qty) as tot " +
        //        "from orders as o inner join orderitems as i on o.orderid=i.orderid" +
        //        "group by o.orderid, customer, orderdate", con);
        //    List<T> list = new List<T>();
        //    return list;


        //}

        static int CreaOrdine(SqlCommand cmd, string customer)
        {
            Console.Write("Inserisci la data (YYYY-MM-DD): ");
            string data = Console.ReadLine();
            Console.Write("Inserisci il totale dell'ordine: ");
            if (double.TryParse(Console.ReadLine(), out double totale))
            {
                cmd.CommandText = "INSERT INTO orders (customer, orderdate, Totale) VALUES (@customer, @orderdate, @totale)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@customer", customer);
                cmd.Parameters.AddWithValue("@orderdate", data);
                cmd.Parameters.AddWithValue("@totale", totale);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Ordine creato con successo.");
                cmd.CommandText = "SELECT last_insert_rowid()";
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                Console.WriteLine("Totale non valido.");
                return -1;
            }
        }

        static void ListaOrdine( SqlCommand cmd, int customer)
        {
            cmd.CommandText = "SELECT o.orderid, customer, orderdate, sum(price*qty) as tot" +
                "from orders as o inner join orderitems as i on o.orderid=i.orderid" +
                "group by o.orderid, customer, orderdate";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@customer", customer);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"ID Ordine: {reader["orderid"]}, Data: {reader["orderdate"]}, Totale: {reader["tot"]}");
                }
            }
        }


        static void DettaglioOrdine(SqlCommand cmd)
        {
            int id = 1;
            Console.WriteLine($"dettaglio ordine {id}");
            cmd.CommandText = "select * from orders where orderid=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            using (var orders = cmd.ExecuteReader())
            {
                if (orders.Read())
                {
                    Console.WriteLine("{0} {1}", orders["orderid"], orders["customer"], orders["orderdate"]);
                }
                else
                {
                    Console.WriteLine("non treovato");
                }

            }

            cmd.CommandText = "select * from orderitems where orderid=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            using (var orderitems = cmd.ExecuteReader())
            {
                while (orderitems.Read())
                {
                    Console.WriteLine("{0} {1}", orderitems["item"], orderitems["qty"], orderitems["price"]);
                }

                //      cmd.CommandText = @"
                //      SELECT i.item, i.qty,i.price
                //FROM orderitems as i
                //      JOIN Orders o ON i.orderid = o.orderid
                //      WHERE i.orderid = o.orderid
                //  ";
                //      cmd.Parameters.Clear();
                //      cmd.Parameters.AddWithValue("@orderid", idOrdine);

                //      using (SqlDataReader reader = cmd.ExecuteReader())
                //      {
                //          while (reader.Read())
                //          {
                //              Console.WriteLine($"Prodotto: {reader["item"]}, Quantità: {reader["qty"]}, Prezzo Unitario: {reader["price"]}");
                //          }
                //      }
            }
        }
    }
}



