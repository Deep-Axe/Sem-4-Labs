#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/types.h>

int main()
{
    pid_t pid = fork();

    if (pid < 0)
    {

        perror("Fork failed");
        exit(1);
    }
    else if (pid == 0)
    {

        printf("Child Process:\n");
        printf("PID: %d, PPID: %d\n", getpid(), getppid());
    }
    else
    {
        printf("Parent Process:\n");
        printf("PID: %d, Child PID: %d\n", getpid(), pid);
    }

    return 0;
}
