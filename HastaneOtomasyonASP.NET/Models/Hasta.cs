using System.ComponentModel.DataAnnotations;

namespace HastaneOtomasyonASP.NET.Models
{
	public class Hasta
	{

		public int Id;
		[Required]
		public string Ad { get; set; }
		[Required]
		public string Soyad { get; set; }
		 
		
	}
}
