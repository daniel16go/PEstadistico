namespace Productivo.Core.ViewModels.IoTMetrics
{
    public class Chart
    {
        
        public string labeldisplay { get; set; }
        public string yaxisname { get; set; }
        public string showRealTimeValue { get; set; }
        public string theme { get; set; }
        public string plotToolText { get; set; }
        public string setAdaptiveYMin { get; set; }

        public string caption { get; set; }
        public string subCaption { get; set; }
        public string numdisplaysets { get; set; }

        public Chart()
        {
            labeldisplay = "rotate";
            yaxisname = "IoT Data";
            showRealTimeValue = "0";
            theme = "fusion";
            plotToolText = "$label, $dataValue";
            setAdaptiveYMin = "1";
        }

    }
}
