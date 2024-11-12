using System.ComponentModel;
using System.Dynamic;
using System.Security.Cryptography;


class Program
{
static void Main()
{
 Ride[] rides = new Ride[3];
 new Ride(false);
 new Ride(false);
 new Ride(true);
 foreach (Ride i in rides)
 {
Console.WriteLine(i);
 }

}
}
 class Dispatcher
 {

  public void RideRequest(RequestDistribution requestDistribution)
  {
   requestDistribution.RideRequest();
  }

  public void RemoveDriver()
  {
   
  }
 }

 interface RequestDistribution
 {
  void RideRequest();
 }



///Водитель
 class Driver : RequestDistribution
 {
  public int id {get; set;}
  public bool IsBusy {get; set;} 

  
  public Driver(int id, bool IsBusy)
  {
    this.id = id;
    this.IsBusy = IsBusy;
  }

  public void CarFixRequest(FixRequest request)
  {
   request.CarFixRequest();
  }

  public void RideRequest()
  {
   id = 12345;
  }

 }


 interface FixRequest
 {
  void CarFixRequest();
 }

 //Машина

 class Car : FixRequest, RequestDistribution
 {
  public int CarID {get; set;}
  public bool IsBroken {get; set;}
   public bool IsCarAvailable {get; set;}
  
  public void CarBroke()
  {
    if (IsBroken == true)
    {
      Console.WriteLine("Машина сломана! Требуется починка!");
    }
  }


  public Car(bool IsBroken, int CarID, bool IsCarAvailable)
  {
    this.IsBroken = IsBroken;
    this.CarID = CarID;
    this.IsCarAvailable = IsCarAvailable;
    
  }

  public void CarFixRequest()
  {
    IsBroken = false;
  }

  public void RideRequest()
  {
    CarID = 12121;
  }

 }

 //Поездка
 
 class Ride
 {
  public bool IsComplited;
  
  public Ride(bool IsComplited)
  {
    this.IsComplited = IsComplited;
    Console.WriteLine("Машина починена!");
  }
 }

