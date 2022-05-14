using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileControl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
            datePick.MinimumDate = DateTime.Now;
        }

        private void btn_add_Clicked(object sender, EventArgs e)
        {
            Models.Item item = new Models.Item();
            int id = Convert.ToInt32(ListPage.items.Last().Id) + 1;
            item.Id = id.ToString();
            item.Text = entry_text.Text;
            item.Description = entry_desc.Text;
            item.date = datePick.Date;
            Navigation.PushAsync(new ListPage());
        }
    }
}