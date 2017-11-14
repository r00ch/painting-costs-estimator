using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator.Library.Models
{
	public class PaintModel
	{
		/// <summary>
		/// Type of paint (like oil or acrylic)
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Average paint price per milliliter in PLN.
		/// </summary>
		public decimal Price { get; set; }
	}
}
