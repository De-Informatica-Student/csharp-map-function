# Map Uitgelegd met CSharp

De map functie is een van de functie in de map / filter en reduce serie.
Dit zijn belangrijke functies voor iedereen die werkt met reeksen en verzamelingen.
De map functie is bedoeld om alle items in een reeks aan te passen doormiddel van een functie.

## De functie

Veel (beginnende) programmeurs realiseren zich niet dat ze tijdens
het leren van programmeren best vaak een vorm van de map functie schrijven.
Kleine opdrachten zoals ```verdubbel alle getallen in een reeks```,
```verander de waardes van integer naar string``` en ```geef alle lege waardes een standaard waarde```
resulteren allemaal in een vorm van de map functie.
Het principe achter al deze functie is hetzelfde.
Er is een reeks of verzameling.
Door middel van herhalingen gaan we lang alle items in de reeks.
We passen iedere waarde aan van de reeks.
De nieuwe reeks wordt teruggegeven als resultaat.

```csharp
/**
Function that doubles the values of an array of integers
@param inputArray: array of integers
@return array of integers with the values doubled
*/
int[] DoubleValues(int[] inputArray) 
{
    // Create a new array with the same length as the input array
    int[] resultArray = new int[inputArray.Length];
    
    // Loop through the input array
    for (int i = 0; i < inputArray.Length; i++)
    {
        // Double the original value and store it in the new array
        resultArray[i] = inputArray[i] * 2;
    }

    // Return the new array
    return resultArray;
}

/**
Function that converts an array of integers to an array of strings
@param inputArray: array of integers
@return array of strings
*/
string[] IntArrayToStringArray(int[] inputArray) 
{
    // Create a new array with the same length as the input array
    string[] resultArray = new string[inputArray.Length];
    
    // Loop through the input array
    for (int i = 0; i < inputArray.Length; i++)
    {
        // Convert the integer to a string and store it in the new array
        resultArray[i] = inputArray[i].ToString();
    }

    // Return the new array
    return resultArray;
}

/**
Function that fills empty values in an array with a default value
@param inputArray: array of strings
@param defaultValue: string to use as default value
@return array of strings with empty values filled with the default value
*/
string[] FillEmptyValues(string[] inputArray, string defaultValue) 
{
    // Create a new array with the same length as the input array
    string[] resultArray = new string[inputArray.Length];
    
    // Loop through the input array
    for (int i = 0; i < inputArray.Length; i++)
    {
        // If the value is empty, use the default value
        resultArray[i] = inputArray[i] == "" ? defaultValue : inputArray[i];
    }

    // Return the new array
    return resultArray;
}
```

## Lambda's

De map functie zit ingebouwd in vele programmeertalen, zijd het onder verschillende namen.
JS en Python kennen de functie als map,
PHP gooit er wat PHP magie overheen en noemt het de array_map,
C# gaat echter voor de naam ‘select’.Hoe de map ook heet, ze volgen allemaal hetzelfde principe:
we willen de items in een reeks aanpassen, ongeacht de reeks en ongeacht de aanpassing.
Laten we beginnen met het variabel maken van de code.
Programmeertalen hebben een manier om een functie mee te kunnen geven als parameter.
Dit kan vele namen hebben: lamba, anonieme functies, pijl-functies, enz.

```csharp
/** 
    Een normale functie wordt apart bijgehouden van het geheugen
    Om de functie uit te voeren wordt de referentie naar de functie vervangen met een GOTO
    Dit gebeurd tijdens het compileren van de applicatie
    Zo weet de computer welke code er uitgevoerd moet worden
*/

// Dus deze code
string HelloWorld() {
    return "Hello World!";
}

Console.WriteLine(HelloWorld());

// Veranderd op de achtergrond in
string HelloWorld() {
    return "Hello World!";
}

Console.WriteLine(GOTO 1);

/**
    Voor lamba's werkt dit anders, de functie wordt opgeslagen als waarde
    Net als variabele kunnen we deze oproepen met de naam
    De verwerking van de code werkt net iets anders.
*/

// Een referentie naar een lambda functie...
Func<string> HelloWorld = () => "Hello World!";
Console.WriteLine(HelloWorld());

// ...wordt opgehaald als een waarde...
Func<string> HelloWorld = () => "Hello World!";
Console.WriteLine(() => "Hello World!");

// ...en dan uitgevoerd.
Func<string> HelloWorld = () => "Hello World!";
Console.WriteLine("Hello World!");
```

