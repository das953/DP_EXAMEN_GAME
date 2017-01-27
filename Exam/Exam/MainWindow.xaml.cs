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

namespace Exam
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

/*
 * if(hp <=0 && hero.type == peshka && !team.zombie) hero.zombie(); 20% (40-60 / 100)
 * на кожен раунд є вірогідність "слона" (вбиває 1го ранд перса з 1ї команди) - 1 раз за гру (10%) (45-55/100)
 * Оля зробить анімацію
 * team 7 / 7 (List<T>) / (List<T> но чз "ланцюг")
 * pattern Command
 * для сейв\лод pattern Memento
 * юзер обирає юніта на раунд / ПК ланцюг (if next.hp > current.hp current = next)
 * 
 */
