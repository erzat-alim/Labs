using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ALimbekov_DKIP481_3_LR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement e1 in GridRoot.Children)
            {
                if (e1 is Button)
                {
                    ((Button)e1).Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = ((Button)e.OriginalSource).Content.ToString(); 
            switch (str)
            {
                case "=":
                    {
                        TextLabel.Text = new DataTable().Compute(TextLabel.Text, null).ToString();
                        break;
                    }
                case "AC":
                    {
                        TextLabel.Text = "";
                        break;
                    }
                case "-/+":
                    {
                        TextLabel.Text = "-(" + TextLabel.Text + ")";
                        break;
                    }
                case "1/x":
                    {
                        TextLabel.Text = "1/(" + TextLabel.Text + ")";
                        break;
                    }
                default:
                    {
                        TextLabel.Text += str;
                        break;
                    }
            }
        }
    }
}