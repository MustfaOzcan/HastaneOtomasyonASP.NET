using HastaneOtomasyonASP.NET.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace HastaneOtomasyonASP.NET.Utility
{
	public class UygulamaDbContext:DbContext
	{
		public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options): base(options) { }

		public DbSet<Doktor> Doktorlar { get; set; }//olusturulan tablonun adi



	}
}
