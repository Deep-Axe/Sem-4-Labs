#include <stdio.h>
#include <stdlib.h>
#include <limits.h>
#define MAX_TIME 100
int gantt_pid[MAX_TIME];
int gantt_time = 0;

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

void printGanttChart(int total_time)
{
    printf("\nGantt Chart:\n");

    // Print top border
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

    // Print bottom border
    for (int i = 0; i < total_time; i++)
    {
        printf("----");
    }
    printf("\n");

    // Print timeline
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

void preemptiveSJF(struct Process p[], int n)
{
    int current_time = 0;
    int completed = 0;
    float total_turnaround_time = 0;
    float total_waiting_time = 0;

    for (int i = 0; i < n; i++)
    {
        p[i].remaining_time = p[i].burst_time;
    }

    while (completed != n)
    {
        int shortest = -1;
        int min_burst = INT_MAX;

        for (int i = 0; i < n; i++)
        {
            if (p[i].arrival_time <= current_time &&
                p[i].remaining_time > 0 &&
                p[i].remaining_time < min_burst)
            {
                shortest = i;
                min_burst = p[i].remaining_time;
            }
        }

        if (shortest == -1)
        {
            gantt_pid[gantt_time++] = -1; // Idle time
            current_time++;
            continue;
        }

        p[shortest].remaining_time--;
        gantt_pid[gantt_time++] = p[shortest].pid;

        if (p[shortest].remaining_time == 0)
        {
            completed++;
            p[shortest].completion_time = current_time + 1;
            p[shortest].turnaround_time = p[shortest].completion_time -
                                          p[shortest].arrival_time;
            p[shortest].waiting_time = p[shortest].turnaround_time -
                                       p[shortest].burst_time;

            total_turnaround_time += p[shortest].turnaround_time;
            total_waiting_time += p[shortest].waiting_time;
        }

        current_time++;
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
    int n;
    printf("Enter number of processes: ");
    scanf("%d", &n);

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

    preemptiveSJF(processes, n);
    free(processes);
    return 0;
}