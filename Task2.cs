using System.Dynamic;
using System.Reflection.Metadata;

/*
class Abonent
{
    public int id {get; set;}
    public string LastName {get; set;}
    public string Name {get; set;}
    public string Surname {get; set;}
    public int CreditCardNumber {get; set;}
    public int Debit {get; set;}
    public int Credit {get; set;}
    public int CityConversationDuration {get; set;}
    public int CountryConversationDuration {get; set;}

    public Abonent (int id, string LastName, string Name, string Surname, int CreditCardNumber, int Debit, int Credit, int CityConversationDuration, int CountryConversationDuration)
    {
     this.id = id;
     this.LastName = LastName;
     this.Name = Name;
     this.Surname = Surname;
     this.CreditCardNumber = CreditCardNumber;
     this.Debit = Debit;
     this.Credit = Credit;
     this.CityConversationDuration = CityConversationDuration;
     this.CountryConversationDuration = CountryConversationDuration;

    }
}

class Program
{
 static void Main()
 {
  int AbonentConversationLimit;
  Abonent[] AbonentList = new Abonent[3];
  new Abonent(11111, "Рыжов", "Александр", "Сергеевич", 111111, 500, 1000, 100, 10);
  new Abonent(22222, "Конышев", "Григорий", "Андреевич", 222222, 1000, 100, 1000, 15);
  new Abonent(33333, "Кирпа", "Иван", "Андреевич", 333333, 1000, 1000, 120, 12);
  var SortedPeople = AbonentList.OrderBy(Surname => Surname.Surname);
  
  foreach (var Surname in SortedPeople) 
  Console.WriteLine($"{Surname.Surname}");
  {
   

  }
 }
}
*/