using StrategyPattern.Interfaces;

class InsertionSort : ISortStrategy {
    public int[]? arr { get; set; }

    public int[] sort(int[] arr, bool asc) {
     
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (arr[j - 1] > arr[j])
                {
                    int temp = arr[j - 1];
                     arr[j - 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        return asc ? arr : arr.Reverse().ToArray();
        
    }
}