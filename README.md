<p align="center">
  <img src="img/lara-logo.png?raw=true">
</p>
<p align="center">
  <img src="https://img.shields.io/badge/License-MIT-blue.svg">
  <a href="https://www.nuget.org/packages/Lara"><img src="https://img.shields.io/nuget/v/Lara.svg"></a>
</p>

<hr>

## Installation
Package Manager
`Install-Package Lara`

.NET CLI
`dotnet add package Lara`

## Randomizations
#### Basic
```csharp
using Lara;

// Guid
Guid randomGuid = Randomic.Basic.Guid();

// Ints
int randomInt = Randomic.Basic.Int();
int randomIntBetween1And100 = Randomic.Basic.Int(1, 100);
int randomNegativeInt = Randomic.Basic.Int(int.MinValue, -1);

// Double
Double randomDouble = Randomic.Basic.Double();
Double randomDoubleBetween1And100 = Randomic.Basic.Double(1.0, 100.0);
Double randomNegativeInt = Randomic.Basic.Double(double.MinValue, -1.0);

// Byte
byte randomByte = Randomic.Basic.Byte()

// Text
string randomText = Randomic.Basic.Text(); // Example: "MFYoiWSxFhBMQzji"
string randomTextWithSize = Randomic.Basic.Text(32); // Example: "MFYoiWSxFhBMQzjiOfkkxEITpIpPqucl"

// Alphanumeric
string randomAlpha = Randomic.Basic.Alphanumeric(); // Example: "PGcvoaV7GnBPT0qo"
string randomAlphaWithSize = Randomic.Basic.Alphanumeric(32); // Example: "PGcvoaV7GnBPT0qoRmrr7FJXxKxTz3is"

// Numeric text
string randomNumeric = Randomic.Basic.Numeric(); // Example: "3258754027134077"
string randomNumericWithSize = Randomic.Basic.Numeric(32); // Example: "32587540271340773788012482849968"

// Date
DateTime randomDate = Randomic.Basic.Date(); // Example: 2018-09-04
DateTime randomDateBetween = Randomic.Basic.Date(new DateTime(1986, 01, 01), new DateTime(1986, 05, 18)); // Example: 1986-01-23

// DateTime
DateTime randomDate = Randomic.Basic.DateTime(); // Example: 2018-09-04 12:13:44
DateTime randomDateBetween = Randomic.Basic.DateTime(new DateTime(1986, 05, 18, 08, 40, 10), new DateTime(1986, 05, 18, 08, 40, 20)); // Example: 1986-01-23 22:44:23

// Boolean
bool randomBool = Randomic.Basic.Boolean();

// Boolean with probability of true
bool randomBoolBias = Randomic.Basic.Boolean(0.75); // 75% of chance to be true

// Even odd
string color = Randomic.Basic.EvenOdd(counter, "#fff", "#ccc");
```

#### Internet
```csharp
using Lara;

// Email
string randomEmail = Randomic.Internet.Email(); // Example: "denisecavalcanti@hotmail.org"

// URL
string randomUrl = Randomic.Internet.Url(); // Example: "http://www.mfyoiwsxfhbmqzji.org"
Uri randomUri = Randomic.Internet.Uri(); // Example: "http://www.mfyoiwsxfhbmqzji.org/"

// Username
string randomUsername = Randomic.Internet.Username(); // Example: "creagengisondo"
```

#### People
```csharp
using Lara;
Randomic.SetLanguage(Language.EnUs);

// Names
string randomFirstName = Randomic.People.FirstName(); // Example: "Creagen"
string randomLastName = Randomic.People.FirstName(); // Example: "Gisondo"
string randomFullName = Randomic.People.FullName(); // Example: "Creagen Gisondo"

// Prefix
string randomPrefix = Randomic.People.Prefix(); // Example: "Mrs."

// Ages
int randomAge = Randomic.People.Age(); // Example: 42
int randomAgeChild = Randomic.People.Age(AgeGroup.Child); // Example: 12
int randomAgeTeenager = Randomic.People.Age(AgeGroup.Teenager); // Example: 19
int randomAgeAdult = Randomic.People.Age(AgeGroup.Adult); // Example: 59
int randomAgeElder = Randomic.People.Age(AgeGroup.Elder); // Example: 100

// Birth dates (also acepts AgeGroups)
int randomBirthDate = Randomic.People.BirthDate(); // Example: 2016-12-22
```

#### Words
```csharp
using Lara;
Randomic.SetLanguage(Language.EnUs);

// Noun
string randomNoun = Randomic.Words.Noun(); // Example: "Control"

// Planets
string randomPlanet = Randomic.Words.Planet(); // Example: "Venus"
string randomExoPlanet = Randomic.Words.ExoPlanet(); // Example: "Galileo"

// Famous people
string famousPerson = Randomic.Words.FamousPerson(); // Example: "Emmeline Pankhurst"

// Brand
string randomBrand = Randomic.Words.Brand(); // Example: "DHL"

// Lorem Ipsum
string lorem = Randomic.Words.LoremIpsum();
string lorem2Paragraphs = Randomic.Words.LoremIpsum(paragraphs: 2);
```
#### Addresses
```csharp
using Lara;
Randomic.SetLanguage(Language.PtBr);

// Phone
IRandomPhone phone = Randomic.Address.Phone(); // Returns a complex object with number, country code and area code

// Full address (there are specific methods for each information such as Randomic.Address.State())
Console.WriteLine(Randomic.Address.FullAddress()); // Prints "Bosque Denise Galileo, 24867 - Jardim Assunção, Cuiabá - ES, 32587540"
```

