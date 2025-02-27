#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/wait.h>

struct Process
{
    int pid;
    int burst_time;
    int priority;
    int completion_time;
    int turnaround_time;
    int waiting_time;
};

void priorityScheduling(struct Process p[], int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (p[j].priority > p[j + 1].priority)
            {
                struct Process temp = p[j];
                p[j] = p[j + 1];
                p[j + 1] = temp;
            }
        }
    }

    int current_time = 0;
    float total_turnaround_time = 0;
    float total_waiting_time = 0;

    for (int i = 0; i < n; i++)
    {
        p[i].completion_time = current_time + p[i].burst_time;
        p[i].turnaround_time = p[i].completion_time;
        p[i].waiting_time = current_time;

        current_time = p[i].completion_time;
        total_turnaround_time += p[i].turnaround_time;
        total_waiting_time += p[i].waiting_time;
    }

    printf("\nProcess Execution Details:\n");
    printf("PID\tPriority\tBurst\tCompletion\tTurnaround\tWaiting\n");
    for (int i = 0; i < n; i++)
    {
        printf("%d\t%d\t\t%d\t%d\t\t%d\t\t%d\n",
               p[i].pid,
               p[i].priority,
               p[i].burst_time,
               p[i].completion_time,
               p[i].turnaround_time,
               p[i].waiting_time);
    }

    printf("\nAverage Turnaround Time: %.2f", total_turnaround_time / n);
    printf("\nAverage Waiting Time: %.2f\n", total_waiting_time / n);
}

int main()
{
    pid_t pid = fork();

    if (pid < 0)
    {
        fprintf(stderr, "Fork failed\n");
        return 1;
    }
    else if (pid == 0)
    {
        // Child process
        printf("\nChild Process (PID: %d)\n", getpid());

        int n = 4;
        struct Process processes[] = {
            {1, 6, 4, 0, 0, 0}, // {pid, burst_time, priority, completion_time, turnaround_time, waiting_time}
            {2, 4, 1, 0, 0, 0},
            {3, 2, 3, 0, 0, 0},
            {4, 3, 2, 0, 0, 0}};

        printf("Executing Priority Scheduling in Child Process...\n");
        priorityScheduling(processes, n);
        exit(0);
    }
    else
    {

        printf("Parent Process (PID: %d)\n", getpid());
        printf("Waiting for child process to complete...\n");

        int status;
        wait(&status);

        if (WIFEXITED(status))
        {
            printf("\nChild process completed with status: %d\n", WEXITSTATUS(status));
        }
    }

    return 0;
}