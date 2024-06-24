using System.Diagnostics;
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
            var choice = AnsiConsole.Prompt(new SelectionPrompt<String>().Title("What algorthim would you like to see today?").AddChoices(new[] {"Array Size","Bubble","Quick","Selection","Heap","Shell", "Insert"}));
            array = ResetArray(array);

            switch(choice)
            {
                case "Array Size":
                    ArraySizeMenu();
                    break;
                case "Bubble":
                    SortMenu(Algorithms.BubbleSort, "Bubble");
                    break;
                case "Quick":
                    SortMenu(Algorithms.QuickSort, "Quick");
                    break;
                case "Selection":
                    SortMenu(Algorithms.SelectionSort, "Selection");
                    break;
                case "Heap":
                    SortMenu(Algorithms.HeapSort, "Heap");
                    break;
                case "Shell":
                    SortMenu(Algorithms.ShellSort, "Shell");
                    break;
                case "Insert":
                    SortMenu(Algorithms.InsertionSort, "Insert");
                    break;
                default:
                    MainMenu();
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

        public void ArraySizeMenu()
        {
            AnsiConsole.Clear();

            int size = AnsiConsole.Ask<int>("Please specify number of array elements in [underline red]int[/] format:");
            
            AnsiConsole.WriteLine();
            
            AnsiConsole.MarkupLine("Array Size has been set to: " + size);
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("Press any Key to return to Main Menu");

            Console.ReadLine();
            MainMenu();
        }

       
        public void SortMenu(Func<int[], int, int, int[]> sortingMethod, string name)
        {
            AnsiConsole.Clear();
            AnsiConsole.MarkupLine(name + " Sort test method");

            AnsiConsole.MarkupLine("[red]UnSorted:[/]");
            chartManager.UpdateList(array, false);
            chartManager.showChart();

            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("[green]Sorted:[/]");

            StartTimer();
            int[] SortedArray = sortingMethod(array, 0, array.Length - 1);
            StopTimer();

            chartManager.UpdateList(SortedArray, true);
            chartManager.showChart();
            PrintTime();

            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("Press any Key to return to Main Menu");

            Console.ReadLine();
            MainMenu();
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

        public void PrintTime()
        {
            AnsiConsole.MarkupLine("Elapsed Time: " + methodTime.ElapsedMilliseconds + "ms");
        }

    }
}
