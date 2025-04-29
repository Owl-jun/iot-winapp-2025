using MySql.Data.MySqlClient;
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

namespace WpfStudyApp01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // XAML Binding 방식
        public List<KeyValuePair<string, string>> divisionItems { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDivisionFormDatabase();
            this.DataContext = this;    
        }

        private void LoadDivisionFormDatabase()
        {
            divisionItems = new List<KeyValuePair<string, string>>();
            using(MySqlConnection conn = new MySqlConnection("Server=localhost;Database=bookrentalshop;Uid=root;Pwd=root;Charset=utf8"))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT division, names FROM divtbl", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var division = reader.GetString("division");
                        var names = reader.GetString("names");

                        divisionItems.Add(new KeyValuePair<string, string>(division, names));
                        
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"DB연결 실패 : {ex.Message}","오류",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }
        }
    }
}