using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer
{
    public class ChartManager
    {
        public List<ChartObj> chartObjs = new List<ChartObj>();

        public ChartManager(int[] array) 
        {
            UpdateList(array, true);
        }

        public void UpdateList(int[] array, bool isSorted) 
        {
            chartObjs.Clear();
            
            Color color1;
            Color color2;

            if (isSorted)
            {
                color1 = Color.Green;
                color2 = Color.Green1;
            }
            else
            {
                color1 = Color.Red;
                color2 = Color.Red1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                ChartObj tempObj;

                if (i % 2 == 0)
                {
                    tempObj = new ChartObj(i.ToString(), array[i], color1);
                }
                else
                {
                    tempObj = new ChartObj(i.ToString(), array[i], color2);
                }
                chartObjs.Add(tempObj);
            }
        }

        public void showChart()
        {
            AnsiConsole.Write(new BarChart().Width(100).AddItems(chartObjs));
        }
    }

    public sealed class ChartObj : IBarChartItem
    {
        public string Label { get; set; }
        public double Value { get; set; }
        public Color? Color { get; set; }

        public ChartObj(string label, double value, Color? color)
        {
            Label = label;
            Value = value;
            Color = color;
        }
    }
}
