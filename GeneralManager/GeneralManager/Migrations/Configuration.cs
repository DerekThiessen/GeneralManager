namespace GeneralManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using GeneralManager.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<GeneralManager.Models.GeneralManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GeneralManager.Models.GeneralManagerContext";
        }

        protected override void Seed(GeneralManager.Models.GeneralManagerContext context)
        {
			context.Contacts.AddOrUpdate(p => p.Email,
				   new Contact
				   {
					   FirstName = "Debra",
					   LastName = "Garcia",
					   Address = "1234 Main St",
					   City = "Redmond",
					   State = "WA",
					   Zip = "10999",
					   Email = "debra@example.com",
					   Twitter = "debra_example"
				   },
					new Contact
					{
						FirstName = "Thorsten",
						LastName = "Weinrich",
						Address = "5678 1st Ave W",
						City = "Redmond",
						State = "WA",
						Zip = "10999",
						Email = "thorsten@example.com",
						Twitter = "thorsten_example"
					},
					new Contact
					{
						FirstName = "Yuhong",
						LastName = "Li",
						Address = "9012 State st",
						City = "Redmond",
						State = "WA",
						Zip = "10999",
						Email = "yuhong@example.com",
						Twitter = "yuhong_example"
					},
					new Contact
					{
						FirstName = "Jon",
						LastName = "Orton",
						Address = "3456 Maple St",
						City = "Redmond",
						State = "WA",
						Zip = "10999",
						Email = "jon@example.com",
						Twitter = "jon_example"
					},
					new Contact
					{
						FirstName = "Diliana",
						LastName = "Alexieva-Bosseva",
						Address = "7890 2nd Ave E",
						City = "Redmond",
						State = "WA",
						Zip = "10999",
						Email = "diliana@example.com",
						Twitter = "diliana_example"
					}
				);
		}
    }
}
