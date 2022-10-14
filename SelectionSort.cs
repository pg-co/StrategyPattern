
using StrategyPattern.Interfaces;

class SelectionSort : ISortStrategy {
    public int[]? arr { get; set; }
    public bool? asc { get; set; }

    public int[] sort(int[] arr, bool asc) {
        var arrLength = arr.Length;
    
        for (int i = 0; i < arrLength - 1; i++) {
            var nextVal = i;

            for (int j = i + 1; j < arrLength; j++) {
                if (arr[j] < arr[nextVal]) {
                    nextVal = j;
                }
            }

            var tempVar = arr[nextVal];

            arr[nextVal] = arr[i];
            arr[i] = tempVar;
        }

        var sortedArr = asc ? arr : arr.Reverse().ToArray();

        return sortedArr;
    }
}
