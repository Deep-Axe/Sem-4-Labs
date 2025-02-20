#include <stdio.h>
#include <stdlib.h>

#define MAX 100

typedef struct
{
    int pid, at, bt, bt_rem, ct, wt, tat, rt, priority;
} Process;

void swap(Process *a, Process *b)
{
    Process temp = *a;
    *a = *b;
    *b = temp;
}

void printGanttChart(int order[], int times[], int len)
{
    printf("\nGantt Chart:\n");
    for (int i = 0; i < len; i++)
    {
        printf("| P%d ", order[i]);
    }
    printf("|\n");
    for (int i = 0; i < len + 1; i++)
    {
        printf("%d   ", times[i]);
    }
    printf("\n");
}

void calculateAvgTimes(Process p[], int n)
{
    float totalWT = 0, totalTAT = 0, totalRT = 0;
    for (int i = 0; i < n; i++)
    {
        totalWT += p[i].wt;
        totalTAT += p[i].tat;
        totalRT += p[i].rt;
    }
    printf("\nAverage Waiting Time: %.2f\n", totalWT / n);
    printf("Average Turnaround Time: %.2f\n", totalTAT / n);
    printf("Average Response Time: %.2f\n", totalRT / n);
}

void sjf_preemptive(Process p[], int n)
{
    int completed = 0, time = 0, min_idx, min_bt, order[MAX], times[MAX], idx = 0;
    for (int i = 0; i < n; i++)
        p[i].bt_rem = p[i].bt;

    while (completed < n)
    {
        min_idx = -1, min_bt = 9999;
        for (int i = 0; i < n; i++)
        {
            if (p[i].at <= time && p[i].bt_rem > 0 && p[i].bt_rem < min_bt)
            {
                min_bt = p[i].bt_rem;
                min_idx = i;
            }
        }
        if (min_idx == -1)
        {
            time++;
            continue;
        }
        if (p[min_idx].rt == -1)
            p[min_idx].rt = time - p[min_idx].at;
        order[idx] = p[min_idx].pid;
        times[idx++] = time;
        p[min_idx].bt_rem--;
        if (p[min_idx].bt_rem == 0)
        {
            completed++;
            p[min_idx].ct = time + 1;
            p[min_idx].tat = p[min_idx].ct - p[min_idx].at;
            p[min_idx].wt = p[min_idx].tat - p[min_idx].bt;
        }
        time++;
    }
    times[idx] = time;
    printGanttChart(order, times, idx);
    calculateAvgTimes(p, n);
}

void roundRobin(Process p[], int n, int tq)
{
    int time = 0, completed = 0, order[MAX], times[MAX], idx = 0, queue[MAX], front = 0, rear = 0;
    for (int i = 0; i < n; i++)
        p[i].bt_rem = p[i].bt;

    for (int i = 0; i < n; i++)
        if (p[i].at == 0)
            queue[rear++] = i;

    while (completed < n)
    {
        if (front == rear)
        {
            time++;
            continue;
        }
        int i = queue[front++];
        if (p[i].rt == -1)
            p[i].rt = time - p[i].at;
        order[idx] = p[i].pid;
        times[idx++] = time;
        int exec_time = (p[i].bt_rem < tq) ? p[i].bt_rem : tq;
        time += exec_time;
        p[i].bt_rem -= exec_time;
        for (int j = 0; j < n; j++)
            if (p[j].at <= time && p[j].bt_rem > 0 && j != i)
                queue[rear++] = j;
        if (p[i].bt_rem == 0)
        {
            completed++;
            p[i].ct = time;
            p[i].tat = p[i].ct - p[i].at;
            p[i].wt = p[i].tat - p[i].bt;
        }
        else
        {
            queue[rear++] = i;
        }
    }
    times[idx] = time;
    printGanttChart(order, times, idx);
    calculateAvgTimes(p, n);
}

void priorityScheduling(Process p[], int n)
{
    int completed = 0, time = 0, order[MAX], times[MAX], idx = 0;
    for (int i = 0; i < n - 1; i++)
        for (int j = i + 1; j < n; j++)
            if (p[i].priority > p[j].priority)
                swap(&p[i], &p[j]);

    for (int i = 0; i < n; i++)
    {
        if (p[i].at > time)
            time = p[i].at;
        order[idx] = p[i].pid;
        times[idx++] = time;
        p[i].rt = time - p[i].at;
        time += p[i].bt;
        p[i].ct = time;
        p[i].tat = p[i].ct - p[i].at;
        p[i].wt = p[i].tat - p[i].bt;
    }
    times[idx] = time;
    printGanttChart(order, times, idx);
    calculateAvgTimes(p, n);
}

void menu()
{
    int choice, n, tq;
    Process p[MAX];
    do
    {
        printf("\nProcess Scheduling Menu:\n");
        printf("1. Preemptive SJF\n");
        printf("2. Round Robin\n");
        printf("3. Non-Preemptive Priority Scheduling\n");
        printf("4. Exit\n");
        printf("Enter choice: ");
        scanf("%d", &choice);

        if (choice == 4)
            break;

        printf("Enter number of processes: ");
        scanf("%d", &n);
        printf("Enter process details (PID, Arrival Time, Burst Time, Priority):\n");

        for (int i = 0; i < n; i++)
        {
            scanf("%d %d %d %d", &p[i].pid, &p[i].at, &p[i].bt, &p[i].priority);
            p[i].rt = -1;
        }

        switch (choice)
        {
        case 1:
            sjf_preemptive(p, n);
            break;
        case 2:
            printf("Enter time quantum: ");
            scanf("%d", &tq);
            roundRobin(p, n, tq);
            break;
        case 3:
            priorityScheduling(p, n);
            break;
        default:
            printf("Invalid choice!\n");
        }
    } while (choice != 4);
}

int main()
{
    menu();
    return 0;
}
