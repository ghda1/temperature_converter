class TemperatureConverter {

    static void Main () {

        while (true){

        Console.WriteLine("Enter a temperature and its unit (C or F), or type 'Quit' to exit:");
        string temp = Console.ReadLine();

        if (string.IsNullOrEmpty(temp)){

        Console.WriteLine("invalid inputs! Enter a temperature and its unit (C or F), or type 'Quit' to exit:");
        }else {

        

        if (temp.Trim().ToLower() == "quit"){
            break;
        }

        string [] tempSplitting = temp.Split(" ");

 // checking entered value is 2 character or not  
        if (tempSplitting.Length != 2){

            Console.WriteLine("Invalid length! Please enter a numeric temperature and units.");
        }

        bool isValid = int.TryParse(tempSplitting[0], out int tempDegree);
        if (isValid == false){
            Console.WriteLine("Invalid input! Please enter a numeric temperature."); // make sure that the first index is a number
        }
        
        string tempUnit = tempSplitting[1];

        try{
            Console.WriteLine(TempConvert (tempDegree , tempUnit));
        }
        catch (ArgumentException e) {
            Console.WriteLine(e.Message);

        }
        
        }
    }
    }
        public static string TempConvert (int tempDegree , string tempUnit){

        tempUnit = tempUnit.ToUpper(); // handling lowerCase inputs 

// converting fahrenheit to celsius formula C = (F - 32) × 5/9 
        if (tempUnit == "F"){

            double celsiusDegree = ( tempDegree - 32) * 5.0/9.0;
            return  $"Converted: {tempDegree} F = {celsiusDegree} C";

        } 
 // converting celsius to fahrenheit formula F = (9/5) C + 32
        else if (tempUnit == "C") {

            double fahrenheitDegree = ((9.0/5.0d) * tempDegree) + 32;
            return  $"Converted: {tempDegree} C = {fahrenheitDegree} F";
        }
        else{
            // handling wrong units
            throw new ArgumentException("Invalid units! Please enter 'C' for Celsius or 'F' for Fahrenheit.");
        }
    
}

}