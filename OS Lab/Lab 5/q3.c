#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/wait.h>

void bubbleSort(char *arr[], int n)
{
    int swapped;
    char *temp;
    do
    {
        swapped = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (strcmp(arr[i], arr[i + 1]) > 0)
            {
                temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                swapped = 1;
            }
        }
    } while (swapped);
}

void selectionSort(char *arr[], int n)
{
    int minIndex;
    char *temp;
    for (int i = 0; i < n - 1; i++)
    {
        minIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (strcmp(arr[j], arr[minIndex]) < 0)
            {
                minIndex = j;
            }
        }
        temp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = temp;
    }
}

int main()
{
    int n;
    printf("Enter number of strings: ");
    scanf("%d", &n);
    getchar();

    char **strings = malloc(n * sizeof(char *));
    char **copy1 = malloc(n * sizeof(char *));
    char **copy2 = malloc(n * sizeof(char *));

    printf("Enter %d strings:\n", n);
    for (int i = 0; i < n; i++)
    {
        strings[i] = malloc(100);
        copy1[i] = malloc(100);
        copy2[i] = malloc(100);
        fgets(strings[i], 100, stdin);
        strings[i][strcspn(strings[i], "\n")] = '\0';
        strcpy(copy1[i], strings[i]);
        strcpy(copy2[i], strings[i]);
    }

    pid_t pid1 = fork();
    pid_t pid2;

    if (pid1 < 0)
    {
        perror("Fork failed");
        return 1;
    }
    if (pid1 == 0)
    {
        bubbleSort(copy1, n);
        printf("\nChild 1 (Bubble Sort):\n");
        for (int i = 0; i < n; i++)
        {
            printf("%s\n", copy1[i]);
        }
        exit(0);
    }

    pid2 = fork();
    if (pid2 < 0)
    {
        perror("Fork failed");
        return 1;
    }
    if (pid2 == 0)
    {
        selectionSort(copy2, n);
        printf("\nChild 2 (Selection Sort):\n");
        for (int i = 0; i < n; i++)
        {
            printf("%s\n", copy2[i]);
        }
        exit(0);
    }

    int status;
    pid_t finished_pid = wait(&status);

    if (finished_pid == pid1)
    {
        printf("\nParent: Child 1 (Bubble Sort) finished first.\n");
    }
    else
    {
        printf("\nParent: Child 2 (Selection Sort) finished first.\n");
    }

    wait(NULL);
    for (int i = 0; i < n; i++)
    {
        free(strings[i]);
        free(copy1[i]);
        free(copy2[i]);
    }
    free(strings);
    free(copy1);
    free(copy2);

    return 0;
}
