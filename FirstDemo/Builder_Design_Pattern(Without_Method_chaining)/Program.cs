using Builder_Design_Pattern_Without_Method_chaining_;

ConnectionStringBuilder connectionString = new ConnectionStringBuilder("LocalHost", ".net-b9");

connectionString.GetCredential("NKJ", "@13$");

connectionString.UsePort(224);

connectionString.UseTrustedConnection();

connectionString.UseMultipleActiveResulrSets();

Console.WriteLine(connectionString.GetConnectionString());