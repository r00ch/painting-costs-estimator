using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator.Library.Models
{
	public class MediumModel
	{
		/// <summary>
		/// Represents a type of a paint thet the medium is used for.
		/// </summary>
		public string PaintType { get; set; }
		/// <summary>
		/// Represents name of a type of a medium (like terpentine or linseed oil.)
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Represents a price per mililiter in PLN.
		/// </summary>
		public decimal Price { get; set; }
	}
}
