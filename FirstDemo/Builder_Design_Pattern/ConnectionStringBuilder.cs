using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    public class ConnectionStringBuilder
    {
        private string _username;
        private string _password;
        private string _host;
        private int? _port;
        private string _database;
        private bool _trustedConnection;
        private bool _multipleActiveRecords;


        public ConnectionStringBuilder(string host, string database)
        {
            _host = host;
            _database = database;
        }

        public void SetCredentials(string username, string password)
        {
            _username = username;
            _password = password;
        }
        

        public void UseTustedConnection()
        {
            _trustedConnection = true;
        }

        public void UseMultipleActiveRecordSet()
        {
            _multipleActiveRecords = true;
        }

        public void UsePort(int port)
        {
            _port = port;
        }

        public string GetConnectionString()
        {
            string port = _port.HasValue ? "," + _port : "";


            string credentials;
            if (!_trustedConnection)
            {
                credentials = $"User Id = {_username}; Password = {_password};"; 
            }
            else
            {
                credentials = "Trusted_Connection=True;";
            }


            string activeRecordSet;
            if (_multipleActiveRecords)
            {
                activeRecordSet = "MultipleActiveResultSets=true;";
            }
            else
            {
                activeRecordSet = "";  //string.Empty
            }


            return $"Server={_host}{port};Database={_database};{credentials}{activeRecordSet}";
        }

    }
}
