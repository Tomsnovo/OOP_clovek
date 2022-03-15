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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_clovek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Clovek karel;
        Clovek jan;
        
        public MainWindow()
        {
            InitializeComponent();
            karel = new Clovek();
            karel.name = "Karel";
            show(karel, txtbox1);

            jan = new Clovek();
            jan.name = "Jan";
            show(jan, txtbox2);
        }
        public void show(Clovek clovek, TextBox textBox)
        {
            textBox.Text = clovek.surname + " " + clovek.name;
            textBox.Text += "\n" + "health: " + clovek.health;
            textBox.Text += "\n" + "stamina: " + clovek.stamina;
            textBox.Text += "\n" + "skill: " + clovek.skill;
            textBox.Text += "\n" + "birth: " + clovek.birth;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            karel.Aging();
            jan.Aging();
            show(karel, txtbox1);
            show(jan, txtbox2);
        }
    }
}
