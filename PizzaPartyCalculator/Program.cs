// Declare variables
int numOfGuests;
int slicesPerGuest = 3; // Assume each guest eats 3 slices
int slicesPerPizza = 8; //Standard pizza has 8 slices

// Ask the user to enter the number of guests
Console.Write("Enter the number of guests: ");
// Call the parse function to turn the user entered into int
numOfGuests = int.Parse(Console.ReadLine());

// Calculate total number of slices needed
int totalSlicesNeed = numOfGuests * slicesPerGuest;

// Calculate the number of pizzas required
int pizzasNeed = (int)Math.Ceiling((double)totalSlicesNeed / slicesPerPizza);

// Display the output to the user
Console.WriteLine($"For {numOfGuests} guests, you'll need {pizzasNeed} pizzas.");