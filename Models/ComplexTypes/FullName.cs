namespace Models.ComplexTypes
{
	[System.ComponentModel.DataAnnotations.Schema.ComplexType]
	public class FullName : object
	{
		public FullName() : base()
		{
		}

		// **********
		public string FirstName { get; set; }
		// **********

		// **********
		public string MiddleName { get; set; }
		// **********

		// **********
		public string LastName { get; set; }
		// **********

		// **********
		public override string ToString()
		{
			string result = string.Empty;

			if (string.IsNullOrWhiteSpace(FirstName) == false)
			{
				result = FirstName.Trim();
			}

			if (string.IsNullOrWhiteSpace(MiddleName) == false)
			{
				result =
					$"{ result } { MiddleName.Trim() }".Trim();
			}

			if (string.IsNullOrWhiteSpace(LastName) == false)
			{
				result =
					$"{ result } { LastName.Trim() }".Trim();
			}

			return result;
		}
		// **********
	}
}
