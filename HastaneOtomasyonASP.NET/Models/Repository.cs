//using HastaneOtomasyonASP.NET.Utility;
//using Microsoft.AspNetCore.DataProtection.Repositories;
//using System.Data.Entity;
//using System.Linq.Expressions;

//namespace HastaneOtomasyonASP.NET.Models
//{
//	public class Repository<T> : IRepository<T> where T : class
//	{
//		private UygulamaDbContext _uygulamaDbContext;//nesnemiz
//		internal DbSet<T> dbSet;
//		public Repository(UygulamaDbContext uygulamaDbContext) {

//			this._uygulamaDbContext = uygulamaDbContext;
//			this.dbSet = _uygulamaDbContext.Set<T>();
//			_uygulamaDbContext

//		}

//		public void Ekle(T entity)
//		{
			
//		}

//		public T Get(Expression<Func<T, bool>> filtre, string? includeProps = null)
//		{
			
//		}

//		public IEnumerable<T> GetAll(string includeProps = null)
//		{
			
//		}

//		public void Sil(T entity)
//		{
			
//		}

//		public void SilAralik(IEnumerable<T> entities)
//		{
			
//		}
//	}
//}
