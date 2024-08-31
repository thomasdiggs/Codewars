#include <stdio.h>
#include <stdbool.h>

const char *bool_to_word (bool value)
{
    if (value == true)
        return "Yes";
    return "No";
}

int main(void)
{
    printf("%s\n", bool_to_word(true));   // Yes
    printf("%s\n", bool_to_word(false));  // No

    return 0;
}