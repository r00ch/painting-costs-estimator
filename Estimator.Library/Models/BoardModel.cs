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
		/// Represents the type of board, like canvas or wooden panel.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Conatins list of all avaiable sizes.
		/// </summary>
		public List<Dimension> SizeList { get; set; } = new List<Dimension>();
		/// <summary>
		/// Represents price per 1 square centimeter of a board, given in PLN.
		/// </summary>
		public decimal Price { get; set; }
	}

}
