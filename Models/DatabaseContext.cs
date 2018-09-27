namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			System.Data.Entity.Database
				.SetInitializer(new DatabaseContextInitializer());

			//System.Data.Entity.Database.SetInitializer
			//	(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());
		}

		public DatabaseContext() : base()
		{
		}

		public System.Data.Entity.DbSet<Person> People { get; set; }
	}
}

//internal class DatabaseContextInitializer :
//	System.Data.Entity.DropCreateDatabaseAlways<DatabaseContext>
//{
//	public DatabaseContextInitializer()
//	{
//	}
//}

//internal class DatabaseContextInitializer :
//	System.Data.Entity.CreateDatabaseIfNotExists<DatabaseContext>
//{
//	public DatabaseContextInitializer()
//	{
//	}
//}

//internal class DatabaseContextInitializer :
//	System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
//{
//	public DatabaseContextInitializer()
//	{
//	}
//}
