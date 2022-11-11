using StrategyPattern.Interfaces;


List<int> ausgang = new List<int>();
Random rand = new Random();
for (int i = 0 ; i < 20000 ; i++){
    ausgang.Add(rand.Next());
}

var x = new NumberArray(ausgang.ToArray(),new Quicksort());
var watch = System.Diagnostics.Stopwatch.StartNew();
Console.WriteLine(x.sort(true));
watch.Stop();
Console.WriteLine("Quicksort TIME :" + watch.ElapsedMilliseconds);

x.strat = new BubbleSort();
watch.Restart();
Console.WriteLine(x.sort(true));
watch.Stop();
Console.WriteLine("BUBBLE SORT TIME :" + watch.ElapsedMilliseconds);

x.strat = new InsertionSort();
watch.Restart();
Console.WriteLine(x.sort(true));
watch.Stop();
Console.WriteLine("INSERTION SORT TIME :" + watch.ElapsedMilliseconds);

x.strat = new SelectionSort();
watch.Restart();
Console.WriteLine(x.sort(true));
watch.Stop();
Console.WriteLine("SELECTION SORT TIME :" + watch.ElapsedMilliseconds);


public class NumberArray{
    int[] arr {get; set;}
    public ISortStrategy strat {get; set;}

    public NumberArray(int[] xArr, ISortStrategy xStrat){
        this.arr = xArr;
        this.strat = xStrat;
    }
    public int[] sort(bool xAsc){
        return strat.sort(this.arr,xAsc);
    }

}
