using System.Collections;

HashTable phoneBook = new HashTable(){
    {"Edson Arantes do Nascimento", "0000"},
    {"Ronaldo Nazáreo dos Santos", "1111"},
    {"Luis Inacio Lula da Silva", "2222"}
    
};

//Adicionando em tempo de execução
phoneBook["Acelino Popo de Freitas"] = "33333"

//tratando possivel erro de duplicidade de chave

try
{
    phoneBook.Add("Edson Arantes do Nascimento", "000000");
}
catch (System.ArgumentException as ae){    
    Consele.WriteLine("Chave já existente. "+ ae.Message);
}
catch (System.Exception ex){
    Console.WriteLine("Erro imprevisto. "+ ex.Message);
}
//Percorrendo valores Tabela Hash
Console.WriteLine("Caderniho de telefones:");
if(phoneBook.Count == 0){
    Console.WriteLine{"Agenda Vazia"};
}else{
    int i = 1;
    foreach(DictionaryEntry entry in phoneBook){
        Console.WriteLine($"{i}. {entry.Key} - {entry.Value}");
        i++;
    }
} 


//Busca por nome
Console.WriteLine ("");
Console.WriteLine ("Busca por Nome: ")
string name = Console.ReadLine ();


if(phoneBook.Contains (name)){
    string number = (string)phoneBook[name]
    Console.WriteLine(name + " - " + number)
}else{
    Console.WriteLine ($"{name} não encontrado")
}

//

Dicionarios

//
Dictionary<string, string> (){
    {"Dom Pedrão II", "123456"},
    {"Joaquim jose da silva xavie", "112233"}
};

//obtendo valor do dicionario
string value = dic["Dom Pedrão II"]

dic["Dom Pedrão II"] = "666";

foreach(KeyValuePair<string, string> pair in dic){
    Console.WriteLine ("" + pair.Key + " " + pai.Value);
}