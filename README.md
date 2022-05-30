# JwtApiAuthenticationRepo

## Launching your copy
1. Add file appsettings.json to the project directory 
2. paste this snippet below in the file
3. the JWT Keys are example we can put them in other place for more security

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JwtApiAppData;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "JWT": {
    "Key": "icmbKwJcY5+rKOmwG1f8zOomQYzJnI1E3LdfC4hWkno=",
    "Issuer": "SecureApi",
    "Audience": "SecureApiUser",
    "DurationInDays": 30
  }
}


```


