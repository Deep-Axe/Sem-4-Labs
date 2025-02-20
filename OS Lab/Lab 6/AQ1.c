#include <stdio.h>

#define MAX 100

typedef struct
{
    int pid, bt, ct, tat, wt, rt;
} Process;

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

void fcfsScheduling(Process p[], int n)
{
    int totalWT = 0, totalTAT = 0, totalRT = 0;
    int currentTime = 0;

    for (int i = 0; i < n; i++)
    {
        p[i].rt = currentTime;
        currentTime += p[i].bt;
        p[i].ct = currentTime;
        p[i].tat = p[i].ct;
        p[i].wt = p[i].tat - p[i].bt;
        totalWT += p[i].wt;
        totalTAT += p[i].tat;
        totalRT += p[i].rt;
    }

    printf("\nProcess\tBT\tCT\tTAT\tWT\tRT\n");
    for (int i = 0; i < n; i++)
    {
        printf("P%d\t%d\t%d\t%d\t%d\t%d\n", p[i].pid, p[i].bt, p[i].ct, p[i].tat, p[i].wt, p[i].rt);
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

    printf("Enter burst time for each process:\n");
    for (int i = 0; i < n; i++)
    {
        p[i].pid = i + 1;
        printf("P%d BT: ", p[i].pid);
        scanf("%d", &p[i].bt);
    }

    fcfsScheduling(p, n);

    return 0;
}
