using Comparsion.Algorithms;
using Comparsion.Helpers;
using Comparsion.Models;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Xml.Linq;

//AlgorithmTest
var results = BenchmarkRunner.Run<AlgorithmTest>();
[MemoryDiagnoser]
public class AlgorithmTest
{
    //Little
    Element[] randomLittle = CollectionFactory.GenerateShuffledArray(10);
    Element[] sortedLittle = CollectionFactory.GenerateOrderedArray(10);
    //Low
    Element[] randomLow = CollectionFactory.GenerateShuffledArray(100);
    Element[] sortedLow = CollectionFactory.GenerateOrderedArray(100);
    //Medium
    Element[] randomMedium = CollectionFactory.GenerateShuffledArray(1000);
    Element[] sortedMedium = CollectionFactory.GenerateOrderedArray(1000);
    //Large
    Element[] randomLarge = CollectionFactory.GenerateShuffledArray(10000);
    Element[] sortedLarge = CollectionFactory.GenerateOrderedArray(10000);
    //Extra large
    Element[] randomExtraLarge = CollectionFactory.GenerateShuffledArray(100000);
    Element[] sortedExtraLarge = CollectionFactory.GenerateOrderedArray(100000);
    //Gigantic
    Element[] randomGigantic = CollectionFactory.GenerateShuffledArray(1000000);
    Element[] sortedGigantic = CollectionFactory.GenerateOrderedArray(1000000);
    //Solution
    //Little
    [Benchmark]
    public void RandomLittleBubbleSort()
    {
        BubbleSort<Element>.Sort(randomLittle);
    }
    [Benchmark]
    public void SortedLittleBubbleSort()
    {
        BubbleSort<Element>.Sort(sortedLittle);
    }
    //
    [Benchmark]
    public void RandomLittleQuickSort()
    {
        QuickSort<Element>.Sort(randomLittle);
    }
    [Benchmark]
    public void SortedLittleQuickSort()
    {
        QuickSort<Element>.Sort(sortedLittle);
    }
    //Low
    [Benchmark]
    public void RandomLowBubbleSort()
    {
        BubbleSort<Element>.Sort(randomLow);
    }
    [Benchmark]
    public void SortedLowBubbleSort()
    {
        BubbleSort<Element>.Sort(sortedLow);
    }
    //
    [Benchmark]
    public void RandomLowQuickSort()
    {
        QuickSort<Element>.Sort(randomLow);
    }
    [Benchmark]
    public void SortedLowQuickSort()
    {
        QuickSort<Element>.Sort(sortedLow);
    }
    //Medium
    [Benchmark]
    public void RandomMediumBubbleSort()
    {
        BubbleSort<Element>.Sort(randomMedium);
    }
    [Benchmark]
    public void SortedMediumBubbleSort()
    {
        BubbleSort<Element>.Sort(sortedMedium);
    }
    //
    [Benchmark]
    public void RandomMediumQuickSort()
    {
        QuickSort<Element>.Sort(randomMedium);
    }
    [Benchmark]
    public void SortedMediumQuickSort()
    {
        QuickSort<Element>.Sort(sortedMedium);
    }
    //Large
    [Benchmark]
    public void RandomLargeBubbleSort()
    {
        BubbleSort<Element>.Sort(randomLarge);
    }
    [Benchmark]
    public void SortedLargeBubbleSort()
    {
        BubbleSort<Element>.Sort(sortedLarge);
    }
    //
    [Benchmark]
    public void RandomLargeQuickSort()
    {
        QuickSort<Element>.Sort(randomLarge);
    }
    [Benchmark]
    public void SortedLargeQuickSort()
    {
        QuickSort<Element>.Sort(sortedLarge);
    }
    //Extra large
    [Benchmark]
    public void RandomExtraLargeBubbleSort()
    {
        BubbleSort<Element>.Sort(randomExtraLarge);
    }
    [Benchmark]
    public void SortedExtraLargeBubbleSort()
    {
        BubbleSort<Element>.Sort(sortedExtraLarge);
    }
    //
    [Benchmark]
    public void RandomExtraLargeQuickSort()
    {
        QuickSort<Element>.Sort(randomExtraLarge);
    }
    [Benchmark]
    public void SortedExtraLargeQuickSort()
    {
        QuickSort<Element>.Sort(sortedExtraLarge);
    }
    //Gigantic
    [Benchmark]
    public void RandomGiganticBubbleSort()
    {
        BubbleSort<Element>.Sort(randomGigantic);
    }
    [Benchmark]
    public void SortedGiganticBubbleSort()
    {
        BubbleSort<Element>.Sort(sortedGigantic);
    }
    //
    [Benchmark]
    public void RandomGiganticQuickSort()
    {
        QuickSort<Element>.Sort(randomGigantic);
    }
    [Benchmark]
    public void SortedGiganticQuickSort()
    {
        QuickSort<Element>.Sort(sortedGigantic);
    }
}