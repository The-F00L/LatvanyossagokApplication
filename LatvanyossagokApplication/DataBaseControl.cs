using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    class DataBaseControl
    {
        private static readonly string connString = "Server=127.0.0.1;Port=3306;Database=latvanyossagokdb;Uid=root;Pwd='';";
        private static MySqlConnection conn = null;
        private static MySqlCommand cmd = null;

        public static Boolean csatlakozas()
        {
            try
            {
                conn = new MySqlConnection(connString);
                conn.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        private static Boolean tableExist(string tablaNev)
        {
            try
            {
                cmd = new MySqlCommand(@"SELECT * FROM " + tablaNev,conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                return false;
            }
            return true;
        }


        public static void tableMade()
        {
            if (tableExist("varosok") == false){
                cmd = new MySqlCommand(
                    "CREATE TABLE varosok(" +
                        "id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY," +
                        "nev VARCHAR(100) NOT NULL UNIQUE," +
                        "lakossag INT" +
                    ")", conn);
                cmd.ExecuteNonQuery();
                cmd.Cancel();
            }


            if (tableExist("latvanyossagok") == false){
                cmd = new MySqlCommand(
                    "CREATE TABLE latvanyossagok(" +
                        "id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY, " +
                        "nev VARCHAR(1000) NOT NULL, " +
                        "leiras VARCHAR(1000) NOT NULL, " +
                        "ar VARCHAR(1000) DEFAULT 0, " +
                        "varos_id INT UNSIGNED NOT NULL, " +
                        "FOREIGN KEY (varos_id) REFERENCES varosok(id)" +
                    ")", conn);
                cmd.ExecuteNonQuery();
                cmd.Cancel();
            }
        }

        private static Boolean varosExist(string varosNev)
        {
            try
            {
                cmd = new MySqlCommand(
                    @"SELECT COUNT(nev) " +
                    "FROM `varosok` " +
                    "WHERE `nev` LIKE '" +
                    varosNev +
                    "'"
                    , conn);

                if ((int)(long)cmd.ExecuteScalar() == 0)
                {
                    return false;
                }
            }
            catch (Exception e)
            {
              
            }
            return true;
        }

        public static void varosHozzaAd(string varosNev, int lakossag)
        {
            try
            {
                if (!varosExist(varosNev))
                {
                    cmd = new MySqlCommand(
                    @"INSERT INTO `varosok`(`nev`, `lakossag`)"+
                    " VALUES (@nev,@lakossag)"
                    , conn);
                    cmd.Parameters.AddWithValue("@nev", varosNev);
                    cmd.Parameters.AddWithValue("@lakossag", lakossag);

                    cmd.ExecuteNonQuery();
                    cmd.Cancel();
                }
                else
                {
                    MessageBox.Show("Már létezik ilyen nevű város");
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Hiba \n" + e);
            }
        }


        public static void latvanyossagHozzaAd(string Nev, string leiras, int Ar, string vNev)
        {
            try
            {
                if (varosExist(vNev))
                {
                    cmd = new MySqlCommand(
                    "SELECT `id` FROM `varosok` WHERE `nev` like '" +
                    vNev +
                    "'"
                    , conn);
                    string id = cmd.ExecuteScalar().ToString();
                    cmd.Cancel();

                    cmd = new MySqlCommand(
                        @"INSERT INTO `latvanyossagok`" +
                            "(`nev`, " +
                            "`leiras`, " +
                            "`ar`, " +
                            "`varos_id`) " +
                        "VALUES (" +
                            "@nev," +
                            "@leiras," +
                            "@ar," +
                            "@varosID" +
                        ")", conn);
                    cmd.Parameters.AddWithValue("@nev", Nev);
                    cmd.Parameters.AddWithValue("@leiras", leiras);
                    cmd.Parameters.AddWithValue("@ar", Ar);
                    cmd.Parameters.AddWithValue("@varosID", id);
                    cmd.ExecuteNonQuery();
                    cmd.Cancel();
                }
                else
                {
                    MessageBox.Show("Nem létező varaos");
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Hiba \n" + e);
            }
        }
        public static void dataGridViewLoder(string tablaNev, DataGridView dgv)
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapt = new MySqlDataAdapter("select * from " + tablaNev, conn);
            adapt.Fill(dataTable);
            dgv.DataSource = dataTable;
        }




    }
}
