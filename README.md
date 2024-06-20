# SortingVisualizer

A simple Console Visualizer for testing sorting algorithms using [Spectre.Console](https://github.com/spectreconsole/spectre.console)

# Usage

```c#
// Bubble Sort avg O(N2)
        public static int[] BubbleSort(int[] arr, int leftIndex, int rightIndex)
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
```

```c#
 var choice = AnsiConsole.Prompt(new SelectionPrompt<String>().Title("What algorthim would you like to see today?").AddChoices(new[] {"Array Size","Bubble","Quick","Selection","Heap"}));
```

```c#
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
                default:
                    MainMenu();
                    break;

            }
```

# Learning References

Inspiration for this project:
 * https://code-maze.com/sorting-algorithms-csharp/
 * https://www.c-sharpcorner.com/topics/sorting-algorithm
 * https://en.wikipedia.org/wiki/Sorting_algorithm

