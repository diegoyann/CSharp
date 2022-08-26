
using SalesSystemMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesSystemMVC.Models;
using Microsoft.EntityFrameworkCore;
using SalesSystemMVC.Services.Exceptions;

namespace SalesSystemMVC.Services
{
	public class SellerService
	{

		private readonly SalesSystemMVCContext _context;

		public SellerService(SalesSystemMVCContext context)
		{
			_context = context;
		}

		public async Task<List<Seller>> FindAllAsync()
		{
			return await _context.Seller.ToListAsync();
		}

		public async Task InsertAsync (Seller seller)
		{
			_context.Add(seller);
			_context.SaveChangesAsync();
		}

		public async Task <Seller> FindByIdAsync(int id)
		{
			return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.ID == id);
		}

		public async Task RemoveAsync(int id)
		{
			var obj = await _context.Seller.FindAsync(id);

			_context.Seller.Remove(obj);
			await _context.SaveChangesAsync();

		}
		public async Task UpdateAsync (Seller seller)
		{
			bool hasAny = await _context.Seller.AnyAsync(x => x.ID == seller.ID);
			if (!hasAny)
			{
				throw new NotFoundException("ID not found");
			}

			try
			{
				_context.Update(seller);
				await _context.SaveChangesAsync();
			}
			
			catch (DbConcurrencyException e)
			{
				throw new DbConcurrencyException(e.Message);
			}
		}

	}
}
