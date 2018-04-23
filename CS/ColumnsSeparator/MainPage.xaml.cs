using System.Collections;
using System.Collections.Generic;
using System.Windows.Controls;

namespace ColumnsSeparator
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();
            DXVisualizer.DXVisualTreeVisualizer.Show();
		}
	}

	public class DataContainer
	{
		private List<DataRow> _data;


		public DataContainer()
		{
			_data = new List<DataRow>();

			for (int i = 0; i < 10; i++)
			{
				 _data.Add(new DataRow(){Name = "String " + i});
			}
		}

		public IList Data
		{
			get { return _data; }
		}
	}

	public class DataRow
	{
		public string Name { get; set; }
	}
}
