int m = 1;
int n = 15;
int RecNumbers(int m, int n)
{
    if (m == n) return n;
    return m + RecNumbers(m+1,n);

}
Console.Write(RecNumbers(m, n));