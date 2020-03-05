using System.Runtime.Serialization;

namespace WcfService1
{
  public class UserDetails
  {
    string name = string.Empty;
    string age = string.Empty;
    string address = string.Empty;

    [DataMember]

    public string Name
    {
      get { return name; }
      set { name = value; }
    }
    [DataMember]
    public string Age
    {
      get { return age; }
      set { age = value; }
    }

    [DataMember]
    public string Address
    {
      get { return address; }
      set { address = value; }
    }
  }
}