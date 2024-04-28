using System; 
namespace Program{
    public class App{

    static  void Main(string [] args){


        Income i = new Income();
        Bill b = new Bill();
        bool isRunning = true;
        string input;

        
        Console.WriteLine("-----------------");
        Console.WriteLine("Budget Calculator");
        Console.WriteLine("-----------------");
        
        while(isRunning){
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Select Option (Enter numerical value)");
            Console.WriteLine("1: Enter Income ");
            Console.WriteLine("2: Bills Menu ");
            Console.WriteLine("-------------------------------------");
        

        input = Console.ReadLine();
        if(input.Equals("1")){

                Console.WriteLine("Enter Income");
                i.Wage = double.Parse(Console.ReadLine());
                Console.WriteLine(i.IncomeAfterTax());

        

            
        }
        else if(input.Equals("2")){

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Chose an option: (enter numerical value)");
                Console.WriteLine("1: Create Bill");
                Console.WriteLine("2: Update Bill");
                Console.WriteLine("3: Delete Bill");
                Console.WriteLine("4:Show Bills");
                Console.WriteLine("5: Return to main menu");
                Console.WriteLine("----------------------------------------");
                input = Console.ReadLine();
                switch(input){
                    case "1":
                        Console.WriteLine("Enter bill name ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter bill amount ");
                        double amount = double.Parse(Console.ReadLine());
                        b.createBill(name, amount);
                        break;
                    case "2":
                      /*  b.ShowBills();
                        Console.WriteLine("Select ID of bill you want to update ");
                        int id = int.Parse(Console.ReadLine());
                        b.Id = id;
                        Console.WriteLine("Enter new name of bill");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter new amount of bill");
                        double amount = double.Parse(Console.ReadLine());
                        b.UpdateBill(id, name,amount);
                        break;
                        */
                    case"3":
                        b.ShowBills();
                        Console.WriteLine("Select ID of bill That you want to delete");
                        int id = int.Parse(Console.ReadLine());
                        b.Id = id;
                        b.DeleteBill(id);
                        break;
                    case"4":
                        b.ShowBills();
                        break;
                    case"5": 
                        return;
                        
                }


            }

        else if(input.Equals("9")){
            isRunning = false;
            return;
        }
        }


      

      
            

         }

    
    
        

        
    
        


    
     } 

 }

  
      




