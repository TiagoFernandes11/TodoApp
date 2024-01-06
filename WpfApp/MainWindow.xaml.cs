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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTodoButton_Click(object sender, RoutedEventArgs e)
        {
            string todoInput = TodoInput.Text;

            if(!string.IsNullOrEmpty(todoInput))
            {
                TextBlock todoItem = new TextBlock {
                    Text = todoInput,
                    Margin = new Thickness(10),
                    Foreground = new SolidColorBrush(Colors.Black)
                };
                TodoList.Children.Add(todoItem);
                TodoInput.Clear();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
    }
}