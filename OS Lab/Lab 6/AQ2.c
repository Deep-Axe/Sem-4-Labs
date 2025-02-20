#include <stdio.h>

#define MAX 100

typedef struct
{
    int pid, at, bt, ct, tat, wt, rt, completed;
} Process;

void sortByArrival(Process p[], int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (p[j].at > p[j + 1].at)
            {
                Process temp = p[j];
                p[j] = p[j + 1];
                p[j + 1] = temp;
            }
        }
    }
}

void printGanttChart(Process p[], int n)
{
    printf("\nGantt Chart:\n ");
    for (int i = 0; i < n; i++)
    {
        printf("P%d ", p[i].pid);
        if (i != n - 1)
            printf("-> ");
    }
    printf("\n0 ");
    for (int i = 0; i < n; i++)
    {
        printf("  %d ", p[i].ct);
    }
    printf("\n");
}

void sjfScheduling(Process p[], int n)
{
    int completed = 0, currentTime = 0, totalWT = 0, totalTAT = 0, totalRT = 0;

    while (completed < n)
    {
        int minBT = 1e9, minIndex = -1;

        for (int i = 0; i < n; i++)
        {
            if (!p[i].completed && p[i].at <= currentTime && p[i].bt < minBT)
            {
                minBT = p[i].bt;
                minIndex = i;
            }
        }

        if (minIndex == -1)
        {
            currentTime++;
        }
        else
        {
            p[minIndex].rt = currentTime - p[minIndex].at;
            currentTime += p[minIndex].bt;
            p[minIndex].ct = currentTime;
            p[minIndex].tat = p[minIndex].ct - p[minIndex].at;
            p[minIndex].wt = p[minIndex].tat - p[minIndex].bt;
            p[minIndex].completed = 1;
            completed++;

            totalWT += p[minIndex].wt;
            totalTAT += p[minIndex].tat;
            totalRT += p[minIndex].rt;
        }
    }

    printf("\nProcess\tAT\tBT\tCT\tTAT\tWT\tRT\n");
    for (int i = 0; i < n; i++)
    {
        printf("P%d\t%d\t%d\t%d\t%d\t%d\t%d\n", p[i].pid, p[i].at, p[i].bt, p[i].ct, p[i].tat, p[i].wt, p[i].rt);
    }

    printGanttChart(p, n);

    printf("\nAverage Waiting Time: %.2f", (float)totalWT / n);
    printf("\nAverage Turnaround Time: %.2f", (float)totalTAT / n);
    printf("\nAverage Response Time: %.2f\n", (float)totalRT / n);
}

int main()
{
    int n;
    Process p[MAX];

    printf("Enter the number of processes: ");
    scanf("%d", &n);

    printf("Enter arrival time and burst time for each process:\n");
    for (int i = 0; i < n; i++)
    {
        p[i].pid = i + 1;
        printf("P%d AT BT: ", p[i].pid);
        scanf("%d %d", &p[i].at, &p[i].bt);
        p[i].completed = 0;
    }

    sortByArrival(p, n);
    sjfScheduling(p, n);

    return 0;
}
