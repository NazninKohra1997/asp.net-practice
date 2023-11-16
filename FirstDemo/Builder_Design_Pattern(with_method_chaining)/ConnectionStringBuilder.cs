using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern_with_method_chaining_
{
    public class ConnectionStringBuilder
    {
        private string _username;
        private string _password;
        private string _host;
        private int? _port;
        private string _database;
        private bool _trustedConnection;
        private bool _multipleActiveResultSets;

        public ConnectionStringBuilder(string host, string database)
        {
            _host = host;
            _database = database;
        }
        public ConnectionStringBuilder GetCredentials(string username, string password)
        {
            _username = username;
            _password = password;
            return this;
        }

        public ConnectionStringBuilder GetPort(int port)
        {
            _port = port;
            return this;
        }

        public ConnectionStringBuilder GetTrustedConnection()
        {
            _trustedConnection = true;
            return this;
        }

        public ConnectionStringBuilder GetMultipleActiveResultSets()
        {
            _multipleActiveResultSets = true;
            return this;
        }


        public string GetConectionString()
        {
            string credentials;
            if (_trustedConnection)
            {
                credentials = " Trusted_Connection=True;";
            }
            else
            {
                credentials = $" User Id={_username}; Password={_password};";
            }

            string activeResult;
            if (_multipleActiveResultSets) {
                activeResult = " MultipleActiveResultSets=true;";
            }
            else
            {
                activeResult = "";
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
            return $"Server={_host}{port}; Database={_database};{credentials}{activeResult}";
        }
    }
}
