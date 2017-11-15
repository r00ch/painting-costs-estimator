using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estimator.Library.Models;

namespace Estimator.Library
{
	public class SqlConnector : IDataConnection
	{
		// TODO - Make the CreateBoardType mathod actually save to the database.
		/// <summary>
		/// Saves new board to the database
		/// </summary>
		/// <param name="model">The board information.</param>
		/// <returns>The board information that includes the unique identifier.</returns>
		public BoardModel CreateBoardType(BoardModel model)
		{
			model.Id = 1;
			return model;
		}
	}
}
