using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace GeneralManager.Models
{
	public class Contact
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "First name is required")]
		public string FirstName { get; set; }
		[Required(ErrorMessage = "Last name is required")]
		public string LastName { get; set; }
		public string FullName
		{ 
			get
			{
				return LastName + ", " + FirstName;
			}
		}
		[Required(ErrorMessage="Address is required")]
		public string Address { get; set; }
		[Required(ErrorMessage="City is required")]
		public string City { get; set; }
		[Required(ErrorMessage="State is required")]
		public string State { get; set; }
		[Required(ErrorMessage="Zip is required")]
		public string Zip { get; set; }
		public string MailingAddress
		{
			get
			{
				return Address + " " + City + ", " + State + " " + Zip;
			}
		}
		[Required(ErrorMessage="Email is required")]
		public string Email { get; set; }
		[Required(ErrorMessage="Phone is required")]
		public string Phone { get; set; }
		public string Self
		{
			get { return string.Format(CultureInfo.CurrentCulture, "api/contact/{0}", this.Id); }
		}
	}
}