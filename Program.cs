using System; 
namespace Program{
    public class App{

    static  void Main(string [] args){

         
        

        Income i = new Income();
        Bill b = new Bill();

        
        Console.WriteLine("-----------------");
        Console.WriteLine("Budget Calculator");
        Console.WriteLine("-----------------");

      

        while(true){

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Choose an option (enter numerical value)");
            Console.WriteLine("1: Enter Income ");
            Console.WriteLine("2: Bills Menu ");
            Console.WriteLine("9: Exit");
            Console.WriteLine("----------------------------------------");
            string input = Console.ReadLine();

            switch(input){
                case "1":
                    Console.WriteLine("Enter Income");
                    i.Wage = double.Parse(Console.ReadLine());
                    Console.WriteLine(i.IncomeAfterTax());
                    break;
                case "2":
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Chose an option: (enter numerical value)");
                    Console.WriteLine("1: Create Bill");
                    Console.WriteLine("2: Update Bill");
                    Console.WriteLine("3: Delete Bill");
                    Console.WriteLine("4:Show Bills");
                    Console.WriteLine("----------------------------------------");
                    BillsMenu(b);

                    break;
                case"9":
                    return;
                    break;
            }

        }

        }

        public static void BillsMenu(Bill b){

            
            
            string name;
            int id;
            double amount; 
            string input = Console.ReadLine();
        

            while(input != "9"){
                
                switch(input){
                    case "1":
                        Console.WriteLine("Enter bill name");
                        name = Console.ReadLine();Console.WriteLine("------------------------------------");
                        Console.WriteLine("Enter bill amount");
                        amount = double.Parse(Console.ReadLine());
                        b.createBill(name, amount);
                        break;
                    case "2":
                        //b.UpdateBill();
                        break;
                    case "3":
                        Console.WriteLine("Select bill ID that you want to remove: ");
                        Console.WriteLine("----------------------------------------");
                        b.ShowBills();
                        id = int.Parse(Console.ReadLine());
                        b.DeleteBill(id);
                        break;
                    case "4":
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine(b.ShowBills());
                        Console.WriteLine("------------------------------------");
                        break;
                case "9":
                    return;
                
            }

            }
    
        }

        
    
        


    
        } 

    }

  
      




