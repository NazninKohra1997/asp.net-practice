using Builder_Design_Pattern;

ConnectionStringBuilder builder = new ConnectionStringBuilder("LocalHost", ".net");

builder.SetCredentials("Jk", "koh12@");
builder.UseMultipleActiveRecordSet();
builder.UsePort(486);
builder.UseTustedConnection();

Console.WriteLine(builder.GetConnectionString());