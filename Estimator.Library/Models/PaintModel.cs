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
		/// Represents a type of paint binder (like oil or acrylic)
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Represents a price per mililiter in PLN.
		/// </summary>
		public decimal Price { get; set; }
	}
}
