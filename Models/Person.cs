namespace Models
{
	public class Person : object
	{
		public Person() : base()
		{
			Id = System.Guid.NewGuid();

			FullName = new ComplexTypes.FullName();
		}

		// **********
		public System.Guid Id { get; set; }
		// **********

		// **********
		public string Address { get; set; }
		// **********

		// **********
		public string NationalCode { get; set; }
		// **********

		// **********
		// **********
		// **********
		public ComplexTypes.FullName FullName { get; set; }
		// **********

		// **********
		public string DisplayFullName
		{
			get
			{
				string result = FullName.ToString();

				if (result == string.Empty)
				{
					result = "[UNDEFINED]";
				}

				return result;
			}
		}
		// **********
		// **********
		// **********
	}
}
