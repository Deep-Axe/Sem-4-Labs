#include <stdio.h>
#include <math.h>

struct Task {
    int id, exec, period, deadline, next_deadline, remaining;
};

void simulate(struct Task t[], int n, int sim_time, int algo) {
    for (int i = 0; i < n; i++) {
        t[i].next_deadline = t[i].deadline;
        t[i].remaining = 0;
    }

    printf("\nTime\tTask\n");
    for (int time = 0; time < sim_time; time++) {
        int sel = -1;
        for (int i = 0; i < n; i++) {
            if (time % t[i].period == 0) {
                t[i].remaining = t[i].exec;
                t[i].next_deadline = time + t[i].deadline;
            }

            if (t[i].remaining > 0) {
                if (sel == -1 ||
                   (algo == 0 && t[i].period < t[sel].period) ||  // RMS: lower period = higher priority
                   (algo == 1 && t[i].next_deadline < t[sel].next_deadline))  // EDF: earlier deadline = higher priority
                    sel = i;
            }
        }

        if (sel != -1) {
            t[sel].remaining--;
            printf("%2d\tT%d\n", time, t[sel].id);
        } else {
            printf("%2d\tIdle\n", time);
        }
    }
}

int main() {
    struct Task t[10];
    int n, sim_time, algo;
    printf("Enter number of tasks: ");
    scanf("%d", &n);

    for (int i = 0; i < n; i++) {
        t[i].id = i + 1;
        printf("Task %d exec_time, period, deadline: ", i + 1);
        scanf("%d%d%d", &t[i].exec, &t[i].period, &t[i].deadline);
    }

    printf("Enter simulation time: ");
    scanf("%d", &sim_time);
    printf("0 = Rate-Monotonic, 1 = EDF\nChoose scheduling: ");
    scanf("%d", &algo);

    // Schedulability Check
    double utilization = 0;
    for (int i = 0; i < n; i++) {
        utilization += (double)t[i].exec / t[i].period;
    }

    if (algo == 0) {
        double bound = n * (pow(2.0, 1.0 / n) - 1);
        if (utilization > bound) {
            printf("\nWarning: Utilization %.2f exceeds bound %.2f for RMS. Task set may not be schedulable.\n", utilization, bound);
        } else {
            printf("\nTask set is schedulable under RMS (Utilization = %.2f <= Bound = %.2f)\n", utilization, bound);
        }
    } else {
        if (utilization > 1.0) {
            printf("\nWarning: Utilization %.2f exceeds 1.0 for EDF. Task set is not schedulable.\n", utilization);
        } else {
            printf("\nTask set is schedulable under EDF (Utilization = %.2f <= 1.0)\n", utilization);
        }
    }

    simulate(t, n, sim_time, algo);
    return 0;
}
