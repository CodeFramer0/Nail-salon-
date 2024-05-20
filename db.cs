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
                "CREATE TABLE IF NOT EXISTS Users (id  INTEGER NOT NULL UNIQUE  PRIMARY KEY AUTOINCREMENT ,fio TEXT,phone TEXT,password TEXT, isAdmin bool)",
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

       

    }
}
