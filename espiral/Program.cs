#region ConsoleSize
var maxWidth = Console.LargestWindowWidth;
var maxHeight = Console.LargestWindowHeight;
var positionWidth = maxWidth / 2;
var positionhHeight = maxHeight / 2;

Console.SetWindowSize(maxWidth, maxHeight);
Console.SetCursorPosition(positionWidth, positionhHeight);
#endregion

#region Variables
var number = 0;
var repetitions = 0;
var count = 0;
var way = 0;

var diretion = new List<(int, int)> { (2, 0), (0, -1), (-2, 0), (0, 1) };
#endregion

try
{
    while (true)
    {
        for (int i = 0; i <= repetitions; i++)
        {
            number++;
            if (IsPrime(number))Console.Write("°");

            positionWidth += diretion[way].Item1;
            positionhHeight += diretion[way].Item2;
            Console.SetCursorPosition(positionWidth, positionhHeight);
        }
        if (way == 3) way = 0;
        else way++;
        
        count++;
        if (count % 2 == 0) repetitions++;
    }
}
catch (Exception) { }

static bool IsPrime(int number)
{
    if (number <= 1) return false;
    else if (number == 2) return true;
    else if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;

    return true;
}