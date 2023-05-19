﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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


namespace Szeleromuvek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string fajlNev = "szeleromu.txt";
        ObservableCollection<Szeleromu> szeleromuvek = new ObservableCollection<Szeleromu>();
        public MainWindow()
        {
            InitializeComponent();
            double jegyekosszege = 0;
            szeleromuvek.Clear();
            StreamReader sr = new StreamReader(fajlNev);
            while (!sr.EndOfStream)
            {
                string[] mezok = sr.ReadLine().Split(";");
                Szeleromu ujEromu = new Szeleromu(mezok[0], int.Parse(mezok[1]), int.Parse(mezok[2]), mezok[3]);
                szeleromuvek.Add(ujEromu);
            }
            sr.Close();
            dgEromuvek.ItemsSource = szeleromuvek;
        }

        private void btnSzama_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Az erőművek száma: {szeleromuvek.Count()}");
        }

        private void btnKeres_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Szeleromu> szeleromuvek2 = new ObservableCollection<Szeleromu>();
            foreach (var eromu in szeleromuvek)
            {
                if (eromu.Helyszín == txtHelyszin.Text)
                {
                    szeleromuvek2.Add(eromu);
                }
            }
            foreach (var eromu2 in szeleromuvek2)
            {
                lbEromuvek.Items.Add($"{eromu2.Teljesítmény},{eromu2.Mennyiség}");
            }
        }

        private void btnEromu2010_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Szeleromu> szeleromuvek2 = new ObservableCollection<Szeleromu>();
            foreach (var eromu in szeleromuvek)
            {
                if (eromu.Helyszín == txtHelyszin.Text)
                {
                    szeleromuvek2.Add(eromu);
                }
            }
            foreach (var eromu2 in szeleromuvek2)
            {
                lbEromuvek.Items.Add($"{eromu2.Teljesítmény},{eromu2.Mennyiség}");
            }
        }
    }
}