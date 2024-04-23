 namespace Program{


    public class Income(){

    private double _wage;



    public double Wage{

        get{return _wage;}
        set{_wage = value;}
    }

    public double IncomeAfterTax(){

        double incomeAfterTax = 0.0;

       incomeAfterTax = _wage - TaxCalculation();

        return incomeAfterTax;
        
    }

    private double TaxCalculation(){

        double tax = 0.0;


        if(_wage >= 12570.0|| _wage <= 50270.0){

            tax = 0.2 * _wage;
            return tax;

        }

        else if( _wage >= 50271.0 || _wage <= 125140.0){
            tax = 0.4 * _wage;
            return tax;
        }

        else if(_wage > 124140.0 ){

            tax = 0.45 * _wage;
            return tax;
        }
        else{
            return tax;
        }

    


    }



}

 }
 