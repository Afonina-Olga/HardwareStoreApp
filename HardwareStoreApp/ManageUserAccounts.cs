using HardwareStoreApp.Services;
using System.Windows.Forms;

namespace HardwareStoreApp
{
	public partial class ManageUserAccounts : Form
	{
		private readonly IAuthenticationService _service;

		public ManageUserAccounts(IAuthenticationService service)
		{
			_service = service;
			InitializeComponent();
		}

		private void BtnAdd_Click(object sender, System.EventArgs e)
		{

		}

		private void BtnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
