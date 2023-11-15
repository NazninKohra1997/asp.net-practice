using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern_Without_Method_chaining_
{
    public class ConnectionStringBuilder
    {
        private string _username;
        private string _password;
        private string _host;
        private string _database;
        private int? _port;
        private bool _trustedConnection;
        private bool _multipleActiveResultSets;

        public ConnectionStringBuilder(string host, string database)
        {
            _host = host;
            _database = database;
        }

        public void GetCredential(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public void UsePort(int port)
        {
            _port = port;
        }

        public void UseTrustedConnection()
        {
            _trustedConnection = true;
        }

        public void UseMultipleActiveResulrSets()
        {
            _multipleActiveResultSets = true;
        }

        public string GetConnectionString()
        {
            string credential;
            if(!_trustedConnection)
            {
                credential = $" User Id={_username}; Password={_password};";
            }
            else
            {
                credential = $" Trusted_Connection=True;";
            }


            string multipleResults;
            if(!_multipleActiveResultSets)
            {
                multipleResults = "";
            }
            else
            {
                multipleResults = $" MultipleActiveResultSets=true;";
            }


            string port;
            if (_port.HasValue)
            {
                port = $",{_port}";
            }
            else
            {
                port = "";
            }

            return $"Server={_host}{port}; Database={_database};{credential}{multipleResults}";
        }
    }
}
