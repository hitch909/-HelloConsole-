Console.Write("введите имя пользователя: ");
string name=Console.ReadLine();
if (name.ToLower()=="маша")
{
    Console.WriteLine("Ура, это же МАША");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(name);
}