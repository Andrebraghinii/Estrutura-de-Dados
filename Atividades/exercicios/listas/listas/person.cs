//aqui, criamos uma classe de tipo de dado abstrato

public class Person{

    public string Name {get; set;}

    public int Age {get; set;}

    public CountryEnum Nacionality {get; set;}
}


//enum = enumerador. Difere de classe. É uma lista de valores
public enum CountryEnum{
    BR, US, AR, PY
}