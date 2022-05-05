using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HardwareStoreApp.Models;

namespace HardwareStoreApp
{
	public static class FormHelper
	{
		public static void RefreshComboboxDataSource<T>(
			IEnumerable<T> items,
			BindingSource source,
			ComboBox combobox,
			string valueMember = null,
			bool setSelected = false)
			where T : DomainObject
		{
			if (items.Any())
			{
				source.DataSource = items.Distinct();
				source.ResetBindings(false);
				combobox.DataSource = source;
				combobox.ValueMember = valueMember;
				if (setSelected)
					combobox.SelectedIndex = 0;
				else
					combobox.SelectedItem = null;
			}
		}

		public static void SetColumnSettings(DataGridViewColumn column, string name)
		{
			column.HeaderText = name;
			column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}
	}
}
