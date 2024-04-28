namespace Program{

    public class Bill(){

         private int _id = 0;
         private static int _counter = 0;
         private string _name;
         private double _amount;
         private List<Bill> bills = new List<Bill>();

         public string Name{

            get{return _name;}
            set{_name = value;}
         } 

         public double Amount{
            get{return _amount;}
            set{_amount = value;}
         }

         public int Id{
            get{return _id;}
            set{_id = value;}
            
         }


         public void createBill(string name, double amount){

            Bill b = new Bill();
            b.Id = _counter;
            b.Name = name;
            b.Amount = amount;
            bills.Add(b);
            _counter++;
            
         }

         public void ShowBills(){

            foreach(Bill b in bills){

                Console.WriteLine( $" ID: {b.Id } Name: {b.Name}, Amount: £{b.Amount}");
            }
         }

         public void UpdateBill(int id, string  name,double amount){

            foreach(Bill b in bills){
               if(id == b.Id && name != null){

                  Name = name;

               }
               else if(id == b.Id && amount != null){
                  Amount = amount;
               }
            }
         }

         public void DeleteBill(int id){
            foreach(Bill b in bills){
               if(id == b.Id){
                  bills.Remove(b);
               }
            }
         }




    
    }

   

}