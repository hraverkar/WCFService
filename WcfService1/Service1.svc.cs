using System;
using System.Collections.Generic;

namespace WcfService1
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
  public class Service1 : IService1
  {
    public string GetData(int value)
    {
      return string.Format("You entered: {0}", value);
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
      if (composite == null)
      {
        throw new ArgumentNullException("composite");
      }
      if (composite.BoolValue)
      {
        composite.StringValue += "Suffix";
      }
      return composite;
    }

    public string InsertUserDetails(UserDetails userInfo)
    {
      string message =  string.Empty;
      Connection connection = new Connection();
      connection.OpenConnection();
      var query = @"INSERT INTO public.""Employee""(name, address, age) VALUES ('" + userInfo.Name + "','" +userInfo.Address + "','" + userInfo.Age + "')";
      int result = connection.ExecuteQueries(query);
      if (result == 1)
      {
        message = userInfo.Name + " Details inserted successfully";
      }
      else
      {
        message = userInfo.Name + " Details not inserted successfully";
      }
      connection.CloseConnection();
      return message;
    }
  }
}
