using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator.Library.Models
{
	public class VernixModel
	{
		/// <summary>
		/// Represents what paint type is given vernix made for.
		/// </summary>
		public string PaintType { get; set; }
		/// <summary>
		/// Vernix type based on ingredients.
		/// </summary>
		public string VernixType { get; set; }
		/// <summary>
		/// Represents the level of glossiness of a dried vernix.
		/// </summary>
		public string Gloss { get; set; }
		/// <summary>
		/// Vernix price per milliliter in PLN.
		/// </summary>
		public decimal Price { get; set; }
	}
}
