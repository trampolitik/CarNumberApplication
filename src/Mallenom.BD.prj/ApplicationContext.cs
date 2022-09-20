using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Mallenom.BD
{
	public class ApplicationContext: DbContext
	{
		public DbSet<Cars> Cars { get; set; }
		public ApplicationContext()
		{
			Database.EnsureCreated();

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if(!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database=CarDB; Trusted_Connection =True");
			}
			
		}
	}
}


