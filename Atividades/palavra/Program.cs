string firstName = "André";
string lastName = "Nascimento";

string note = lastName.ToUpper() + " " + firstName;

string initials = lastName[0] + " " + firstName[0];


Console.WriteLine ("" + initials);

// Formatação de String
string texto = string.Format ("{0} {1} nascido em {2}", firstName, lastName, "1984");

Console.WriteLine (texto);

//C# é uma linguagem filha do c++
//totalmente orientada a ogjetos
//portanto tudo dentro do c é descendente
//do tipo object

int age = 24;
object ageBoxing = age;
int ageUnboxing = (int) ageBoxing;