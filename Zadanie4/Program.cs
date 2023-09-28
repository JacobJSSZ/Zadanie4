var name = "Ewa";
var gender = "Kobieta";
var age = 33;

if (gender == "Kobieta" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (age < 30 && gender == "Kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (gender != "Kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
