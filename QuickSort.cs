
using StrategyPattern.Interfaces;

class Quicksort : ISortStrategy {
    public int[]? arr { get; set; }
    public bool? asc { get; set; }

    public int[] sort(int[] arr, bool asc) {
        var _arr = arr; 
        quickSort(_arr, 0, _arr.Length-1);
        if(asc){
            return _arr;
        }
        return _arr.Reverse().ToArray();
    }

    private static void quickSort(int[] arr, int left, int right) 
        {
            if (left < right)
            {
                int pivot = partition(arr, left, right);

                if (pivot > 1) {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right) {
                    quickSort(arr, pivot + 1, right);
                }
            }
        
        }

        private static int partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true) 
            {

                while (arr[left] < pivot) 
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else 
                {
                    return right;
                }
            }
        }
}
