List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// Consulta de ejemplo: imprime todas las erupciones de estratovolcán
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
// ¡Ejecute las tareas de asignación aquí!

Console.WriteLine("Primera Consulta LinQ");

//1. Utilice LINQ para encontrar la primera erupción que se produce en Chile e imprima el resultado.

Eruption? primeraErupcionChile = eruptions.FirstOrDefault(c => c.Location == "Chile");
if(primeraErupcionChile != null)
{
    Console.WriteLine($"El nombre del volcán es:{primeraErupcionChile.Volcano}, año:{primeraErupcionChile.Year}, Locación: {primeraErupcionChile.Location}, Metros de elevación: {primeraErupcionChile.ElevationInMeters}, y tipo: {primeraErupcionChile.Type}");
}
Console.WriteLine("__-__");

Console.WriteLine("Segunda Consulta LinQ");
//2. Encuentre la primera erupción en la ubicación de "Hawaiian Is" e imprímala. Si no se encuentra ninguno, imprima "No se encontró ninguna erupción hawaiana".
Eruption? hawaiian = eruptions.FirstOrDefault(c => c.Location == "Hawaiian Is");
if(hawaiian != null)
{
    Console.WriteLine($"El nombre del volcán es:{hawaiian.Volcano}, año:{hawaiian.Year}, Locación: {hawaiian.Location}, Metros de elevación: {hawaiian.ElevationInMeters}, y tipo: {hawaiian.Type}");
}
else
{
    Console.WriteLine("No se encontró ninguna erupción hawaiana");
}
Console.WriteLine("__-__");

Console.WriteLine("Tercera Consulta LinQ");
//3.Busque la primera erupción posterior al año 1900 Y en "Nueva Zelanda", luego imprímala.
Eruption? primera_NZ1900 = eruptions.FirstOrDefault(c => c.Year > 1900 && c.Location =="New Zealand");
if(primera_NZ1900 != null)
{
    Console.WriteLine($"El nombre del volcán es:{primera_NZ1900.Volcano}, año:{primera_NZ1900.Year}, Locación: {primera_NZ1900.Location}, Metros de elevación: {primera_NZ1900.ElevationInMeters}, y tipo: {primera_NZ1900.Type}");
}
else
{
    Console.WriteLine("No se encontró ninguna coincidencia");
}
Console.WriteLine("__-__");

Console.WriteLine("Cuarta Consulta LinQ");
//4.Encuentre todas las erupciones donde la elevación del volcán sea superior a 2000 m e imprímalas.
IEnumerable<Eruption> allErupcion_ElevationInMeters = eruptions.Where(c => c.ElevationInMeters > 2000);
PrintEach(allErupcion_ElevationInMeters, "-ElevationInMeters > 2000");

Console.WriteLine("__-__");

Console.WriteLine("5° consulta Linq");
//5. Encuentra todas las erupciones donde el nombre del volcán comienza con "L" e imprímelas. Imprima también el número de erupciones encontradas.
IEnumerable<Eruption> allName_L = eruptions.Where(c => c.Volcano.StartsWith("L"));
PrintEach(allName_L, "Todas las Erupciones donde el nombre comienza con L");
Console.WriteLine($"El numero de erupciones encontardas es:{allName_L.Count()}");
Console.WriteLine("__-__");

Console.WriteLine("6° consulta LinQ");
//6. Encuentre la elevación más alta e imprima solo ese número entero (Sugerencia: ¡busque cómo usar LINQ para encontrar el máximo!)
int maxValue = eruptions.Max(c => c.ElevationInMeters);
Console.WriteLine($"La Elevación más alta es: {maxValue}");
Console.WriteLine("__-__");

Console.WriteLine("7° consulta LinQ");
//7. Utilice la variable de elevación más alta para buscar e imprimir el nombre del volcán con esa elevación.
Eruption? nameMaxElevation = eruptions.FirstOrDefault(c => c.ElevationInMeters == maxValue);
if(nameMaxElevation != null)
{
    Console.WriteLine($"El nombre del Volcan con más Elevación es:{nameMaxElevation.Volcano}");
}
Console.WriteLine("__-__");

Console.WriteLine("8° Consulta LinQ");
//8.Imprima todos los nombres de los volcanes alfabéticamente.
IEnumerable<string> allName = eruptions.OrderBy(c => c.Volcano).Select(c => c.Volcano);
PrintEach(allName, "Nombres de los volcanes en ordern Alfabetico");
Console.WriteLine("__-__");

Console.WriteLine("9° Consulta LinQ");
//9. Imprima todas las erupciones que ocurrieron antes del año 1000 EC en orden alfabético según el nombre del volcán.
IEnumerable <Eruption>? complixNamesOrder = eruptions.Where(c => c.Year < 1000).OrderBy(c => c.Volcano);
PrintEach(complixNamesOrder, "Erupciones antes del año 1000 EC en orden alfabetico");
Console.WriteLine("__-__");

Console.WriteLine("10° Consulta LinQ");
//10. BONIFICACIÓN: rehaga la última consulta, pero esta vez use LINQ para seleccionar solo el nombre del volcán para que solo se impriman los nombres.
IEnumerable <string>? complixNamesOrderOnlyNames = eruptions.Where(c => c.Year < 1000).OrderBy(c => c.Volcano).Select(c => c.Volcano);
PrintEach(complixNamesOrderOnlyNames, "Erupciones antes del año 1000 EC en orden alfabetico");

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
// Método auxiliar para imprimir cada elemento en una Lista o IEnumerable. ¡Esto debería permanecer al final de su clase!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}