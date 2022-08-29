using SalesSystemMVC.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesSystemMVC.Models
{
	public class SalesRecord
	{
		public int ID { get; set; }

		[DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
		public DateTime Date { get; set; }

		[DisplayFormat(DataFormatString ="{0:F2}")]
		public double Amount { get; set; }
		public SalesStatus SalesStatus { get; set; }
		public Seller Seller { get; set; }

		public SalesRecord()
		{

		}

		public SalesRecord(int iD, DateTime date, double amount, SalesStatus salesStatus, Seller seller)
		{
			ID = iD;
			Date = date;
			Amount = amount;
			SalesStatus = salesStatus;
			Seller = seller;
		}
	}
}
