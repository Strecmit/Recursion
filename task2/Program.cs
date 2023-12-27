Console.WriteLine("Вычисление функции Акермана: А(n,m).\r\nВведите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\r\nВычисленный результат равен {Ackermann(n,m)}");

int Ackermann(int n, int m){
    //Console.WriteLine($"m={m}, n={n} ");
    if(n == 0) {return m+1;}
    else if(m == 0) {return Ackermann(n-1, 1);}
    else {return Ackermann(n-1,Ackermann(n,m-1));}
    
}