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


namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private bool first = true;
        private int num1 = 0;
        private int num2 = 0;
        private char znak;
        List<int> numer1 = new List<int>();
        List<int> numer2 = new List<int>();
        public MainWindow()
        {
            InitializeComponent();           

        }
       
        private void TextBox_KeyDown(object sender, KeyEventArgs e) { MyRichTextBox_edit.Text+=(e.Key.ToString()); }       
        private void button_0_Click(object sender, RoutedEventArgs e) { zero(); }       
        private void button_1_Click(object sender, RoutedEventArgs e) { one(); }        
        private void button_2_Click(object sender, RoutedEventArgs e) { two(); }       
        private void button_3_Click(object sender, RoutedEventArgs e) {three();}        
        private void button_4_Click(object sender, RoutedEventArgs e) {four();}        
        private void button_5_Click(object sender, RoutedEventArgs e) {five();}
        private void button_6_Click(object sender, RoutedEventArgs e) {six(); }        
        private void button_7_Click(object sender, RoutedEventArgs e) {seven();}      
        private void button_8_Click(object sender, RoutedEventArgs e) {eight();}
        private void button_9_Click(object sender, RoutedEventArgs e) {nine();}     
        private void button_x_Click(object sender, RoutedEventArgs e) { multiply();}       
        private void button_minus_Click(object sender, RoutedEventArgs e) {minus(); }       
        private void button_plus_Click(object sender, RoutedEventArgs e) { plus(); }    
        private void button_delenie_Click(object sender, RoutedEventArgs e) {division(); }       
        private void button_Clear_Click(object sender, RoutedEventArgs e)
        {
            MyRichTextBox_edit.Text = "";
            restart_value();
        }
        private void button_ravno_Click(object sender, RoutedEventArgs e) { return_(); }      
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad0) {zero(); }
            else if (e.Key == Key.NumPad1) {one(); }
            else if (e.Key == Key.NumPad2) { two(); }
            else if (e.Key == Key.NumPad3) { three(); }
            else if (e.Key == Key.NumPad4) { four(); }
            else if (e.Key == Key.NumPad5) { five(); }
            else if (e.Key == Key.NumPad6) { six(); }
            else if (e.Key == Key.NumPad7) {seven(); }
            else if (e.Key == Key.NumPad8) {eight(); }
            else if (e.Key == Key.NumPad9) { nine(); }

            else if (e.Key == Key.D0) {zero(); }
            else if (e.Key == Key.D1) { one(); }
            else if (e.Key == Key.D2) {two(); }
            else if (e.Key == Key.D3) { three(); }
            else if (e.Key == Key.D4) {four(); }
            else if (e.Key == Key.D5) { five(); }
            else if (e.Key == Key.D6) { six(); }
            else if (e.Key == Key.D7) { seven(); }
            else if (e.Key == Key.D8) { eight(); }
            else if (e.Key == Key.D9) { nine(); }

            else if (e.Key == Key.Divide) { division(); }
            else if (e.Key == Key.Multiply) { multiply(); }
            else if (e.Key == Key.Subtract) {minus(); }
            else if (e.Key == Key.Add) { plus(); }
            else if (e.Key == Key.Return) { return_(); }
        }
        private void button_ravno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return) {return_(); }
        }
        public void zero()
        {

            MyRichTextBox_edit.Text+="0";
            if (first) { numer1.Add(0); }
            else { numer2.Add(0); }
        }
        public void one()
        {
            {
                MyRichTextBox_edit.Text+= "1";
                if (first) { numer1.Add(1); }
                else { numer2.Add(1); }
            }
        }
        public void two()
        {
            MyRichTextBox_edit.Text+= "2";
            if (first) { numer1.Add(2); }
            else { numer2.Add(2); }

        }
        public void three()
        {
            MyRichTextBox_edit.Text+= "3";
            if (first) { numer1.Add(3); }
            else { numer2.Add(3); }

        }
        public void four()
        {
            MyRichTextBox_edit.Text+= "4";
            if (first) { numer1.Add(4); }
            else { numer2.Add(4); }
        }
        public void five()
        {
            MyRichTextBox_edit.Text += "5";
            if (first) { numer1.Add(5); }
            else { numer2.Add(5); }
        }
        public void six()
        {
            MyRichTextBox_edit.Text += "6";
            if (first) { numer1.Add(6); }
            else { numer2.Add(6); }
        }
        public void seven()
        {
            MyRichTextBox_edit.Text += "7";
            if (first) { numer1.Add(7); }
            else { numer2.Add(7); }

        }
        public void eight()
        {
            MyRichTextBox_edit.Text += "8";
            if (first) { numer1.Add(8); }
            else { numer2.Add(8); }
        }
        public void nine()
        {
            MyRichTextBox_edit.Text += "9";
            if (first) { numer1.Add(9); }
            else { numer2.Add(9); }
        }
        public void multiply()
        {
            MyRichTextBox_edit.Text += "*";
            znak = '*';
            first = false;
        }
        public void minus()
        {
            MyRichTextBox_edit.Text += "-";
            znak = '-';
            first = false;
        }
        public void plus()
        {
            MyRichTextBox_edit.Text+= "+";
            znak = '+';
            first = false;
        }
        public void division()
        {
            MyRichTextBox_edit.Text += "/";
            znak = '/';
            first = false;
        }
        public void return_()
        {
            num1 = 0;
            num2 = 0;
            string strTmp1 = "";
            string strTmp2 = "";
            foreach (int num in numer1) { strTmp1 += num.ToString(); }
            foreach (var num in numer2) { strTmp2 += num.ToString(); }
            num1 = int.Parse(strTmp1);
            num2 = int.Parse(strTmp2);


            if (znak == '-')
            {
                MyRichTextBox_edit.Text = "";
                MyRichTextBox_edit.Text = ((num1 - num2).ToString());
                int resultTmp = num1 - num2;
                restart_value();
                numer1.Add(resultTmp);

            }
            if (znak == '+')
            {
                MyRichTextBox_edit.Text = "";
                MyRichTextBox_edit.Text = ((num1 + num2).ToString());
                int resultTmp = num1 + num2;
                restart_value();
                numer1.Add(resultTmp);

            }
            if (znak == '*')
            {
                MyRichTextBox_edit.Text = "";
                MyRichTextBox_edit.Text = ((num1 * num2).ToString());
                int resultTmp = num1 * num2;
                restart_value();
                numer1.Add(resultTmp);

            }
            if (znak == '/')
            {
                MyRichTextBox_edit.Text = "";
                MyRichTextBox_edit.Text = ((num1 / num2).ToString());
                int resultTmp = num1 / num2;
                restart_value();
                numer1.Add(resultTmp);

            }
        }
        public void restart_value()
        {
            first = true;
            num1 = 0;
            num2 = 0;
            znak = '.';
            numer1.Clear();
            numer2.Clear();

        }





    }
}
