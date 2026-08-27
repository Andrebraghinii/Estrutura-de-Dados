//arrayLists

using System.Collections;
using System.Globalization;

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

//listas genericas

List<double> numbers = new List<double>();
Console.WriteLine("Digite 'sair' para encerrar.");

bool run  = true;
do{
    Console.WriteLine("Digite um número: ");
    String numberStr = Console.ReadLine();
    if(numberStr.ToLower() == "sair"){
        run = false;
        Console.WriteLine("Processo encerrado.");
    }else{
        //Validação da entrada do usuario para checar se de fato é um número
        if(!double.TryParse(numberStr, System.Globalization.NumberStyles.Float, new NumberFormatInfo(), out double number)){
            Console.WriteLine("Você não digitou um numero.");
            continue;
        }

        numbers.Add(number);
        Console.WriteLine("A media dos valores digitados é: " + numbers.Average());
    }
}while(run);

//LISTAS DE TIPOS ABSTRATOS DE DADOS (TAD)

List<Person> people = new List<Person>();

//criar uma variavel do tipo person

Person p1 = new Person();
p1.Name = "João";
p1.Age = 42;
p1.Nacionality = CountryEnum.BR;

people.Add(p1);

//adicionando a lista online
people.Add(new Person(){Name = "Mary", Age = 39,Nacionality = CountryEnum.AR});

people.Add(new Person(){Name = "Carlos", Age = 24, Nacionality = CountryEnum.US});

people.Add(new Person(){Name = "Juan", Age = 67, Nacionality = CountryEnum.PY});

//exemplo de ordenação de lista generica utilizando LINQ

List<Person> results = people.OrderBy(p=> p.Name).ToList();

//percorresmos a lista

foreach(Person p in results){
    Console.WriteLine( 
        $"Nome: {p.Name}, Idade: {p.Age}, Nac: {p.Nacionality}");
}