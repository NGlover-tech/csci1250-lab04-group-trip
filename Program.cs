
//Road Trip questions

using System.Reflection.Metadata;

Console.Write("What was the round trip in miles?");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car you are using?");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the gas price?");
double gasPrice = Convert.ToDouble(Console.ReadLine());

//Calculation of math

double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;



// The output of math
//System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
//System.Console.WriteLine("Fuel Cost:" + fuelCost.ToString("C"));


//Pizza Party Questions


Console.Write("How many pizzas will there be?");
int pizzaAmount = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the price per each pizza?");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//Pizza slice constant variable
const int pizzaSlice = 8;




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

double slicesPerPerson = SlicesEach(pizzaSlice, names.Length, pizzaAmount);
double costPerPerson = PerPerson(tripTotal, names.Length);

System.Console.WriteLine("=== Part 2: The Group");
System.Console.WriteLine("People going: " + names.Length);
System.Console.WriteLine("Slices each: " + slicesPerPerson);
System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C")); 







//Tax Rate constant
const double taxRate = 0.18;

//Calculation for Paycheck
//double grossPay = hoursWorked * hourlyRate;
//double taxWithheld = grossPay * (double)taxRate;
//double paycheck = grossPay - (double)taxWithheld;

//Output of Paycheck
//System.Console.WriteLine("Gross Pay: " + grossPay.ToString("C"));
//System.Console.WriteLine("Tax Withheld: " + taxWithheld.ToString("C"));
//System.Console.WriteLine("Take home pay: " + paycheck.ToString("C"));


//Whole Trip Calculations


//double takeHomePayPerHour = paycheck / (double)hoursWorked;


//Whole Tripe Output Calculations
//System.Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));

//System.Console.WriteLine("Take Home Pay Per Hour: " + takeHomePayPerHour.ToString("C"));


static double PerPerson(double total, double people)
{
    return total / people;
}

static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}


static double PizzaCost( double pizzaAmount, double pricePerPizza)
{
    return pizzaAmount * pricePerPizza;
}

static double TripTotal(double fuelCost, double pricePerPizza)
{
    return fuelCost + pricePerPizza;
}

static double SlicesEach(double pizzaSlice, double peopleAmount, double pizzaAmount)
{
    double totalSlices = pizzaSlice * pizzaAmount; 
    return totalSlices / peopleAmount;
}
static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double grossPay = hours * (double)hourlyRate;
    double taxWithheld = grossPay * (double)taxRate;
    return grossPay - (double)taxWithheld;
}

static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return amountOwed / takeHomePerHour;
}