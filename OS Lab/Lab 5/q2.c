#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/wait.h>

void sortStrings(char *arr[], int n)
{
    char *temp;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (strcmp(arr[i], arr[j]) > 0)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}

int main(int argc, char *argv[])
{
    if (argc < 2)
    {
        printf("Usage: %s <string1> <string2> ... <stringN>\n", argv[0]);
        return 1;
    }

    pid_t pid = fork();

    if (pid < 0)
    {
        fprintf(stderr, "Fork Failed\n");
        return 1;
    }
    else if (pid == 0)
    {
        char *sorted[argc];
        for (int i = 1; i < argc; i++)
        {
            sorted[i - 1] = argv[i];
        }

        sortStrings(sorted, argc - 1);

        printf("Sorted strings in child process:\n");
        for (int i = 0; i < argc - 1; i++)
        {
            printf("%s\n", sorted[i]);
        }
        exit(0);
    }
    else
    {
        wait(NULL);
        printf("\nUnsorted strings in parent process:\n");
        for (int i = 1; i < argc; i++)
        {
            printf("%s\n", argv[i]);
        }
    }

    return 0;
}
