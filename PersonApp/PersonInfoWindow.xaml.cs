using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PersonApp
{
    /// <summary>
    /// Interaction logic for PersonInfoWindow.xaml
    /// </summary>
    public partial class PersonInfoWindow : Window
    {
        public PersonInfoWindow(Person person)
        {
            InitializeComponent();
            DataContext = new PersonInfoViewModel(person);

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
    }
}
