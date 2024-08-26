#include <stdio.h>

const char* even_or_odd(int number)
{
    if (number % 2 == 0)
    {
        return "Even";
    }
    return "Odd";
}

int main(void)
{
    printf("%s\n", even_or_odd(0)); // Even
    printf("%s\n", even_or_odd(1)); // Odd

    return 0;
}