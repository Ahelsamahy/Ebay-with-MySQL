using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFEbayServer
{
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
   [ServiceContract]
   public interface IService1
   {

      [OperationContract]
      [FaultContract(typeof(UnsuccessfullLoginFault))]
      string login(string username, string password);

      [OperationContract]
      [FaultContract(typeof(ServiceData))]
      ServiceData TestConnection(string strConnectionString);

      [OperationContract]
      string bye();
      [OperationContract]
      string Add(string name, string code, int price, string uid);

      [OperationContract]
      List<Product> List();
      [OperationContract]
      string Bid(string code, int price, string uid);
      // TODO: Add your service operations here

      //used functions 
      [OperationContract]
      Car GetCars(int id);

      [OperationContract]
      void SaveCars(Car employee);

      [OperationContract]
      void DeleteCars(int id);

      [OperationContract]
      List<Car> allCars();



      [OperationContract]
      void SaveUsers(users normalUser);

      [OperationContract]
      void DeleteUsers(int id);

      [OperationContract]
      users GetUsers(int id);

      [OperationContract]
      List<users> allUsers();
   }
   [DataContract]
   public class ServiceData
   {
      [DataMember]
      public bool Result
      { get; set; }
      [DataMember]
      public string ErrorMessage
      { get; set; }
      [DataMember]
      public string ErrorDetails
      { get; set; }
   }
   [DataContract]
   public class UnsuccessfullLoginFault
   {
      private string report;

      public UnsuccessfullLoginFault(string message)
      {
         this.report = message;
      }

      [DataMember]
      public string Message
      {
         get { return this.report; }
         set { this.report = value; }
      }
   }

   // Use a data contract as illustrated in the sample below to add composite types to service operations.
   [DataContract]
   public class Product
   {

      string name, code, user;
      [DataMember]
      public string User
      {
         get { return user; }
         set { user = value; }
      }
      [DataMember]
      public string Code
      {
         get { return code; }
         set { code = value; }
      }
      [DataMember]
      public string Name
      {
         get { return name; }
         set
         {
            if (name.Length < 5)
            {
               throw new FaultException("name can't be less than 5 character");
            }
            else if (string.IsNullOrEmpty(name))
            {
               throw new FaultException("name can't be empty");
            }
            name = value;
         }
      }
      int curr_price;
      [DataMember]
      public int Curr_price
      {
         get { return curr_price; }
         set { curr_price = value; }
      }

      public Product()
      {

      }
      public Product(string name, string code, int curr_price)
      {
         this.name = name; this.code = code; this.curr_price = curr_price;
      }

   }

   public class Car
   {
      private int carID;
      private string type, brand, license_plate;
      [DataMember]
      public int CarID
      {
         get { return carID; }
         set { carID = value; }
      }

      [DataMember]
      public string Type
      {
         get { return type; }
         set { type = value; }
      }
      [DataMember]
      public string Brand
      {
         get { return brand; }
         set { brand = value; }
      }
      [DataMember]
      public string License_plate
      {
         get { return license_plate; }
         set { license_plate = value; }
      }

      public override string ToString()
      {
         StringBuilder sb = new StringBuilder();
         sb.Append(String.Format("|{0,5}|{1,5}|{2,5}|{3,5}|",
                                  this.CarID, this.Type, this.Brand, this.License_plate));
         return sb.ToString();
      }

   }

   public class rented_car
   {
      private int cardID, userID;
      [DataMember]
      public int CarID
      {
         get { return cardID; }
         set { cardID = value; }
      }
      public int UserID
      {
         get { return userID; }
         set { userID = value; }
      }

      public override string ToString()
      {
         StringBuilder sb = new StringBuilder();
         sb.Append(String.Format("|{0,5}|{1,5}|", this.UserID, this.CarID));
         return sb.ToString();
      }
   }

   public class users
   {
      private int userID;
      private string firstName, secondName;

      [DataMember]
      public int UserID
      {
         get { return userID; }
         set { userID = value; }
      }

      [DataMember]
      public string FirstName
      {
         get { return firstName; }
         set { firstName = value; }
      }
      [DataMember]
      public string SecondName
      {
         get { return secondName; }
         set { secondName = value; }
      }

   }
}
