using Npgsql;

namespace WcfService1
{
  public class Connection
  {
    public const string Connection_string = "Server=127.0.0.1; Port=5432; User Id = postgres; Password=admin; Database=TestDB";
    NpgsqlConnection con;
    public void OpenConnection()
    {
      con = new NpgsqlConnection(Connection_string);
      con.Open();
    }

    public void CloseConnection()
    {
      con.Close();
    }


    public int ExecuteQueries(string Query_)
    {
      NpgsqlCommand cmd = new NpgsqlCommand(Query_, con);
      //NpgsqlCommand cmd = new NpgsqlCommand(@"Select * from public.""Employee""", con);
     int result =  cmd.ExecuteNonQuery();
      return result;
    }


    public NpgsqlDataReader DataReader(string Query_)
    {
      NpgsqlCommand cmd = new NpgsqlCommand(Query_, con);
      NpgsqlDataReader dr = cmd.ExecuteReader();
      return dr;
    }
  }
}