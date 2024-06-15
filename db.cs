using System.Data.SQLite;



namespace Nail_salon
{
    public class db
    {
        private SQLiteConnection createConnection()
        {
            string connectionString = "Data Source=database.sqlite";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }

        public void createTables()
        {
            string[] Queryes = {
                "CREATE TABLE IF NOT EXISTS Users(id INTEGER NOT NULL UNIQUE  PRIMARY KEY AUTOINCREMENT, fio TEXT,phone TEXT,password TEXT, isAdmin bool)",
                "CREATE TABLE IF NOT EXISTS Services(id INTEGER NOT NULL UNIQUE  PRIMARY KEY AUTOINCREMENT, name TEXT, price INT)",
                "CREATE TABLE IF NOT EXISTS Analytics(id INTEGER NOT NULL UNIQUE  PRIMARY KEY AUTOINCREMENT, masterName TEXT, amountRecords INT, earningsPerDay TEXT, bonusForWork TEXT, deductionForPoorQuatily TEXT  )"
            };

            SQLiteConnection connection = createConnection();
            connection.Open();
            foreach (string query in Queryes)
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

        }
        public bool userIsExists(string phone)
        {
            SQLiteConnection connection = createConnection();
            connection.Open();
            string query = $"SELECT id from Users where phone='{phone}'";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            command.Parameters.Add(new SQLiteParameter("@phone", phone));

            if (reader.Read())
            {
                reader.Close();
                connection.Close();
                return true;
            }
            reader.Close();
            connection.Close();
            return false;
        }
        public string createUser(string fio, string phone,string password,bool isAdmin)
        {
            SQLiteConnection connection = createConnection();
            connection.Open();
            if (userIsExists(phone))
            {
                return "Данная учетная запись уже существует";
            }
            string query =  $"INSERT OR IGNORE INTO Users(fio,phone,password,isAdmin) VALUES(@fio,@phone,@password,@isAdmin)";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.Add(new SQLiteParameter("@fio", fio));
                command.Parameters.Add(new SQLiteParameter("@phone", phone));
                command.Parameters.Add(new SQLiteParameter("@password", password));
                command.Parameters.Add(new SQLiteParameter("@isAdmin", isAdmin));
                command.ExecuteNonQuery();
            }
            return "Ваша учетная запись зарегистрирована успешно";

        }

        public List<string[]> GetUsers()
        {
            {
                List<string[]> data = new List<string[]>();
                SQLiteConnection connection = createConnection();
                connection.Open();
                string query = "select * from Users";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[5]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }
                reader.Close();
                connection.Close();
                return data;
            }
        }

        public List<string[]> GetServices()
        {
            {
                List<string[]> data = new List<string[]>();
                SQLiteConnection connection = createConnection();
                connection.Open();
                string query = "select * from Services";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[3]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();

                }
                reader.Close();
                connection.Close();
                return data;
            }
        }

        public List<string[]> GetAnalytics()
        {
            {
                List<string[]> data = new List<string[]>();
                SQLiteConnection connection = createConnection();
                connection.Open();
                string query = "select * from Analytics";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();

                }
                reader.Close();
                connection.Close();
                return data;
            }
        }



    }
}
