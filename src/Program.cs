class TemperatureConverter {

    static void Main () {

        while (true){
        Console.WriteLine("Enter a temperature and its unit (C or F), or type 'Quit' to exit:");
        string temp = Console.ReadLine();

        if (temp.Trim().ToLower() == "quit"){
            break;
        }

        string [] tempSplitting = temp.Split(" ");
        int tempDegree = Convert.ToInt32(tempSplitting[0]);
        string tempUnit = tempSplitting[1];
       
       Console.WriteLine(TempConvert (tempDegree , tempUnit));
        
        }}
        public static string TempConvert (int tempDegree , string tempUnit){

 // checking entered value is 2 character or not  
        int size = tempDegree.ToString().Length;
        if (size == 2){

// converting fahrenheit to celsius formula C = (F - 32) × 5/9 
        tempUnit = tempUnit.ToUpper();
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
            return "Invalid units!!";
        }
    
 } else{
    return "Invalid length!";
 
    }
}

}


