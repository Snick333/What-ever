static void Main(string[] args)
{
    var square = new Square(length: 5);
    DisplayPolygon(polygonType: "Square", polygon: square);

    var triangle = new Triangle(length: 5);
    DisplayPolygon(polygonType: "Triangle", polygon: triangle);

    var octagon = new Octagon(length: 5);
    DisplayPolygon(polygonType: "Octagon", polygon: octagon);

    var pentagon = new Pentagon(length: 5);
    DisplayPolygon(polygonType: "Pentagon", polygon: pentagon);

    Console.Read();
}

public static Void DisplayPolygon(string polygonType, dynamic polygon)
{
    try
    {
        Console.WriteLine(value: $"{polygonType} Number of Sides: {polygon.NumberOfSides}");
        Console.WriteLine(value: $"{polygonType} Side Length: {polygon.SideLength}");
        Console.WriteLine(value: $"{polygonType} Perimeter: {polygon.Perimeter}");
        Console.WriteLine(value: $"{polygonType} Area: {Math.Round(polygon.GetArea(), 2)}");
        Console.WriteLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Excpetion thrown while trying to process {0}:\n  {1}",
            polygonType, exGetType().Name);
        Console.WriteLine();


    }
}
