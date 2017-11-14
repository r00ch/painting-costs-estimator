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
		/// Type of a paint thet the medium is used for.
		/// </summary>
		public string PaintType { get; set; }
		/// <summary>
		/// Name of a type of a medium (like terpentine or linseed oil.)
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Medium price per milliliter in PLN.
		/// </summary>
		public decimal Price { get; set; }
	}
}
