# DbConnect
A project to demonstrate the potential of providing database templates in an open-source solution.

### Installation

To get started, 
1. Clone or download this project to your local machine.
2. To the DbConnect.App folder, add a new folder called *secrets*
3. Within the *secrets* folder, add a new config file called *connection.config*
4. Within *connection.config* pase the following lines **(NOTE: [Absolute Path To Project] must be replaced with ab actual path)**

```csharp
<connectionStrings>
  <add name="MyDbEntities"
  connectionString="metadata=res://*/DbModels.csdl|res://*/DbModels.ssdl|res://*/DbModels.msl;provider=System.Data.SqlClient; provider connection string=&quot;data source (LocalDB)\MSSQLLocalDB;attachdbfilename=[Absolute Path To Project]\DbConnect.App\App_Data\MyDb.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
</connectionStrings>

```
