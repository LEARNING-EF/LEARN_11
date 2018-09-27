namespace Models
{
	internal class DatabaseContextInitializer :
		System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
	{
		public DatabaseContextInitializer() : base()
		{
		}

		//protected override void Seed(DatabaseContext context)
		//{
		//	base.Seed(context);
		//}

		/// <summary>
		/// اين تابع فقط پس از ايجاد بانک اطلاعاتی فرآخوانی می گردد
		/// در صورتی که بانک اطلاعاتی وجود داشته باشد، اجرا نخواهد شد
		/// </summary>
		protected override void Seed(DatabaseContext databaseContext)
		{
			// دقت داشته باشید که وقتی وارد
			// Seed
			// می‌شویم، معنی آن این است که بانک اطلاعاتی و جداول ایجاد شده‌اند
			// لذا اگر در داخل این تابع به خطایی برخورد نماییم، حواسمان باشد
			// که برای سری بعد، خودمان بانک اطلاعاتی را در ابتدا حذف نماییم

			// اطلاعات پایه

			// اطلاعات تستی

			Person person = null;

			person = new Person();
			databaseContext.People.Add(person);

			person = new Person();
			person.FullName.FirstName = "Ali";
			databaseContext.People.Add(person);

			person = new Person();
			person.FullName.FirstName = "     Mohammad     ";
			databaseContext.People.Add(person);

			person = new Person();
			person.FullName.MiddleName = "     Reza     ";
			databaseContext.People.Add(person);

			person = new Person();
			person.FullName.FirstName = "     Ali     ";
			person.FullName.MiddleName = "     Reza     ";
			databaseContext.People.Add(person);

			person = new Person();
			person.FullName.FirstName = "     Ali     ";
			person.FullName.MiddleName = "     Reza     ";
			person.FullName.LastName = "     Alavi     ";
			databaseContext.People.Add(person);

			// Optional
			databaseContext.SaveChanges();
		}
	}
}
