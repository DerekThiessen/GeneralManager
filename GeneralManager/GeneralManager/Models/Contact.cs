using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace GeneralManager.Models
{
	public class Contact
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName
		{
			get
			{
				return LastName + ", " + FirstName;
			}
		}
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Email { get; set; }
		public string Twitter { get; set; }
		public string Self
		{
			get { return string.Format(CultureInfo.CurrentCulture, "api/contact/{0}", this.Id); }
		}
	}
}