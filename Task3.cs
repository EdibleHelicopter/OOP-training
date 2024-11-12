using System.ComponentModel;
using System.Dynamic;
using System.Security.Cryptography;


class Program
{
static void Main()
{
 Ride[] rides = new Ride[3];
 new Ride(false);

}
}
 class Dispatcher
 {

  public void RideRequest(RequestDistribution requestDistribution)
  {
   requestDistribution.RideRequest();
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
  public bool IsCarAvailable;

  public Driver(bool IsCarAvailable, int id)
  {
   this.IsCarAvailable = IsCarAvailable;
   this.id = id;
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
  public bool IsWorking {get; set;}
  

  public Car(bool IsWorking, int CarID)
  {
    this.IsWorking = IsWorking;
    this.CarID = CarID;
    
  }

  public void CarFixRequest()
  {
    IsWorking = true;
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
  }
 }

