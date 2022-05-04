using HardwareStoreApp.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HardwareStoreApp
{
	public class BaseForm : Form
	{
		public void RefreshComboboxDataSource<T>(
			IEnumerable<T> items,
			string valueMember,
			BindingSource source,
			ComboBox combobox)
			where T : DomainObject
		{
			source.DataSource = items;
			source.ResetBindings(false);
			combobox.DataSource = source;
			combobox.ValueMember = valueMember;
			combobox.SelectedIndex = 0;
		}
	}
}
