#include <stdio.h>
#include <stdlib.h>
#define MAX_TIME 100

struct Process
{
    int pid;
    int arrival_time;
    int burst_time;
    int remaining_time;
    int completion_time;
    int turnaround_time;
    int waiting_time;
};

int gantt_pid[MAX_TIME];
int gantt_time = 0;

void printGanttChart(int total_time)
{
    printf("\nGantt Chart:\n");
    printf(" ");
    for (int i = 0; i < total_time; i++)
    {
        printf("----");
    }
    printf("\n|");

    for (int i = 0; i < total_time; i++)
    {
        if (gantt_pid[i] == -1)
            printf(" -- ");
        else
            printf(" P%d ", gantt_pid[i]);
    }
    printf("|\n ");

    for (int i = 0; i < total_time; i++)
    {
        printf("----");
    }
    printf("\n");

    printf("0");
    for (int i = 0; i < total_time; i++)
    {
        printf("    ");
        if (i < 9)
            printf("\b\b\b%d", i + 1);
        else
            printf("\b\b\b\b%d", i + 1);
    }
    printf("\n");
}

void roundRobin(struct Process p[], int n, int quantum)
{
    int current_time = 0;
    int completed = 0;
    float total_turnaround_time = 0;
    float total_waiting_time = 0;

    // Initialize remaining time
    for (int i = 0; i < n; i++)
    {
        p[i].remaining_time = p[i].burst_time;
    }

    while (completed != n)
    {
        int all_waiting = 1;

        for (int i = 0; i < n; i++)
        {
            if (p[i].remaining_time > 0 && p[i].arrival_time <= current_time)
            {
                all_waiting = 0;
                int execute_time = p[i].remaining_time < quantum ? p[i].remaining_time : quantum;
                p[i].remaining_time -= execute_time;

                for (int j = 0; j < execute_time; j++)
                {
                    gantt_pid[gantt_time++] = p[i].pid;
                }

                current_time += execute_time;

                if (p[i].remaining_time == 0)
                {
                    completed++;
                    p[i].completion_time = current_time;
                    p[i].turnaround_time = p[i].completion_time - p[i].arrival_time;
                    p[i].waiting_time = p[i].turnaround_time - p[i].burst_time;

                    total_turnaround_time += p[i].turnaround_time;
                    total_waiting_time += p[i].waiting_time;
                }
            }
        }

        if (all_waiting)
        {
            gantt_pid[gantt_time++] = -1;
            current_time++;
        }
    }
    printf("\nProcess Execution Details:\n");
    printf("PID\tArrival\tBurst\tCompletion\tTurnaround\tWaiting\n");
    for (int i = 0; i < n; i++)
    {
        printf("%d\t%d\t%d\t%d\t\t%d\t\t%d\n",
               p[i].pid,
               p[i].arrival_time,
               p[i].burst_time,
               p[i].completion_time,
               p[i].turnaround_time,
               p[i].waiting_time);
    }

    printf("\nAverage Turnaround Time: %.2f", total_turnaround_time / n);
    printf("\nAverage Waiting Time: %.2f\n", total_waiting_time / n);
    printGanttChart(gantt_time);
}

int main()
{
    int n, quantum;
    printf("Enter number of processes: ");
    scanf("%d", &n);
    printf("Enter time quantum: ");
    scanf("%d", &quantum);

    struct Process *processes = malloc(n * sizeof(struct Process));

    for (int i = 0; i < n; i++)
    {
        printf("\nProcess %d\n", i + 1);
        processes[i].pid = i + 1;
        printf("Enter arrival time: ");
        scanf("%d", &processes[i].arrival_time);
        printf("Enter burst time: ");
        scanf("%d", &processes[i].burst_time);
    }

    roundRobin(processes, n, quantum);
    free(processes);
    return 0;
}