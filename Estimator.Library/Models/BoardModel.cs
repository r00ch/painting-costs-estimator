using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator.Library.Models
{
	public class BoardModel
	{
		/// <summary>
		/// The unique identifier for the board type.
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Type of painting board, like canvas or wooden panel.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Conatins list of all avaiable sizes.
		/// </summary>
		public List<Dimension> SizeList { get; set; } = new List<Dimension>();
		/// <summary>
		/// Board price per 1 square centimeter, given in PLN.
		/// </summary>
		public decimal Price { get; set; }

		public BoardModel() { }
		public BoardModel(string typeName, string price)
		{
			Type = typeName;

			decimal priceValue = 0;
			decimal.TryParse(price, out priceValue);
			Price = priceValue;
		}
	}

}
