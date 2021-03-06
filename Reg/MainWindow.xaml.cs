﻿using System;
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
using System.Text.RegularExpressions;

namespace Reg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {   if (textBox.Text=="")
            {
                MessageBox.Show("Данные для проверки не введены");
               
            }
            if (comboBox.Text == "")
            {
                MessageBox.Show("Ничего не выбрано");
            }
            else
            {

                if (comboBox.Text == "Натуральное число")
                {
                    Regex Reg_nat = new Regex(@"^\d[1-9]+$");
                    if (Reg_nat.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Это натуральное число");
                    }
                    else
                        MessageBox.Show("Это не натуральное число");
                }

                if(comboBox.Text== "Вещественное число с 2 знаками после запятой")
                {
                    Regex Reg_v_2 = new Regex(@"[0-9]\.\d{2}$");
                    if(Reg_v_2.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Это вещественное число с 2 знаками после запятой");
                    }
                    else
                    {
                        MessageBox.Show("Это не вещественное число с 2 знаками после запятой");
                    }

                }
                if(comboBox.Text=="Целое число")
                {
                    Regex Reg_z = new Regex(@"^\d[1-9]+$");
                        if(Reg_z.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Это целое число");
                    }
                        else
                    {
                        MessageBox.Show("Это не целое число");
                    }

                }
                if(comboBox.Text=="Комплексное число")
                {
                    Regex Reg_k = new Regex(@"^\\s*[+-]?((\d+)?[.,])?(\d*)?\s*[+-]\s*((\d+)?[.,])?(\d+)?[*_x]?[i]\s*$");
                    if(Reg_k.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Это комплексное число");
                    }
                    else
                    {
                        MessageBox.Show("Это не комплексное число");
                    }
                }
                if(comboBox.Text=="Почтовый индекс")
                {
                    Regex Reg_ind = new Regex(@"^\d{6}$");
                    if(Reg_ind.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Это почтовый индекс");
                    }
                    else
                    {
                        MessageBox.Show("Это не почтовый индекс");
                    }
                }
                if(comboBox.Text=="html контейнер")
                {
                    Regex Reg_html = new Regex(@"^<\w*>\w*\</\w*\>$");
                    if(Reg_html.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Это html контейнер");
                    }
                    else
                    {
                        MessageBox.Show("Это не html контейнер");
                    }
                }
                if (comboBox.Text == "URL")
                {
                    Regex Reg_URL = new Regex(@"^((https?|ftp)\:\/\/)?([a-z0-9]{1})((\.[a-z0-9-])|([a-z0-9-]))*\.([a-z]{2,6})(\/?)$");
                    if (Reg_URL.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Это URl");
                    }
                    else
                    {
                        MessageBox.Show("Это не URL");
                    }
                }
                if (comboBox.Text == "Адрес")
                {
                    Regex Reg_ad = new Regex(@"^([0-9]{6})\s([а-яА-Яa-zA-Z ]+)\s(ул\.)([а-яА-Яa-zA-Z0-9 ]+)\s(д\.)([0-9а-яА-Яa-zA-Z\-]+)\s(кв\.)([0-9]+)$");
                    if (Reg_ad.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Это адрес");
                    }
                    else
                    {
                        MessageBox.Show("Это не адрес");
                    }
                }
                if (comboBox.Text == "ФИО")
                {
                    Regex Reg_Fio = new Regex(@"^[(А-ЯA-Z)|[(а-я)][а-яa-zА-ЯA-Z\-]{0,}\s[А-ЯA-Z][а-яa-zА-ЯA-Z\-]{1,}(\s[А-ЯA-Z][а-яa-zА-ЯA-Z\-]{1,})?$");
                    if (Reg_Fio.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Это ФИО");
                    }
                    else
                    {
                        MessageBox.Show("Это не ФИО");
                    }
                }
                if (comboBox.Text == "Телефонный номер")
                {
                    Regex Reg_tel = new Regex(@"^(8\d{10}|\+7\d{10}|8\(\d{3}\)\d{7}|\+7\(\d{3}\)\d{7}|8\ \(\d{3}\)\ \d{7}|\+7\ \(\d{3}\)\ \d{7}|8\ \(\d{3}\)\ (\d{2}\-){2}\d{3}|8\ \(\d{3}\)\ (\d{2}\ \-\ ){2}\d{3})$");
                    if (Reg_tel.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Это телефонный номер");
                    }
                    else
                    {
                        MessageBox.Show("Это не телефонный номер");
                    }
                }
                if (comboBox.Text == "Электронная почта(com)")
                {
                    Regex Reg_post_com = new Regex(@"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$");
                    if (Reg_post_com.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Это электронная почта");
                    }
                    else
                    {
                        MessageBox.Show("Это не электронная почта");
                    }
                }
                if (comboBox.Text == "Электронная почта(ru)")
                {
                    Regex Reg_post_ru = new Regex(@"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[ru]{2}$");
                    if (Reg_post_ru.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Это электронная почта");
                    }
                    else
                    {
                        MessageBox.Show("Это не электронная почта");
                    }
                }
                if(comboBox.Text=="Повторы слов")
                {
                    string str;
                    str = Convert.ToString(textBox.Text);
                    str = string.Join(" ", str.ToLower().Split(' ').Distinct());
                    MessageBox.Show(str);

                }
                if(comboBox.Text=="Правописание")
                {
                    Regex Reg_prav = new Regex(@"^(((.*?[Ж|Ш|ж|ш]ы)+)|(.*?([Ж|Ш|ж|ш]ы).*)|((.*?[Ч|Щ|ч|щ]а)+)|(.*?([Ч|Щ|ч|щ][а|ю]).*))$");
                    if (Reg_prav.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Есть ошибки");
                    }
                    else
                    {
                        MessageBox.Show("Нет ошибок");
                    }
                }
                if(comboBox.Text=="Проверка даты")
                {
                    string str_d;
                    str_d = Convert.ToString(textBox.Text);
                    DateTime time;
                    if(DateTime.TryParse(str_d,out time ))
                    {
                        MessageBox.Show("Вы введи следуюшую дату\n"+Convert.ToString(time));
                    }
                    else
                    {
                        MessageBox.Show("Дата введена некорректно");
                    }
                }
                if (comboBox.Text == "Проверка даты(2)")
                {
                    Regex dat = new Regex(@"^(((0[1-9]|[1|2][0-9]|3[0|1])[\-|\ |\/|\.](0[1|3|5|7|8]|1[0|2])[\-|\ |\/|\.]((19|20)\d{2}))|((0[1-9]|[1|2][0-9]|30)[\-|\ |\/|\.](0[4|6|9]|11)[\-|\ |\/|\.](19|20)\d{2})|((0[1-9]|[1|2][0-9])[\-|\ |\/|\.](02)[\-|\ |\/|\.](19|20)\d{2}))$");
                    if (dat.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Дата корректа");
                    }
                    else
                    {
                        MessageBox.Show("Дата некорректна");
                    }
                   
                       
                }
                if(comboBox.Text== "Целое число с разделение разрядов")
                {
                    Regex zr = new Regex(@"^(((\d+\ )+|(\d+)))+$");
                    if(zr.IsMatch(textBox.Text))
                    {
                        MessageBox.Show("Корректный ввод");
                    }
                    else
                    {
                        MessageBox.Show("Некорректный ввод");
                    }

                }


            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                AboutBox1 F = new AboutBox1();
                F.ShowDialog();
                

            }
        }
    }
}
