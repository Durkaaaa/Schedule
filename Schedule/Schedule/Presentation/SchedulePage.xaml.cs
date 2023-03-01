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

namespace Schedule.Presentation
{
    /// <summary>
    /// Логика взаимодействия для SchedulePage.xaml
    /// </summary>
    public partial class SchedulePage : Page
    {
        public SchedulePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                // Определить поля
                int pageMargin = 10;

                // Получить размер страницы
                Size pageSize = new Size(printDialog.PrintableAreaWidth,
                    printDialog.PrintableAreaHeight);

                //// Инициировать установку размера элемента
                //List.Measure(pageSize);
                List.Arrange(new Rect(pageMargin, pageMargin, pageSize.Width, pageSize.Height));

                // Напечатать элемент
                printDialog.PrintVisual(List, "Распечатываем элемент Canvas");

            }
        }
    }
}
