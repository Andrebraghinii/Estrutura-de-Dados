//arrayLists

using System.Collections;

ArrayList  arrayList = new ArrayList();

//adicionando itens a lista
arrayList.Add(5);

//adicionando quantia de itens na lista
arrayList.AddRange(new int[]{1, 2, 3});

//
arrayList.Insert(3, 7.8);

//percorrendo itens da lista de forma generica

foreach (object obj in arrayList){
    
    Console.WriteLine(obj);
}