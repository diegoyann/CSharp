﻿
using SalesSystemMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesSystemMVC.Models;

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
			seller.Department = _context.Department.First();
			_context.Add(seller);
			_context.SaveChanges();
		}

	}
}