Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1,  // можно каждый перечислить через int в каждой новой строке, либо так как здесь перечислить
    xb = 1, yb = 30, // здесь мы задаём координаты точек a, b, c, где х - это отступ от левого края, а у - это отступ от верехнего края
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;

int count = 0; //счетчик начинаем от нуля

while(count < 10000)
{
    int what = new Random().Next(0, 3); // [0;3) 0 1 2. 0,3 потому что у нас три точки. когда задаем параметры мин и макс, то макс минус 1, по этому 0,1,2 будут значения. 
    //генерируем случайное число, где what  название, может быть любым названием
    if(what == 0) //начинаем проверку для первой точки, если случайное число равно 0, то половиним наши отрезки и ставим точку посередине
    {
        x = (x + xa) / 2; // вот половиним
        y = (y + ya) / 2;  // и вот      
    }
    
    if(what == 1) // для второй точки
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    
    if(what == 2)  // для третьей точки
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // или count++; или count += 1;
}