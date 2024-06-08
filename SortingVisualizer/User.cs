using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace SortingVisualizer
{
    internal class User
    {
        public int[] array = new int[10];
        public ChartManager chartManager;
        Stopwatch methodTime;

        public User() 
        {
            array = ResetArray(array);
            chartManager = new ChartManager(array);
            MainMenu();
        }

        public void MainMenu()
        {
            AnsiConsole.Clear();
            var choice = AnsiConsole.Prompt(new SelectionPrompt<String>().Title("What algorthim would you like to see today?").AddChoices(new[] {"Bubble","Quick","Selection","test"}));
            array = ResetArray(array);

            switch(choice)
            {
                case "Bubble":
                    BubbleSortMenu();
                    break;
                case "Quick":
                    QuickSortMenu();
                    break;
                case "Selection":
                    SelectionSortMenu();
                    break;
                case "Test":
                    TestMenu();
                    break;
                default:
                    break;

            }
        }

        public int[] ResetArray(int[] arr)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int val = rnd.Next(1, 100);
                arr[i] = val;
            }

            return arr;
        }

        // no longer in use
        public void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length ; i++)
            {
                AnsiConsole.Write(arr[i] + ",");
            }
        }

        public void BubbleSortMenu()
        {
            
            AnsiConsole.Clear();
            AnsiConsole.MarkupLine("Bubble Sort");
            
            AnsiConsole.MarkupLine("[red]UnSorted:[/]");
            chartManager.UpdateList(array, false);
            chartManager.showChart();

            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("[green]Sorted:[/]");
            
            StartTimer();
            int[] SortedArray = Algorithms.BubbleSort(array);
            StopTimer();

            chartManager.UpdateList(SortedArray, true);
            chartManager.showChart();
            AnsiConsole.MarkupLine("Elapsed Time:" + methodTime.ElapsedMilliseconds);

            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("Press any Key to return to Main Menu");

            Console.ReadLine();
            MainMenu();

        }

        public void QuickSortMenu()
        {
            AnsiConsole.Clear();
            AnsiConsole.MarkupLine("Quick Sort");

            AnsiConsole.MarkupLine("[red]UnSorted:[/]");
            chartManager.UpdateList(array, false);
            chartManager.showChart();

            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("[green]Sorted:[/]");

            StartTimer();
            int[] SortedArray = Algorithms.QuickSort(array, 0, array.Length - 1);
            StopTimer();

            chartManager.UpdateList(SortedArray, true);
            chartManager.showChart();
            AnsiConsole.MarkupLine("Elapsed Time:" + methodTime.ElapsedMilliseconds);

            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("Press any Key to return to Main Menu");

            Console.ReadLine();
            MainMenu();
        }

        public void SelectionSortMenu()
        {
            AnsiConsole.Clear();
            AnsiConsole.MarkupLine("Selection Sort");

            AnsiConsole.MarkupLine("[red]UnSorted:[/]");
            chartManager.UpdateList(array, false);
            chartManager.showChart();

            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("[green]Sorted:[/]");

            StartTimer();
            int[] SortedArray = Algorithms.SelectionSort(array);
            StopTimer();

            chartManager.UpdateList(SortedArray, true);
            chartManager.showChart();
            AnsiConsole.MarkupLine("Elapsed Time:" + methodTime.ElapsedMilliseconds);

            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("Press any Key to return to Main Menu");

            Console.ReadLine();
            MainMenu();
        }

        public void TestMenu()
        {
            chartManager.showChart();
        }

        public void StartTimer()
        {
            methodTime = new Stopwatch();
            methodTime.Start();
        }

        public void StopTimer()
        {
            methodTime.Stop();
        }

    }
}