#### Among values
```csharp
using Lara;

// Among array
string[] array = new string[] { "ABC", "DEF", "GHI" };
string randomValue = Randomic.Among.Strings(array);

int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int randomValue = Randomic.Among.Ints(array);

// Among enumerable
var enumerable = new List<string> { "ABC", "DEF", "GHI" };
string randomValue = Randomic.Among.Strings(enumerable);

var enumerable = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int randomValue = Randomic.Among.Ints(enumerable);
```

## Extension Methods
#### DateTime
```csharp
// First and last day of month
DateTime dt = new DateTime(2020, 02, 15);
DateTime firstDay = dt.FirstDayOfMonth(); // Returns 2020-02-01
DateTime lastDay = dt.FirstDayOfMonth(); // Returns 2020-02-29

// Brazilian Formats
DateTime dt = new DateTime(1986, 05, 18, 15, 40, 41);
string formated = dt.ToFormat(PreDefinedFormat.Brazilian); // Returns "18/05/1986"
string formatedWithTime = dt.ToFormat(PreDefinedFormat.BrazilianWithTime); // Returns "18/05/1986 15:40:41"

// United States formats
DateTime dt = new DateTime(1986, 05, 18, 15, 40, 41);
string formated = dt.ToFormat(PreDefinedFormat.American); // Returns "05/18/1986"
string formatedWithTime = dt.ToFormat(PreDefinedFormat.AmericanWithTime); // Returns "05/18/1986 03:40:41 PM"

// Other formats
DateTime dt = new DateTime(1986, 05, 18, 15, 40, 41);
string yearMonthDay = dt.ToFormat(PreDefinedFormat.YearMonthDay); // Returns "1986-05-18"
string yearMonthDayWithTime = dt.ToFormat(PreDefinedFormat.YearMonthDayWithTime); // Returns "1986-05-18 15:40:41"
string monthYear = dt.ToFormat(PreDefinedFormat.MonthYear); // Returns "05/1986"
```

#### Enumerable
```csharp
// Checks if a value is contained in a collection
var collection = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21 };
int valueA = 5;
int valueB = 6;
bool isInCollection = valueA.In(collection); // Returns true
bool isInCollection = valueB.In(collection); // Returns false
```

#### Object
```csharp
// Returns "" (empty) if an object is null
object isNull = null;
string value = isNull.EmptyIfNull(); // Returns ""
```

#### Text
```csharp
// Slices a text by the Left or Right
const string TEXT = "Lucca Abdalla";
string slicedLeft = TEXT.Left(5); // Returns "Lucca"
string slicedRight = TEXT.Right(5); // Returns "dalla"

// Removes the Accentuation
const TEXT = "áéíóúãõàèìòù";
string removed = TEXT.RemoveAccentuation(); // Returns "aeiouaoaeiou"
```

#### Throws If
```csharp
// Throws an Exception if a value is null, empty, zero, etc.
object objectNull = null;
objectNull.ThrowIfNoValue(nameof(objectNull)); // Throws ArgumentNullException
objectNull.ThrowIfNoValue<CustomException>("Message"); // Throws CustomException with the given message

string emptyString = "";
emptyString.ThrowIfNoValue(nameof(emptyString)); // Throws ArgumentNullException
emptyString.ThrowIfNoValue<CustomException>("Message")); // Throws CustomException with the given message

int intZero = 0;
intZero.ThrowIfZero(nameof(intZero)); // Throws ArgumentNullException
intZero.ThrowIfZero<CustomException>("Message")); // Throws CustomException with the given message
```

## Entity Builder
It helps you to fill an Entity with randomic information. Very useful for unit tests.
Consider this Entity:

```csharp
public class Actress {
    public string Name { get; set; }
    public int Age { get; set; }
}
```

You can easily fill an instance like this:
```csharp
var actress = EntityBuilder.Fill<Actress>().Build();
```

Since you have an string and an int properties, you will have an object like this:
```csharp
{
    Name: "LCYXFQLpNKmBHiOJ",
    Age: 1971145117
}
```

It doesn't look good. In this case we can add some rules to our object filling:
```csharp
var actress = EntityBuilder
    .Fill<Actress>()
    .WithRule(x => x.Name, () => { return Randomic.People.FullName(); })
    .WithRule(x => x.Age, () => { return Randomic.People.Age(AgeGroup.Adult); })
    .Build();
```

Now we have something way better:
```csharp
{
    Name: "Julie Grace",
    Age: 27
}
```
We can also fill a list of objects:
```csharp
List<Actress> list = EntityBuilder.Fill<Actress>().BuildList(10);
```

## Properties Stringifier
Please see this project for more information: https://github.com/fellipeborges/properties-stringifier

## Consolindo
A set of methods to help you build console applications in a more colorful (and meaningful) way.

#### Write directly in some color
```csharp
Consolindo.WriteGreen("Everything is ok");
Consolindo.WriteYellow("This is a warning");
Consolindo.WriteRed("Something went wrong");
Consolindo.Write("Why not cyan?", System.ConsoleColor.Cyan);
Consolindo.Write("Automatically I'm back to the default color.");
```

#### Write a title
```csharp
Consolindo.WriteTitle("IMPORTING");
/* Prints something like:
---------------------------------------------------------------
IMPORTING
---------------------------------------------------------------
*/
```

#### Read data from user showing a message
```csharp
var key = Consolindo.ReadKey("Message");
var line = Consolindo.ReadLine("Message");
```

#### New line
```csharp
Consolindo.NewLine();
```

#### Wait until user types anything
```csharp
Consolindo.Wait();
```

That's all. 😊
