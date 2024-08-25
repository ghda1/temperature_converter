class TemperatureConverter {

    static void Main () {

        Console.WriteLine("Wich Unit You Want to Convert, Press (C or F) ");
        char tempUnit = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine("Enter a Temperature Degree: ");
        double tempDegree = Convert.ToDouble(Console.ReadLine());
       
       Console.WriteLine(TempConvert (tempDegree , tempUnit));
        
    }
        public static string TempConvert (double tempDegree , char tempUnit){

// converting fahrenheit to celsius formula C = (F - 32) × 5/9 
        if (tempUnit == 'F'){

            double celsiusDegree = (tempDegree - 32) * 5/9;
            return  $"Converted: {tempDegree} F = {celsiusDegree} C";

        } 
 // converting celsius to fahrenheit formula F = (9/5) C + 32
        else if (tempUnit == 'C') {

            double fahrenheitDegree = ((9.0/5) * tempDegree) + 32;
            return  $"Converted: {tempDegree} C = {fahrenheitDegree} F";
        }
        else{
            return "Sorry!";
        }

    }
}

