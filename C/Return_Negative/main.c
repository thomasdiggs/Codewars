#include <stdio.h>

int makeNegative(int num)
{
    if (num <= 0)
        return num;
    return -num;
}

int main(void)
{
    printf("%d\n", makeNegative(1));  // -1
    printf("%d\n", makeNegative(-5)); // -5
    printf("%d\n", makeNegative(0));  // 0

    return 0;
}