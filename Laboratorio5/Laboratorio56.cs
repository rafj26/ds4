Dictionary<string, string> paisesYCapitales = new Dictionary<string, string>
{
    {"Francia", "Paris"},
    {"Espana", "Madrid"}, 
    {"Italia", "Roma"}
};

foreach (KeyValuePair<string, string> par in paisesYCapitales)
{
    Console.WriteLine("La capital de " +par.Key+ "es" + par.Value+ ".");
}