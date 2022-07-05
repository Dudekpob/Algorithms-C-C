#include <iostream>
#include <cstdlib>
#include <cmath>
#include <iomanip>
#include <stdio.h>
using namespace std;

int main()
{
  unsigned int num, n, d, a;
  cin >> num;
  for (unsigned long i = 0; i < num; i++)
  {
    scanf("%u", &n);
    scanf("%u", &d);
    unsigned long long x, w = 1, y, z = 1, m = 1;
    if (d > n / 2)
    {
      a = n - d;
    }
    else
    {
      a = d;
    }
    if (n < d || n == 0 || d == 0)
    {
      cout << "0" << endl;
    }
    else
    {
      for (unsigned int j = a; j > 1; j--)
        m *= j;
      for (unsigned int k = 0; k < a; k++)
      {
        z = z * (n - k);
      }
      y = z / m;
      for (unsigned int l = 0; l < n - 1; l++)
      {
        w = w * 2;
      }
      x = w * y;
      printf("%llu\n", x);
    }
  }
  return 0;
}
