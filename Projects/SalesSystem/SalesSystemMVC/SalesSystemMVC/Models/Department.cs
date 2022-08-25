﻿using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesSystemMVC.Models
{
	public class Department
	{

		public int ID { get; set; }
		public string Name { get; set; }

		public ICollection<Seller> Sellers { get; set; } = new List<Seller>();


		public Department()
		{

		}

		public Department(int iD, string name)
		{
			ID = iD;
			Name = name;
			
		}

		public void AddSeller(Seller seller)
		{
			Sellers.Add(seller);
		}

		public void RemoveSeller(Seller seller)
		{
			Sellers.Remove(seller);
		}

		public double TotalSales(DateTime initial, DateTime final)
		{
			return Sellers.Sum(seller => seller.TotalSales(initial, final));
		}

	}


	
}

