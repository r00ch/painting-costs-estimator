using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator.Library.Models
{
	 public class BrushModel
	{
		/// <summary>
		/// Represents shape of a brush tip.
		/// </summary>
		public string Shape { get; set; }
		/// <summary>
		/// Represents type of material that brush is made of.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Represents the brush tip size in milimeters (standard industry scale).
		/// </summary>
		public int Size { get; set; }
		/// <summary>
		/// Represents price of a single brush in PLN.
		/// </summary>
		public decimal Price { get; set; }
	}
}
