using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace SalesSystemMVC.Models
{
	public class Seller
	{
		public int ID { get; set; }
		
		[Required(ErrorMessage = "{0} Required")]
		[StringLength(60, MinimumLength = 3, ErrorMessage ="{0} size should be between {2} and {1}")]
		public string Name { get; set; }

		[EmailAddress(ErrorMessage =" Enter a valid email")]
		[Required(ErrorMessage = "{0} Required")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required(ErrorMessage = "{0} Required")]
		[Display(Name = "Base Salary")]
		[DisplayFormat(DataFormatString = "{0:F2}")]
		[Range(100.00, 50000.00, ErrorMessage = "{0} must be from {1} to {2}")]
		public double BaseSalary { get; set; }

		[Required(ErrorMessage = "{0} Required")]
		[Display(Name = "Birth Date")]
		[DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
		[DataType(DataType.Date)]
		public DateTime BirthDate { get; set; }
		public Department Department { get; set; }
		public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
		public int DepartmentId { get; set; }

		public Seller()
		{

		}

		public Seller(int iD, string name, string email, DateTime birthDate, double baseSalary, Department department)
		{
			ID = iD;
			Name = name;
			Email = email;
			BirthDate = birthDate;
			BaseSalary = baseSalary;
			Department = department;
		}

		public void AddSales (SalesRecord sr)
		{
			Sales.Add(sr);
		}

		public void RemoveSales(SalesRecord sr)
		{
			Sales.Remove(sr);
		}

		public double TotalSales(DateTime initial, DateTime final)
		{
			return Sales.Where(sr => sr.Date >= initial && sr.Date <= final)
				.Sum(sr => sr.Amount);	
		}
			
	}
}
