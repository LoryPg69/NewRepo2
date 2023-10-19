
using System;
using System.Data.Entity.Validation;

namespace EcommerceFrameworkEntity
{
    namespace LoginEntityFramework
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                string options = "";
                var ctx = new masterEntities2();

                using (ctx)
                {
                    while (options != "exit")
                    {
                        checkEmpty(ctx);
                        Console.WriteLine("Benvenuto eseguire il login");
                        Login(ctx);
                        Console.WriteLine("Benvenuto nel menu");
                        Console.WriteLine("selezionare una procedura");
                        Console.WriteLine("scrivere utente per creare un utente");
                        Console.WriteLine("scrivere list per visualizzare la lista degli ordini");
                        Console.WriteLine("scrivere detail per visualizzare il dettaglio dell'ordine");
                        Console.WriteLine("scrivere neworder per creare un nuovo ordine");
                        Console.WriteLine("scrivere exit per uscire");

                        options = Console.ReadLine();
                        switch (options)
                        {
                            case "utente":
                                createUser(ctx);
                                break;
                            case "list":
                                listOrder(ctx);
                                break;
                            case "detail":
                                detailOrder(ctx);
                                break;
                            case "neworder":
                                createOrder(ctx);
                                break;
                            case "exit":
                                return;
                            default:
                                Console.WriteLine("scrivere una parola valida");
                                break;
                        }
                    }
                }

                Console.ReadLine();
            }

            public static void checkEmpty(masterEntities2 ctx)
            {
                int i = 0;
                foreach (var u in ctx.utenti)
                {
                    i += 1;
                }
                if (i == 0)
                {
                    var newUser = new utenti() { username = "admin", password = "admin" };
                    ctx.utenti.Add(newUser);
                    Console.WriteLine("Nuovo utente admin registrato");
                }
                else
                {
                    return;
                }
                try
                {
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    Console.WriteLine(e.Message);

                }
            }

            public static void Login(masterEntities2 ctx)
            {
                Console.WriteLine("Inserire il nome utente");
                string username = Console.ReadLine();
                Console.WriteLine("Inserire la password");
                string password = Console.ReadLine();
                try
                {
                    foreach (var cust in ctx.utenti)
                    {
                        if (cust.username == username && cust.password == password)
                        {
                            Console.WriteLine($"Benvenuto: {username}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("credenziali non valide");
                }

                try 
                { 
                    ctx.SaveChanges(); 
                }
                catch (DbEntityValidationException e)
                { 
                    Console.WriteLine(e.Message);
                
                        }
            }

            public static void readUsers(masterEntities2 ctx)
            {
                foreach (var user in ctx.utenti)
                {
                    Console.WriteLine($"utente: {user.username} {user.password}");

                }
                try
                {
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    Console.WriteLine(e.Message);

                }
            }

            public static void createUser(masterEntities2 ctx)
            {
                Console.WriteLine("Inserire il nome utente");
                string username = Console.ReadLine();
                Console.WriteLine("Inserire la password");
                string password = Console.ReadLine();

                var newUser = new utenti() { username = username, password = password };
                ctx.utenti.Add(newUser);
                new User(username, password);
                Console.WriteLine("Nuovo utente registrato");
                ctx.SaveChanges();
            }

            public static void listOrder(masterEntities2 ctx)
            {
                Console.WriteLine($"orders : ");
                Console.WriteLine($"orderid\tcustomer\tcountry");
                foreach (var o in ctx.orders)
                {
                    Console.WriteLine($"{o.orderid}:\t{o.customers.customer}\t{o.customers.country}");
                }
                try
                {
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    Console.WriteLine(e.Message);

                }
            }

            public static void detailOrder(masterEntities2 ctx)
            {
                int ord = 0;
                Console.WriteLine("inseire id dell'ordine");
                try
                {
                    ord = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("inserire un valore numerico");
                }
                Console.WriteLine($"orders : ");
                Console.WriteLine($"orderid\tcustomer\tcountry");

                foreach (orders o in ctx.orders)
                {
                    if (o.orderid == ord)
                    {
                        Console.WriteLine($"{o.orderid}:\t{o.customers.customer}\t{o.customers.country}");
                        Console.WriteLine($"orderid\titem\t\tqty\tprice");
                        foreach (orderitems oi in o.orderitems)     //ciclo tabella orderitems
                        {
                            Console.WriteLine($"{oi.orderid}\t{oi.item}\t{oi.qty}\tx{oi.price}");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Id dell'ordine non valido o ordine non esistente ... ! ");
                    }
                }
                try
                {
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    Console.WriteLine(e.Message);

                }
            }

            public static void createOrder(masterEntities2 ctx)
            {
                string prodotto = "";
                int quantità = 0;
                int prezzo = 0;
                string colore = "";
                DateTime date = DateTime.Now;
                Console.WriteLine("Aggiunta nuovo prodotto ... ");
                Console.WriteLine("Inserire il prodotto");
                try
                {
                    prodotto = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("inserire il nome del prodotto!");
                }

                Console.WriteLine("Inserire la quantità");
                try
                {
                    quantità = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("inserire la quantità del prodotto!");
                }

                Console.WriteLine("Inserire il prezzo");
                try
                {
                    prezzo = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("inserire il prezzo del prodotto!");
                }

                Console.WriteLine("Inserire il colore del prodotto");
                try
                {
                    colore = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("inserire il colore del prodotto!");
                }


                int i = 0;
                foreach (orders o in ctx.orders)
                {
                    i += 1;
                }

                var newCustomer = new customers() { customer = User.username, country = "Italy" };
                ctx.customers.Add(newCustomer);
                Console.WriteLine("Nuovo customer registrato");

                var newOrder = new orders() { orderid = i + 1, customer = User.username, orderdate = date };
                ctx.orders.Add(newOrder);
                Console.WriteLine("Nuovo ordine registrato");

                var newOrderitems = new orderitems()
                {
                    orderid = i + 1,
                    item = $"{prodotto}",
                    qty = quantità,
                    price = prezzo
                };
                ctx.orderitems.Add(newOrderitems);
                Console.WriteLine("Nuovo ordineitem registrato");
                var newItem = new items() { item = $"{prodotto}", color = $"{colore}" };
                ctx.items.Add(newItem);
                Console.WriteLine("Nuovo item registrato");
                try
                {
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    Console.WriteLine(e.Message);

                }
            }

            public class User
            {
                public static string username { get; set; }
                public static string password { get; set; }

                public User(string Username, string Password)
                {
                    username = Username;
                    password = Password;
                }
            }
        }
    }
}


//foreach (orders o in ctx.orders)
//{
//    Console.WriteLine($"{o.orderid} {o.customers.customer} {o.customers.country} {o.orderdate}");
//    foreach (orderitems oi in ctx.orderitems)
//    {
//        Console.WriteLine($"\telemento:{oi.item} \tquantità:{oi.qty} \tprezzo:{oi.price}");
//    }
//}

//foreach (var c in ctx.customers)   //MODIFICA CAMPO NEL DB
//    if (c.customer == "Jack")
//    {
//        Console.WriteLine($"aggiorno {c.country}");
//        c.country = "(m)";
//    }

//var post = new customers() { customer = "eeeeeeeeeeeee", country = "ITA" }; //INSERIMENTO CAMPO
// ctx.customers.Add(post);

//foreach (var c in ctx.customers)   // RIMUOVI CAMPO
//    if (c.customer == "nuovo")
//        ctx.customers.Remove(c);

//  //trova solo per chaivi primarie 



//var user = new utenti() { username = "lollo", password = "lollo04" }; 
//ctx.utenti.Add(user);

