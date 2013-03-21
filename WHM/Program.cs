using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using System.Data; 
using MySql.Data.MySqlClient;



namespace WHM
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Database db = new Database("ragnarok700.dyndns-ip.com", "soen390", "soen390", "test1234",33067);
            
            db.DBConnection.Open();
            DataTable dt = new DataTable();
            MySqlCommand cm = new MySqlCommand("SELECT * FROM ListSex", db.DBConnection);
           // MySqlCommand cm = new MySqlCommand("Call GetListSex", db.DBConnection);
            //cm.CommandType = CommandType.StoredProcedure;
            cm.ExecuteNonQueryAsync();
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            da.Fill(dt);
            db.DBConnection.Close();
            
            
            
            
            
            
            /*
            try {

                string sqlCmd = "select * from ListSex";

                MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, db.DBConnection);
                adr.SelectCommand.CommandType = CommandType.Text;

                DataTable dt = new DataTable();
                adr.Fill(dt); //opens and closes the DB connection automatically !! (fetches from pool)

                foreach (DataRow dr in dt.Rows){
                  //  Console.WriteLine(string.Format("user_id = {0}", dr["Description"].ToString()));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{oops - {0}", ex.Message);
            }
            finally
            {
                db.DBConnection.Dispose(); // return connection to pool
            }
            Console.WriteLine("press any key...");
            Console.ReadKey();
        */
            
            
            
            
            
            //db.DBConnection.Open();

            /*
            db.DBConnection.Open();
            DataTable dt = new DataTable();
            MySqlCommand cm = new MySqlCommand("Select * from ListSex", db.DBConnection);
            cm.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            da.Fill(dt);
            db.DBConnection.Close();
            */
            /*
        
            MySqlDataAdapter myDA = new MySqlDataAdapter("Call GetListSex", db.DBConnection);
           MySqlCommandBuilder cmb = new MySqlCommandBuilder(myDA);
          // MySqlCommand cmdSel = new MySqlCommand("CALL GetListSex", db.DBConnection);
          //MySqlDataAdapter myDA = new MySqlDataAdapter(cmdSel);
            DataTable MyDT = new DataTable();// <- My DataTable
            myDA.Fill(MyDT);
           */
        
            MySql.Data.MySqlClient.MySqlDataReader rdr = db.getStore("GetListSex");
            List<string> l = new List<string>();
            while (rdr.Read())
             {

                l.Add( Convert.ToString(rdr["Description"]));

                
             }
            
             rdr.Close();
            
            
            return;
        }
    }
}
