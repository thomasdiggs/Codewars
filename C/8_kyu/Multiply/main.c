#include <stdio.h>

int multiply(int a, int b) {
    return a * b;
}

int main(void)
{
    printf("%d\n", multiply(5, 6)); // 30

    return 0;
}