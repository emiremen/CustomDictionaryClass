using MyDictionaryGenericClass;

MyDictionary<string,int> asd = new MyDictionary<string, int>();
asd.Add("as", 777);

Console.WriteLine(asd["as"]);


MyDictionary<int, int> asdd = new MyDictionary<int, int>();
asdd.Add(57, 333);

Console.WriteLine(asdd[57]);