Bij het schrijven van een normale functie,
wordt de locatie hiervan opgeslagen door de compiler of interpreter,
de verwijzingen naar de functie worden vervangen door zogeheten ‘ga-naar’-pointer.
Die aangeven waar in de code de functie te vinden is.
Een lambda wordt echter in het geheugen opgeslagen als iedere andere waarde.
Dit betekent dat we een lambda functie kunnen opslaan in een variabele of mee kunnen geven als argument.

```csharp
/**
The map function with lambda expression
@param int[] inputArray The input array
@param Func<int, int> func The function to apply to each value in the array
@return int[] The new array with the function applied to each value
*/
int[] IntegerMap(int[] inputArray, Func<int, int> func)
{
    // Create a new array with the same length as the input array
    int[] resultArray = new int[inputArray.Length];
    
    // Loop through the input array
    for (int i = 0; i < inputArray.Length; i++)
    {
        // Apply the function to the original value and store it in the new array
        resultArray[i] = func(inputArray[i]);
    }

    // Return the new array
    return resultArray;
}

// Test the function
int[] numbers = { 1, 2, 3, 4, 5 };
int[] doubledNumbers = IntegerMap(numbers, x => x * 2);
int[] addedNumbers = IntegerMap(numbers, x => x + 1);
int[] subtractedNumbers = IntegerMap(numbers, x => x - 1);
```

## Generiek

We hebben echter nog één probleem.
We zitten nog steeds vast aan reeksen van een bepaald type,
met uitzondering van talen als Python en JavaScript die losjes omgaan met de types van waardes.
De oplossing: het variabel maken van types, we gaan generieke code schrijven.
Generieke waardes zijn een belangrijk onderdeel van statische getypte programmeertalen.
Dit zijn programmeertalen waarbij de types van waardes expliciet moeten worden aangegeven.
Een generieke waarde, of generiek type, zorgt ervoor dat we het type variabel kunnen maken.

```csharp
// We beginnen met een standaard map functie zoals eerder
string[] Map(int[] inputArray) { … }

// Vervolgens geven we aan dat we twee variabele types willen gebruiken
string[] Map<InputType, OutputType>(int[] inputArray) { … }

// We vervangen het type van de input variabele door de generieke versie
string[] Map<InputType, OutputType>(InputType[] inputArray) { … }

// We doen hetzelfde voor de output
OutputType[] Map<InputType, OutputType>(InputType[] inputArray) { … }

// Om aan standaarden te voldoen, gebruiken we T en U i.p.v. de namen
// Als je meer generieke types zou hebben, blijf je gewoon het alfabet volgen
// Uiteindelijk is het voorkeur
U[] Map<T, U>(U[] inputArray) { … }
```

De generieke types kunnen gebruikt worden om de map functie te maken.
We gaan hiervoor twee generieke types gebruiken om de mogelijkheid
te geven een waarde naar iets anders om te zetten.
We gaan ervoor zorgen dat we dezelfde functie kunnen toepassen op meerdere items.

```csharp
/**
The complete map function with lambda expression and generic types
@param T[] inputArray The input array
@param Func<T, U> func The function to apply to each value in the array
@return U[] The new array with the function applied to each value
*/
U[] Map<T, U>(T[] inputArray, Func<T, U> func)
{
    // Create a new array with the same length as the input array
    U[] resultArray = new U[inputArray.Length];
    
    // Loop through the input array
    for (int i = 0; i < inputArray.Length; i++)
    {
        // Apply the function to the original value and store it in the new array
        resultArray[i] = func(inputArray[i]);
    }

    // Return the new array
    return resultArray;
}

// Test the function
int[] numbers = { 1, 2, 3, 4, 5 };
int[] doubledNumbers = Map(numbers, x => x * 2);
string[] stringNumbers = Map(numbers, x => x.ToString());
bool[] isEvenNumbers = Map(numbers, x => x % 2 == 0);
```
