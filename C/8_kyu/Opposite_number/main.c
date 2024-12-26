#include <stdio.h>

float opposite(float num)
{
    return num * -1;
}

int main(void)
{
    printf("%f\n", opposite(1));    // -1
    printf("%f\n", opposite(-24));  // 24

    return 0;
}