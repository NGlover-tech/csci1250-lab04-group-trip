

/*
* Name: Nicholas Lea Glover
* Course: CSCI 1250, Section 002
* Assignment: Lab 04, The Group Trip
* Date: October 7, 2026
* Description: Rebuilds the trip calculator with methods and arrays so it
* reports on a whole group instead of one person.
*/

//Road Trip questions
Console.Write("What was the round trip in miles?");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());
Console.Write("What is the miles per gallon of the car you are using?");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the gas price?");
double gasPrice = Convert.ToDouble(Console.ReadLine());



//Pizza Party Questions
Console.Write("How many pizzas will there be?");
int pizzaAmount = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the price per each pizza?");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//Pizza slice constant variable
const int pizzaSlice = 8;


//Variables for part 1
double fuel = FuelCost(milesForTheTrip, milesPerGallon, gasPrice);
double pizzaCost = PizzaCost(pizzaAmount, pricePerPizza);
double tripTotal = TripTotal(fuel, pizzaCost);

//Trip math with Methods
System.Console.WriteLine("=== Part 1: The Trip ===");
System.Console.WriteLine("Fuel cost: " + fuel.ToString("C"));
System.Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
System.Console.WriteLine("Trip total: " + tripTotal.ToString("C"));

//Arrays of people on the trip 
String[] names = { "Ada", "Grace", "Alan", "Kathrine"};
double[] hoursWorked = {22, 15, 30, 18};
double[] hourlyRate = {13.50, 16.00, 11.20, 14.80};

//varibles for methods of part 2
double slicesPerPerson = SlicesEach(pizzaSlice, names.Length, pizzaAmount);
double costPerPerson = PerPerson(tripTotal, names.Length);

//Part 2 output
System.Console.WriteLine();
System.Console.WriteLine("=== Part 2: The Group ===");
System.Console.WriteLine("People going: " + names.Length);
System.Console.WriteLine("Slices each: " + slicesPerPerson);
System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C")); 

//Tax Rate constant
const double taxRate = 0.18;

//Placeholder variables
double totalHours = 0;
double totalTakeHomePay = 0;
double longestWorked = 0;

//Output for part 3 with the loop for each person
System.Console.WriteLine();
System.Console.WriteLine("=== Part 3: Who Works How Long ===");
for (int i = 0; i < names.Length; i++)
{
    double takeHomePay = TakeHomePay(hoursWorked[i], hourlyRate[i], taxRate);
    double takeHomePayPerHour = takeHomePay / hoursWorked[i];
    double hoursCovered = HoursToCover(costPerPerson, takeHomePayPerHour);
    totalHours = totalHours += hoursWorked[i];
    totalTakeHomePay = totalTakeHomePay += takeHomePay;
    longestWorked = Math.Max(longestWorked, hoursCovered);
    System.Console.WriteLine(names[i] + ": takes home " + takeHomePay.ToString("C") + " for " + hoursWorked[i] + " hours, " + takeHomePayPerHour.ToString("C") + " per hour, must work " + hoursCovered.ToString("F2") + " hours ");
}

//Secondary output for part 3
System.Console.WriteLine();
System.Console.WriteLine("Total hours worked: " + totalHours.ToString("F2"));
System.Console.WriteLine("Tital take home pay: " + totalTakeHomePay.ToString("C"));
System.Console.WriteLine("Longest anyone must work: " + longestWorked.ToString("F2"));

//Method for calculating total price per person
static double PerPerson(double total, double people)
{
    return total / people;
}

//Method for calculating 
static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}

//Method for calculating the total pizza cost
static double PizzaCost( double pizzaAmount, double pricePerPizza)
{
    return pizzaAmount * pricePerPizza;
}

//Method for calculating the total cost of the trip
static double TripTotal(double fuelCost, double pricePerPizza)
{
    return fuelCost + pricePerPizza;
}

//Method for calculating the amount of pizza slices for each person
static double SlicesEach(double pizzaSlice, double peopleAmount, double pizzaAmount)
{
    double totalSlices = pizzaSlice * pizzaAmount; 
    return totalSlices / peopleAmount;
}

//Method for calculating the take home pay for a person
static double TakeHomePay(double hoursWorked, double hourlyRate, double taxRate)
{
        double grossPay = hoursWorked * (double)hourlyRate;
        double taxWithheld = grossPay * (double)taxRate;
        return grossPay - (double)taxWithheld;
}

//Method for calculating the amount of hours a person has to cover for the trip
static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return amountOwed / takeHomePerHour;
}