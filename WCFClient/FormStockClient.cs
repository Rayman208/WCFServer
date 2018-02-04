using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ServiceModel;
using StockLibrary;

namespace WCFClient
{
    public partial class FormStockClient : Form
    {
        IStock stockService;
        

        public FormStockClient()
        {
            InitializeComponent();
        }

        private void FormStockClient_Load(object sender, EventArgs e)
        {
            //ChannelFactory<IStock> iStockFactory = new ChannelFactory<IStock>
            //       (
            //       new BasicHttpBinding(),
            //       new EndpointAddress(new Uri("http://localhost:53284/Stock"))
            //       );
            ChannelFactory<IStock> iStockFactory = new ChannelFactory<IStock>("StockConfigName");
            stockService = iStockFactory.CreateChannel();
            MessageBox.Show("Соединение с сервером установлено!");
        }

        private async void buttonGetCurrentRubleCourse_Click(object sender, EventArgs e)
        {
            //textBoxRubleCourse.Text = stockService.GetCurrentRubleCourse().ToString();

            textBoxRubleCourse.Text = await Task<string>.Factory.StartNew(() => stockService.GetCurrentRubleCourse().ToString());
        }
    }
}
