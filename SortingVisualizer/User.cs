using System;
using System.Collections.Generic;
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

        public User() 
        {
            array = ResetArray(array);
            chartManager = new ChartManager(array);
            MainMenu();
        }

        public void MainMenu()
        {
            AnsiConsole.Clear();
            var choice = AnsiConsole.Prompt(new SelectionPrompt<String>().Title("What algorthim would you like to see today?").AddChoices(new[] {"Test","Bubble","Merge","Quick"}));

            switch(choice)
            {
                case "Test":
                    TestMenu();
                    break;
                case "Bubble":
                    BubbleSortMenu();
                    break;
                case "Merge":
                    break;
                case "Quick":
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
            //ShowArray(array);
            chartManager.UpdateList(array, false);
            chartManager.showChart();


            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("[green]Sorted:[/]");

            int[] SortedArray = BubbleSort(array);
            //ShowArray(SortedArray);
            chartManager.UpdateList(SortedArray, true);
            chartManager.showChart();

            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("Press any Key to return to Main Menu");

            Console.ReadLine();
            MainMenu();

        }

        public int[] BubbleSort(int[] arr)
        {
            int temp;
            bool doBreak;

            for (int i = 0; i < arr.Length; i++)
            {
                doBreak = true;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        doBreak = false;
                    }
                }
                if (doBreak)
                {
                    break;
                }
            }

            return arr;
        }

        public void TestMenu()
        {
            chartManager.showChart();
        }
    }
}
