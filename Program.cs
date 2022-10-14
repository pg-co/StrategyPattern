int[] array = { 40, 10, 20, 30, 50 };
var selectionSort = new InsertionSort();

foreach(var item in selectionSort.sort(array)) {
    Console.WriteLine(item.ToString());
}
