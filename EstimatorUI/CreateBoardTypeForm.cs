using Estimator.Library.Models;
using Estimator.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstimatorUI
{
	public partial class CreateBoardTypeForm : Form
	{
		public CreateBoardTypeForm()
		{
			InitializeComponent();
		}

		private void createBoardButton_Click(object sender, EventArgs e)
		{
			if (ValidateForm())
			{
				BoardModel model = new BoardModel(
					newBoardNameTextBox.Text,
					newBoardPriceTextBox.Text);

				GlobalConfig.Connection.CreateBoardType(model);

				ClearForm();
			}
			else
			{
				MessageBox.Show("This form has some invalid informations.");
			}
		}

		private bool ValidateForm()
		{
			bool output = true;
			decimal price = 0;

			if (newBoardNameTextBox.Text.Length == 0)
			{
				output = false;
			}
			if (!decimal.TryParse(newBoardPriceTextBox.Text, out price))
			{
				output = false;
			}
			if (price <= 0)
			{
				output = false;
			}

			return output;
		}
		private void ClearForm()
		{
			newBoardNameTextBox.Text = "";
			newBoardPriceTextBox.Text = "0,00";
		}
	}
}
