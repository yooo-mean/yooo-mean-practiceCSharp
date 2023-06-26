
using System.Collections;

#region Non generic collection example
// 1) Non generic collection
//ArrayList list = new ArrayList();

//list.Add("Dotnet");
//list.Add("2.1");
//list.Add("Asp.Net Core");

//foreach (var item in list)
//{
//	Console.WriteLine(item);
//}
//Console.ReadLine(); 
#endregion

// 2) Generic collection example
var list = new List<int>
{
    1, 2, 3, 4, 5, 6, 7
};

IEnumerable<int> enumerableList = list;

//Console.WriteLine(enumerableList.Count);
ICollection<int> collectionList = list;

Console.WriteLine(collectionList.Count);

list.Clear();

// Enumerable < Collection < List

foreach(var item in list)
{
    Console.WriteLine(item);
}

