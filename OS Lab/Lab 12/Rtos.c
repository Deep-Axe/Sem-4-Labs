#include <stdio.h>

struct Task {
    int id, exec, period, deadline, next_deadline, remaining;
};

void simulate(struct Task t[], int n, int sim_time, int algo) {
    for(int i = 0; i < n; i++) {
        t[i].next_deadline = t[i].deadline;
        t[i].remaining = 0;
    }

    printf("\nTime\tTask\n");
    for(int time = 0; time < sim_time; time++) {
        int sel = -1;
        for(int i = 0; i < n; i++) {
            if(time % t[i].period == 0)
                t[i].remaining = t[i].exec, t[i].next_deadline = time + t[i].deadline;

            if(t[i].remaining > 0) {
                if(sel == -1 ||
                   (algo == 0 && t[i].period < t[sel].period) ||
                   (algo == 1 && t[i].next_deadline < t[sel].next_deadline))
                    sel = i;
            }
        }
        if(sel != -1) {
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
    printf("Enter number of tasks: "); scanf("%d", &n);
    for(int i = 0; i < n; i++) {
        t[i].id = i+1;
        printf("Task %d exec_time, period, deadline: ", i+1);
        scanf("%d%d%d", &t[i].exec, &t[i].period, &t[i].deadline);
    }
    printf("Enter simulation time: "); scanf("%d", &sim_time);
    printf("0 = Rate-Monotonic, 1 = EDF\nChoose scheduling: "); scanf("%d", &algo);
    simulate(t, n, sim_time, algo);
    return 0;
}
