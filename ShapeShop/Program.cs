//CUSTOMER inputs on Console the name of the shape
using OopsBL;

Console.WriteLine("----- WELCOME TO THE SHAPE SHOP -----");
Console.WriteLine("Enter a shape you wish to purchase: ");
string customerInput = Console.ReadLine();
Console.WriteLine($"Any additional specifications you have. Please enter it ',' separated.");

//A function will call the vendor viz. OOPsBL to give correct Shape object
 Shape shape = Shape.GetShapeObject(customerInput);

//Vendor calls .Draw()
shape.Draw(Console.ReadLine());


