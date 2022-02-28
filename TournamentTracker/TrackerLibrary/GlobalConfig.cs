using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibary
{
    public static class GlobalConfig
    {
        // The - {get; private set;} - says that only methods that are inside this class can change the value of connections
        // but everyone can read can read the value of connections
        public static List<IDataConnection> Connections { get; private set;}  
        
        // This method saying which connections to set up 
        public static void InitializeConnections(bool database, bool textFiles)
        {
            Connections = new List<IDataConnection>();

            if(database)
            {
                // TODO - set up SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if(textFiles)
            {
                // TODO  - create text connection
                TextConnection textConnection = new TextConnection();
                Connections.Add(textConnection);
            }
        }
    }
}
