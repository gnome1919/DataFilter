using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFilter
{
    public class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool isSecondsChecked = false;
        private bool isMAChecked = false;
        private bool isSGChecked = false;
        private bool isLBChecked = true;
        private string dataPeriod;
        private int? numOfData;
        private int? resampleStart;
        private int? resampleInterval;
        private int? windowSize;
        private int? dataFirst;
        private int? dataEnd;
        private int? smoothing;
        private double? cutOffFreq;
        private int? filterOrder;

        private enum TimeInputFormat
        {
            Seconds = 1,
            Full = 2
        }

        public bool IsSecondsChecked { get => isSecondsChecked; set { isSecondsChecked = value; OnPropertyChanged(nameof(IsSecondsChecked)); } }
        public bool IsMAChecked { get => isMAChecked; set { isMAChecked = value; OnPropertyChanged(nameof(IsMAChecked)); } }
        public bool IsSGChecked { get => isSGChecked; set { isSGChecked = value; OnPropertyChanged(nameof(IsSGChecked)); } }
        public bool IsLBChecked { get => isLBChecked; set { isLBChecked = value; OnPropertyChanged(nameof(IsLBChecked)); } }
        public string DataPeriod { get => dataPeriod; set { dataPeriod = value; OnPropertyChanged(nameof(DataPeriod)); } }
        public int? NumOfData { get => numOfData; set { numOfData = value; OnPropertyChanged(nameof(NumOfData)); } }
        public int? ResampleStart { get => resampleStart; set { resampleStart = value; OnPropertyChanged(nameof(ResampleStart)); } }
        public int? ResampleInterval { get => resampleInterval; set { resampleInterval = value; OnPropertyChanged(nameof(ResampleInterval)); } }
        public int? WindowSize { get => windowSize; set { windowSize = value; OnPropertyChanged(nameof(WindowSize)); } }
        public int? DataFirst { get => dataFirst; set { dataFirst = value; OnPropertyChanged(nameof(DataFirst)); } }
        public int? DataEnd { get => dataEnd; set { dataEnd = value; OnPropertyChanged(nameof(DataEnd)); } }
        public int? Smoothing { get => smoothing; set { smoothing = value; OnPropertyChanged(nameof(Smoothing)); } }
        public double? CutOffFreq { get => cutOffFreq; set { cutOffFreq = value; OnPropertyChanged(nameof(CutOffFreq)); } }
        public int? FilterOrder { get => filterOrder; set { filterOrder = value; OnPropertyChanged(nameof(FilterOrder)); } }
    }
}
