using Builder_Design_Pattern_with_method_chaining_;

string connectionString = new ConnectionStringBuilder("LocalHost", ".net").
                                            GetCredentials("jk", "123@#$%TT").
                                            GetPort(284).
                                           // GetTrustedConnection().
                                            GetMultipleActiveResultSets().
                                            GetConectionString();


Console.WriteLine(connectionString);