namespace SingeltonDesignPatternDemo
{
    public class TableServers
    {
        //static because that every instance of the Singleton type will use the same instance
        //readonly because that you can't overwrite this with something else .. once it is assigned it can't be assigned to a new value.
        private static readonly TableServers tableServers = new TableServers();
        private List<string> Servers = new();
        private int NextServer = 0;

        //Private Constructor means that only things inside this  class can instantiate this class
        private TableServers()
        {
            Servers.Add("Yusuf");
            Servers.Add("Ahmed");
            Servers.Add("Ibrahim");
            Servers.Add("Refat");
        }
        // to return the same instance
        public static TableServers GetTableServers()
        {
            return tableServers;
        }
        public string GetTheNextServer()
        {
            string output = Servers[NextServer];
            NextServer += 1;
            if (NextServer >= Servers.Count)
            {
                NextServer = 0;
            }
            return output;
        }
    }
}
