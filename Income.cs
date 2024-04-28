 namespace Program{


    public class Income(){

    private double _wage;



    public double Wage{

        get{return _wage;}
        set{_wage = value;}
    }

    public double IncomeAfterTax(){

        double incomeAfterTax = 0.0;

        incomeAfterTax = Wage - TaxCalculation();

        return incomeAfterTax;
        
    }

    private double TaxCalculation(){

        double tax = 0.0;


        if(Wage >= 12570.0|| Wage <= 50270.0){

            tax = 0.2 * Wage;
            return tax;

        }

        if( Wage >= 50271.0 || Wage <= 125140.0){
            tax = 0.4 * Wage;
            return tax;
        }

         if(Wage > 124140.0 ){

            tax = 0.45 * Wage;
            return tax;
        }
    
            return tax;
        


    }



  }

}
 