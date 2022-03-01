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
using TcoCoreExamples;

namespace TcoCore.Sandbox.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = TcoCore.Sandbox.Wpf.App.PlcTcoCoreExamples;
            swiftRecorder.DataContext = new TcOpen.Inxton.Swift.Wpf.SwiftRecorderViewModel(TcoCoreExamples.Entry.PlcTcoCoreExamples.EXAMPLES_PRG._recordableStations);          
        }
    }
}
