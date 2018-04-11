# DbConnect
A project to demonstrate the potential of providing database templates in an open-source solution.

This project accompanies my [blog post](https://medium.com/@kevin.michael.horan/distributed-video-streaming-with-python-and-kafka-551de69fe1dd), Shareable Database with Ms SQL Server & .Net Entity Framework.

### Installation

To get started, 
1. Clone or download this project to your local machine.
2. To the DbConnect.App folder, add a new folder called *secrets*
3. Within the *secrets* folder, add a new config file called *connection.config*
4. Within *connection.config* paste the following lines **(NOTE: [Absolute Path To Project] must be replaced with an actual path)**

```xml
<connectionStrings>
  <add name="MyDb_20180408"
  connectionString="metadata=res://*/DbModels.csdl|res://*/DbModels.ssdl|res://*/DbModels.msl;provider=System.Data.SqlClient; provider connection string=&quot;data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=[Absolute Path To Project]\DbConnect.App\App_Data\MyDb.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" 
  providerName="System.Data.EntityClient" />
</connectionStrings>
```
5. In the *connecction.config* Properties menu, change the **Copy to Output Directory** value from **Do not copy** to **Copy always**.

The file *secret/connection.config* is specified in *DbConnect.App/App.config* as the relative path to the connection strings config file.

This configuration will spin up a DB connection to your LocalDB instance (a feature of SQL Server Express). To switch this out with another database instance, update the **dataSource** attrribute to point to your database rather than **(LocalDB)\MSSQLLocalDB**
