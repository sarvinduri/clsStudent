using Microsoft.Win32;
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

namespace clsStudent
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

        private void BtnSavestudent_Click(object sender, RoutedEventArgs e)
        {
            ClsStudent student = new ClsStudent(); 
            student.FIO = TxtN.Text;
            student.Birthday = (DateTime)DtBirthday.SelectedDate;
            student.Scholarship = double.Parse(TxtStip.Text);

            LstStudents.Items.Clear();
            LstStudents.Items.Add(student.PrintToScreen());
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == false)
                return;
            student.SaveToFile(saveFileDialog.FileName);
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            TxtN.Clear();
            TxtStip.Clear();
        }
    }
}
