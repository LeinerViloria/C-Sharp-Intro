
using introByConsole;

class Program
{
    static void Main(string[] arg)
    {
        variables();
        Console.Write("\n\nSe ejecuto el primer metodo\n\n");
        primitiveVariables();
        Console.Write("\n\nSe ejecuto el segundo metodo\n\n");
        Console.Write("\n\nSe crea un objeto\n\n");
        Calculator calc = new Calculator();
        Console.Write("\n\nSuma 20 + 30 = " + calc.add(20, 30)+ "\n\n");
        Console.Write("\n\nDivide 40 / 20 = " + calc.divide(40, 20)+ "\n\n");
        Console.Write("\n\nDivide 40 / 0 = " + calc.divide(40, 0)+ "\n\n");
    }

    static void variables()
    {
        //El tipo de dato var, acepta cualquier tipo de dato
        //Reconoce el tipo de dato según el valor dado

        var number = 9;
        var floatNumber = 9.8;
        //Comillas simples para caracteres
        var letter = 'a';
        //Comillas dobles para cadenas de caracter
        var words = "fulano de tal";

        var flag = true;

        var numbers = new[] {2, 3, 4, 5, 1};
        var city = new {Country="England", City="London", Place="Europa", People=8982000000};

        //A diferencia de un array, permite un tamaño dinamico
        var list = new List<int>();
        list.Add(6);
        list.Add(10);
        list.Add(7);
        list.Add(23);

        String firstString = String.Join(" ", numbers);
        String secondString = "";
        //Se recorre la lista
        foreach (int currentNumber in list)
        {
            secondString += currentNumber + " ";
        }

        Console.Write("El tipo de dato var recibe cualquier tipo de variable:"+
                      "\nEntero: "+number+
                      "\nFlotante: "+floatNumber+
                      "\nLetras con la comilla simple: "+letter+
                      "\nCadenas de caracter: "+words+
                      "\nVariables booleanas: "+flag+
                      "\nArreglos: "+firstString+
                      "\nArray asociativo:\n"+city+
                      "\nListas: \n"+secondString);

    }

    static void primitiveVariables()
    {
        string ourName = "Soluciones T&I JLDI";
        int peopleHere = 5;
        long numberWithTheBiggestRange = 2*10^8;

        Console.Write("Nuestro nombre es "+ourName+
                      "\nSomos "+peopleHere+" en el grupo"+
                      "\nEstuvimos probando una variable long, su valor es:"+
                      numberWithTheBiggestRange);
    }
}
