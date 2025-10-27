using data_structures_algorithms_study.Algorithms.Search;

var numberList = new List<int>();

for (int i = 1; i <= 128; i++)
{
    numberList.Add(i);
}

Console.WriteLine(BinarySearch.BinarySearchIndex(numberList, 65));
Console.WriteLine(BinarySearch.BinarySearchIterationCount(numberList, 65));