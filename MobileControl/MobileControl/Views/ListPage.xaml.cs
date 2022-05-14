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
    public partial class ListPage : ContentPage
    {
        public static List<Models.Item> items { get; set; }
        public ListPage()
        {
            InitializeComponent();
            items = new List<Models.Item>();
            Models.Item item = new Models.Item();
            for(int i = 1; i < 10; i++)
            {
                item.Id = i.ToString();
                item.Text = "Text" + i.ToString();
                item.Description = "Description" + i.ToString();
                item.date = DateTime.Now.AddDays(i);
                items.Add(item);
            }
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPage());
        }
    }
}