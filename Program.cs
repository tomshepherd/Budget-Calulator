using System; 
namespace Program{
    public class App{

    static  void Main(string [] args){

        Income i = new Income();
        //Bill b = new Bill();

       

        /*while(true){

             string input = Console.ReadLine();
             string input2 = Console.ReadLine();

            double amount = double.Parse(input2);
            b.createBill(input, amount);

             b.ShowBills();

        }
        */


    
    Console.WriteLine("Please Enter Your income ");
    string input = Console.ReadLine();
    i.Wage = double.Parse(input);
    Console.WriteLine(i.IncomeAfterTax());
        }

    }
     
    
    


}

