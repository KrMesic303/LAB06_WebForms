using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebForms.DatabaseHelpers
{
    public static class DatabaseHelper
    {
        
        public static bool CheckUserInDbExists(string username)
        {
            using (SqlConnection _connection =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsConnectionString"].ToString()))
            {
                _connection.Open();
                using (SqlCommand _command =
                       new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName = @username", _connection))
                {
                    _command.Parameters.AddWithValue("@username", username);
                    int count = (int)_command.ExecuteScalar();
                    _connection.Close();

                    if (count > 0)
                    {
                        return true;
                    }
                    return false;
                }

            }

        }

        public static bool CheckUsernamePassword(string username, string password)
        {
            using (SqlConnection _connection =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsConnectionString"].ToString()))
            {
                _connection.Open();
                using (SqlCommand _command =
                       new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName = @username and Password = @password", _connection))
                {
                    _command.Parameters.AddWithValue("@username", username);
                    _command.Parameters.AddWithValue("@password", password);
                    int count = (int)_command.ExecuteScalar();
                    _connection.Close();

                    if (count > 0)
                    {
                        return true;
                    }
                    return false;
                }

            }

        }

        public static bool AddUserToDb(string username, string password, string fullName = null)
        {
            try
            {
                using (SqlConnection _connection =
                       new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsConnectionString"].ToString()))
                {
                    _connection.Open();
                    using (SqlCommand _command = new SqlCommand(
                               "INSERT INTO Users(UserName, Password, FullName)VALUES(@name,@password, @fullname)", _connection))
                    {
                        _command.Parameters.AddWithValue("@name", username);
                        _command.Parameters.AddWithValue("@password", password);
                        _command.Parameters.AddWithValue("@fullname", fullName);
                        _command.ExecuteNonQuery();
                        _connection.Close();
                    }

                }

                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public static bool AddArticleToDb(string name, string about)
        {
            try
            {
                using (SqlConnection _connection =
                       new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsConnectionString"].ToString()))
                {
                    _connection.Open();
                    using (SqlCommand _command = new SqlCommand(
                               "INSERT INTO Products(Name, Description) VALUES(@name,@about)", _connection))
                    {
                        _command.Parameters.AddWithValue("@name", name);
                        _command.Parameters.AddWithValue("@about", about);
                        _command.ExecuteNonQuery();
                        _connection.Close();
                    }

                }

                return true;
            }
            catch
            {
                return false;
            }

        }

        public static void LoadArticles(GridView gvArticles)
        {
            using (SqlConnection _connection =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsConnectionString"].ToString()))
            {
                _connection.Open();
                using (SqlCommand _command = new SqlCommand(
                           "SELECT * FROM Products", _connection))
                {

                    gvArticles.DataSource = _command.ExecuteReader();
                    gvArticles.DataBind();

                    _connection.Close();
                }
            }
        }


    }
}