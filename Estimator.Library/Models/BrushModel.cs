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
		/// Shape of a brush tip.
		/// </summary>
		public string Shape { get; set; }
		/// <summary>
		/// Type of material that brush tip is made of.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Brush tip size in millimeters (standard industry scale).
		/// </summary>
		public int Size { get; set; }
		/// <summary>
		/// Price of a single brush in PLN.
		/// </summary>
		public decimal Price { get; set; }
	}
}
