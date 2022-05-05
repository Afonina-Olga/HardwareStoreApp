using HardwareStoreApp.Models;
using HardwareStoreApp.Repositories;
using HardwareStoreApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStoreApp
{
	public partial class ReportForm : Form
	{
		private readonly IProductService _productService;
		private readonly ISaleRepository _saleRepository;

		public ReportForm(IProductService productService, ISaleRepository saleRepository)
		{
			_productService = productService;
			_saleRepository = saleRepository;
			InitializeComponent();
		}

		private async void ReportForm_Load(object sender, EventArgs e)
		{
			var stores = await _productService.GetStores();
			FormHelper.RefreshComboboxDataSource(stores, bsStores, cbStore, "Name");
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private async void BtnCreate_Click(object sender, EventArgs e)
		{
			var store = cbStore.SelectedItem;
			var result = store != null ?
				await _saleRepository.GetByStore(dtStart.Value, dtEnd.Value, ((Store)store).Id)
				: await _saleRepository.Get(dtStart.Value, dtEnd.Value);
			txtReport.Text = CreateReport(result);
		}

		private string CreateReport(IEnumerable<Sale> sales)
		{
			var sb = new StringBuilder();
			var header = $"Отчет за период с {dtStart.Value.ToShortDateString()} по {dtEnd.Value.ToShortDateString()}";
			sb.AppendLine(header);
			sb.AppendLine("-------------------------");

			if (sales.Any())
			{
				var stores = sales.Select(_ => _.Store).Distinct();

				foreach (var store in stores)
				{
					sb.AppendLine(store.Name);
					sb.AppendLine(store.Address.ToString());
					sb.AppendLine("-------------------------");

					foreach (var sale in sales.Where(_=>_.Store.Address.ToString() == store.Address.ToString()))
					{
						sb.Append(sale.Product.Name);
						sb.Append(" - ");
						sb.Append(sale.Count);
						sb.Append(" шт. ");
						sb.Append("по ");
						sb.Append(sale.Price);
						sb.Append(" руб. = ");
						sb.Append(sale.Price * sale.Count);
						sb.Append(" руб.\n");
					}
					sb.AppendLine("-------------------------");
				}
			}
			else
			{
				sb.AppendLine("Ни один товар не продан");
			}
			sb.Append($"ИТОГО: {sales.Sum(_ => _.Price * _.Count)} руб.");

			return sb.ToString();
		}
	}
}
