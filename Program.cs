
//Road Trip questions
Console.Write("What was the round trip in miles?");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car you are using?");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the gas price?");
double gasPrice = Convert.ToDouble(Console.ReadLine());

//Calculation of math

double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * gasPrice;

// The output of math
System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel Cost:" + fuelCost.ToString("C"));


//Pizza Party Questions


Console.Write("How many pizzas will there be?");
int pizzaAmount = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the price per each pizza?");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//Pizza slice constant variable
const int pizzaSlice = 8;

//Calulation for pizza party

int totalSlices = pizzaAmount * (int)pizzaSlice;
double pizzaPriceTotal = pricePerPizza * (double)pizzaAmount;

double fuel = FuelCost(milesForTheTrip, milesPerGallon, gasPrice);
double pizzaCost = PizzaCost(pizzaAmount, pricePerPizza);
double tripTotal = TripTotal(fuelCost, pricePerPizza);

//Trip math with Methods
System.Console.WriteLine("=== Part 1: The Trip ===");
System.Console.WriteLine("Fuel cost: " + fuel.ToString("C"));
System.Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
System.Console.WriteLine("Trip total: " + tripTotal.ToString("C"));





//Questions about Paycheck
double hoursWorked = Convert.ToDouble(Console.ReadLine());


double hourlyRate = Convert.ToDouble(Console.ReadLine());

//Tax Rate constant
const double taxRate = 0.18;

//Calculation for Paycheck
double grossPay = hoursWorked * (double)hourlyRate;
double taxWithheld = grossPay * (double)taxRate;
double paycheck = grossPay - (double)taxWithheld;

//Output of Paycheck
System.Console.WriteLine("Gross Pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax Withheld: " + taxWithheld.ToString("C"));
System.Console.WriteLine("Take home pay: " + paycheck.ToString("C"));


//Whole Trip Calculations


double takeHomePayPerHour = paycheck / (double)hoursWorked;


//Whole Tripe Output Calculations
System.Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));

System.Console.WriteLine("Take Home Pay Per Hour: " + takeHomePayPerHour.ToString("C"));



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