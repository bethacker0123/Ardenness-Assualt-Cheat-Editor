using System.Windows;
using System.Windows.Controls;
using Ardenness_Assault_Save_Game_Editor.GUI.ViewModel;
namespace Ardenness_Assault_Save_Game_Editor.GUI.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
  
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
            Closing += ((MainWindowViewModel)this.DataContext).OnClosing;
        }

        

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
