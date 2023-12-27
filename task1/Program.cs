Console.Write("Введите два положительных числа. Первое число начало интервала: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число конец интервала: ");
int n = Convert.ToInt32(Console.ReadLine());

sumInterval(m, n);

//------------
void sumInterval (int start, int end){
    
    if (start > end){
        return;
    }
    else {
        Console.Write(start + " ");
        start++;
        sumInterval(start, end);
    }



}