int[] array = { -40, 10, 20, 30, 50 };
var selectionSort = new BubbleSort();
bool asc = true;

foreach(var item in selectionSort.sort(array, asc)) {
    Console.WriteLine(item.ToString());
}