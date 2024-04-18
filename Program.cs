Console.WriteLine("Hello, World!");

// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int Divisibility7_23_i (int num){
    if (num%7==0 && num%23==0){
        Console.WriteLine("This number is divisible on 7 and 23!");
        return 0;
    }
    else{
        Console.WriteLine("This number is NOT divisible on 7 and 23!!!!!");
        return 0;
    }
}
void Divisibility7_23_v (int num){
    if (num%7==0 && num%23==0){
        Console.WriteLine("This number is divisible on 7 and 23!");
    }
    else{
        Console.WriteLine("This number is NOT divisible on 7 and 23!!!!!");
    }
}


Console.Write("Enter any number: ");

int a = Convert.ToInt32(Console.ReadLine());
Divisibility7_23_i(a);
Divisibility7_23_v(a);

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

int CheckOnQuarter_i (int x, int y){
    if (x!=0 && y!=0){
        if (x>0 && y>0){
             Console.WriteLine("This first (1) quarter!");
             return 0;
        }
        else if (x<0 && y>0){
             Console.WriteLine("This second (2) quarter!");
             return 0;
        }
        else if (x<0 && y<0){
             Console.WriteLine("This third (3) quarter!");
             return 0;
        }
        else{
            Console.WriteLine("This fourth (4) quarter!");
             return 0;
        }
    
    }
    else{
        Console.WriteLine("There numbers are NOT normal!!!!!");
        return 0;
    }
}

void CheckOnQuarter_v (int x, int y){
    if (x!=0 && y!=0){
        if (x>0 && y>0){
             Console.WriteLine("This first (1) quarter!");
        }
        else if (x<0 && y>0){
             Console.WriteLine("This second (2) quarter!");
        }
        else if (x<0 && y<0){
             Console.WriteLine("This third (3) quarter!");
        }
        else{
            Console.WriteLine("This fourth (4) quarter!");
        }
    
    }
    else{
        Console.WriteLine("There numbers are NOT normal!!!!!");
    }
}

Console.Write("Enter two any number: ");

int b = Convert.ToInt32(Console.ReadLine());
int bb = Convert.ToInt32(Console.ReadLine());

CheckOnQuarter_i(b,bb);
CheckOnQuarter_v(b,bb);

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

 int LargestFigure_i (int num){
    if (num<=99 && num>=10){
    int dz = num/10;
    int un = num%10;
    if (dz>un){
        return dz;
    }
    else{
        return un;
    }
    }
    else{
        Console.Write("This not good number!!!!!");
        return 0;
    }
}

void LargestFigure_v (int num){
    if (num<=99 && num>=10){
    int dz = num/10;
    int un = num%10;
    if (dz>un){
        Console.Write(dz);
    }
    else{
        Console.Write(un);
    }
    }
    else{
        Console.Write("This not good number!!!!!");
    }
}

Console.Write("Enter any number from 10 to 99: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(LargestFigure_i(c));
LargestFigure_v(c);

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

void OutputNumbrts(int num){
    int numi=num;
    int j = 1;
    while(numi>=10){
        j =j+1;
        numi=numi/10;
    }
    int dz=10;
    int j1=2;
    while(j1<j){
        dz=dz*10;
        j1=j1+1;
    }

    int n;
    for (int i=0; i<j;i++){
        if (dz>=10){
            n=num;
            n=n/dz%10;
            Console.Write(n);
            Console.Write(", ");
            dz=dz/10;
        }
        else {
            Console.Write(num%10);
        }      
    }
}

Console.Write("Enter any natural number: ");
int c = Convert.ToInt32(Console.ReadLine());
OutputNumbrts(c);