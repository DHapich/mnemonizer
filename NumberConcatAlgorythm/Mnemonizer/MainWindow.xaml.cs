﻿using System;
using System.Collections.Generic;
using System.Linq;
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
using Coder;
//using DataWorker;

namespace Mnemonizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       //DataConnection connector = new DataConnection();
        private MnemonicCoder coder = new MnemonicCoder();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //string str = connector.getWordByNumber(12);
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (rbCode.IsChecked == true)
                textBox2.Text = coder.coding(textBox1.Text);
            else 
                if(rbDecode.IsChecked == true)
                    textBox2.Text = coder.decoding(textBox1.Text);
        }
    }
}