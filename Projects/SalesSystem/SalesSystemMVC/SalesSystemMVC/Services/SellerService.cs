
using SalesSystemMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesSystemMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesSystemMVC.Services
{
	public class SellerService
	{

		private readonly SalesSystemMVCContext _context;

		public SellerService(SalesSystemMVCContext context)
		{
			_context = context;
		}

		public List<Seller> FindAll()
		{
			return _context.Seller.ToList();
		}

		public void Insert (Seller seller)
		{
			_context.Add(seller);
			_context.SaveChanges();
		}

		public Seller FindById(int id)
		{
			return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.ID == id);
		}

		public void Remove(int id)
		{
			var obj = _context.Seller.Find(id);

			_context.Seller.Remove(obj);
			_context.SaveChanges();

		}

	}
}
