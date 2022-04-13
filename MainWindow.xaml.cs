using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;

namespace DataFilter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ViewModel viewModel;

        // Create OpenFileDialog
        readonly OpenFileDialog openFileDlg = new OpenFileDialog();

        private List<int> yearList = new List<int>();
        private List<int> monthList = new List<int>();
        private List<int> dayList = new List<int>();
        private List<int> hourList = new List<int>();
        private List<double> hourDecimalList = new List<double>();
        private List<int> minuteList = new List<int>();
        private List<int> centuryList = new List<int>();
        private List<double> valueList = new List<double>();
        private int lineCount;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            DataContext = viewModel;
            viewModel.Filter_Model.PropertyChanged += Filter_PropertyChanged;
            Filter_PropertyChanged(this, null);

            ResampleStartTbx.Text = "6";
            ResampleIntervalTbx.Text = "3";
            WindowSizeTbx.Text = "0";
            DataFirstTbx.Text = "0";
            DataEndTbx.Text = "0";
            SmoothingTbx.Text = "0";
            CutOffFreqTbx.Text = "0.05";
            FilterOrderTbx.Text = "4";
            WindowSizeTbx.IsEnabled = false;
            DataFirstTbx.IsEnabled = false;
            DataEndTbx.IsEnabled = false;
            SmoothingTbx.IsEnabled = false;
        }
        private void Filter_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //viewModel.Filter_Model.IsMAChecked = MovAveRB.IsChecked;
                  
        }         

        private void InpBtnClicked(object sender, RoutedEventArgs e)
        {
            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = openFileDlg.ShowDialog();

            // Get the selected file name and display in a TextBox.
            // Load content of file in a TextBlock
            if (result == true && FullDateRB.IsChecked == true)
            {
                string firstLine = File.ReadLines(openFileDlg.FileName).Skip(2).Take(1).First();
                string lastLine = File.ReadLines(openFileDlg.FileName).Last();
                DataPeriodTbx.Text = "From " + firstLine.Substring(0, 10) + " To " + lastLine.Substring(0, 10);
                InputFileTbx.Text = openFileDlg.FileName;
            }
            else if (result == true && SecondsRB.IsChecked == true)
            {
                string firstLine = File.ReadLines(openFileDlg.FileName).Skip(2).Take(1).First();
                string lastLine = File.ReadLines(openFileDlg.FileName).Last();
                DataPeriodTbx.Text = "From " + firstLine.Substring(0, 1) + " To " + lastLine.Split('.')[0] + " (Hour)";
                InputFileTbx.Text = openFileDlg.FileName;
            }

            lineCount = File.ReadLines(openFileDlg.FileName).Count();
            DataNumberTbx.Text = (lineCount - 2).ToString();
        }

        private void RunBtnClicked(object sender, RoutedEventArgs e)
        {
            //string[] lines = File.ReadAllLines(openFileDlg.FileName);

            if (FullDateRB.IsChecked == true)
            {
                using (var sr = new StreamReader(openFileDlg.FileName))
                {
                    sr.ReadLine(); sr.ReadLine();
                    for (int i = 2; i < lineCount; i++)
                    {
                        string currentLine = sr.ReadLine();
                        string[] splittedLine = Regex.Split(currentLine, @"\s+");

                        DateTime date = DateTime.ParseExact(splittedLine[0], "MM/dd/yyyy", CultureInfo.InvariantCulture);
                        yearList.Add(Convert.ToInt32(date.ToString("yy")));
                        monthList.Add(Convert.ToInt32(date.Month.ToString()));
                        dayList.Add(Convert.ToInt32(date.Day.ToString()));
                        centuryList.Add(Convert.ToInt32(date.Year.ToString().Substring(0, 2)) + 1);

                        DateTime time = DateTime.ParseExact(splittedLine[1], "H:mm", CultureInfo.InvariantCulture);
                        hourList.Add(Convert.ToInt32(time.Hour.ToString()));
                        minuteList.Add(Convert.ToInt32(time.Minute.ToString()));

                        valueList.Add(Convert.ToDouble(splittedLine[2]));
                    }
                }
            }
            else
            {
                using (var sr = new StreamReader(openFileDlg.FileName))
                {
                    sr.ReadLine(); sr.ReadLine();
                    for (int i = 2; i < lineCount; i++)
                    {
                        string currentLine = sr.ReadLine();
                        string[] splittedLine = Regex.Split(currentLine, @"\s+");
                        hourDecimalList.Add(Convert.ToDouble(splittedLine[0]) * 3600);
                        valueList.Add(Convert.ToDouble(splittedLine[1]));
                    }
                }
            }

            var Nline = lineCount - 2;
            var ReSamPo1 = Int32.Parse(ResampleStartTbx.Text);
            var ReSamInc = Int32.Parse(ResampleIntervalTbx.Text);
            var number = Nline / ReSamInc;
            var MHs = new int[number];
            var HHs = new int[number];
            var DDs = new int[number];
            var MMs = new int[number];
            var YYs = new int[number];
            var CCs = new int[number];
            var timesecs = new double[number];
            var Elevs = new double[number];
            var Elevo = new double[number];
            var DatePeriod = DataPeriodTbx.Text;
            double[] elev = valueList.ToArray();
            int[] MH = new int[Nline];
            int[] HH = new int[Nline];
            int[] DD = new int[Nline];
            int[] MM = new int[Nline];
            int[] YY = new int[Nline];
            int[] CC = new int[Nline];
            double[] timesec = new double[Nline];
            var WindowSize = new int();
            var nl = new int();
            var nr = new int();
            var m = new int();
            var iorder = new int();
            var FC = new double();
            int AnalysisType;
            int TimeFormat;

            if (FullDateRB.IsChecked == true)
            {
                TimeFormat = 2;
                MH = minuteList.ToArray();
                HH = hourList.ToArray();
                DD = dayList.ToArray();
                MM = monthList.ToArray();
                YY = yearList.ToArray();
                CC = centuryList.ToArray();
            }
            else
            {
                TimeFormat = 1;
                timesec = hourDecimalList.ToArray();
            }

            if (MovAveRB.IsChecked == true)
            {
                AnalysisType = 1;
                WindowSize = Int32.Parse(WindowSizeTbx.Text);
            }
            else if (SavGolRB.IsChecked == true)
            {
                AnalysisType = 2;
                nl = Int32.Parse(DataFirstTbx.Text);
                nr = Int32.Parse(DataEndTbx.Text);
                m = Int32.Parse(SmoothingTbx.Text);
            }
            else
            {
                AnalysisType = 3;
                iorder = Int32.Parse(FilterOrderTbx.Text);
                FC = Double.Parse(CutOffFreqTbx.Text);
            }

            FilterBridge.LOWPASS(ref TimeFormat, ref Nline, ref iorder, ref FC, ref MH, ref HH, ref DD, ref MM, ref YY, ref CC, elev, ref AnalysisType, ref WindowSize, ref ReSamPo1, ref ReSamInc, ref nl, ref nr, ref m, ref timesec, MHs, HHs, DDs, MMs, YYs, CCs, timesecs, number, Elevs, Elevo);

            string[] contents = new string[10];

            contents[0] = "Data Period:\t\t\t" + DataPeriodTbx.Text;
            contents[1] = "Number of Data:\t\t\t" + DataNumberTbx.Text;
            contents[2] = "Start Point of Resampling:\t" + ResampleStartTbx.Text;
            contents[3] = "Resample Interval:\t\t" + ResampleIntervalTbx.Text;
            contents[4] = "Window Size (Odd Number):\t" + WindowSizeTbx.Text;
            contents[5] = "Unchanged Data at First:\t" + DataFirstTbx.Text;
            contents[6] = "Unchanged Data at End:\t\t" + DataEndTbx.Text;
            contents[7] = "Degree of Smoothing:\t\t" + SmoothingTbx.Text;
            contents[8] = "Cut-off Frequency:\t\t" + CutOffFreqTbx.Text;
            contents[9] = "Order of Filter:\t\t" + FilterOrderTbx.Text;
            File.WriteAllLines("FieldsValues.txt", contents);
        }
    }
}
