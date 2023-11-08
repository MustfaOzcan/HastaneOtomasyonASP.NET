using HastaneOtomasyonASP.NET.Models;
using HastaneOtomasyonASP.NET.Utility;
using Microsoft.AspNetCore.Mvc;

namespace HastaneOtomasyonASP.NET.Controllers
{
	public class DoktorController : Controller
	{
		private readonly UygulamaDbContext _uygulamaDbcontext;

		public DoktorController(UygulamaDbContext context)
		{

			_uygulamaDbcontext = context;
		}

		public IActionResult Index()
		{
			List<Doktor>objDoktorList=_uygulamaDbcontext.Doktorlar.ToList();//veritabanına _uygulamadbcontex ile baglanıp doktorlar listesi alıyoruz.
			return View(objDoktorList);//view'ev Dokorlar Listesi gönderiyoruz.
		}

		public IActionResult Ekle()
		{
			return View();
		}

		//formdan verileri http post ile alıyoruz ve buraya veriler geliyor
		//veriler Doktor turunden nesne
		[HttpPost]
		public IActionResult Ekle(Doktor doktor)
		{
			if (ModelState.IsValid)
			{
				_uygulamaDbcontext.Doktorlar.Add(doktor);//ekleme
				_uygulamaDbcontext.SaveChanges();//kaydetme
				return RedirectToAction("Index");//Listele geri donuyor.

			}
			return View();
			
		}
	}
}
