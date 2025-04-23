#include <stdio.h>
#include <stdbool.h>

#define P 5 // Number of processes
#define R 3 // Number of resource types

int available[R];           // Available resources
int max[P][R];              // Maximum demand of each process
int allocation[P][R];       // Currently allocated resources
int need[P][R];             // Remaining needs

// Function to display the current state
void displayState() {
    printf("\nCurrent System State:\n");
    printf("Process\tAllocated\tMaximum\t\tNeed\n");
    for (int i = 0; i < P; i++) {
        printf("P%d\t", i);
        for (int j = 0; j < R; j++) {
            printf("%d ", allocation[i][j]);
        }
        printf("\t\t");
        for (int j = 0; j < R; j++) {
            printf("%d ", max[i][j]);
        }
        printf("\t\t");
        for (int j = 0; j < R; j++) {
            printf("%d ", need[i][j]);
        }
        printf("\n");
    }

    printf("Available Resources: ");
    for (int i = 0; i < R; i++) {
        printf("%d ", available[i]);
    }
    printf("\n");
}

// Function to check if system is in safe state
bool isSafe() {
    int work[R];
    bool finish[P] = {false};

    // Initialize work = available
    for (int i = 0; i < R; i++) {
        work[i] = available[i];
    }

    int count = 0;
    while (count < P) {
        bool found = false;
        for (int i = 0; i < P; i++) {
            if (!finish[i]) {
                bool canAllocate = true;
                for (int j = 0; j < R; j++) {
                    if (need[i][j] > work[j]) {
                        canAllocate = false;
                        break;
                    }
                }
                if (canAllocate) {
                    for (int j = 0; j < R; j++) {
                        work[j] += allocation[i][j];
                    }
                    finish[i] = true;
                    found = true;
                    count++;
                }
            }
        }
        if (!found) {
            return false; // Deadlock risk
        }
    }
    return true; // Safe state
}

// Function to request resources for a process
bool requestResources(int process, int request[R]) {
    printf("\nProcessing resource request for P%d: ", process);
    for (int i = 0; i < R; i++) {
        printf("%d ", request[i]);
    }
    printf("\n");

    // Check if request is within the process's need
    for (int i = 0; i < R; i++) {
        if (request[i] > need[process][i]) {
            printf("Error: Request exceeds process P%d's maximum claim.\n", process);
            return false;
        }
        if (request[i] > available[i]) {
            printf("Resources not available. P%d must wait.\n", process);
            return false;
        }
    }

    // Temporarily allocate resources
    for (int i = 0; i < R; i++) {
        available[i] -= request[i];
        allocation[process][i] += request[i];
        need[process][i] -= request[i];
    }

    // Check if new state is safe
    if (!isSafe()) {
        // Rollback
        for (int i = 0; i < R; i++) {
            available[i] += request[i];
            allocation[process][i] -= request[i];
            need[process][i] += request[i];
        }
        printf("Request cannot be granted. System would enter unsafe state.\n");
        return false;
    }

    printf("Request granted. System remains in safe state.\n");
    return true;
}

int main() {


    // Input available resources
    printf("Enter the available amount of each resource (R=%d):\n", R);
    for (int i = 0; i < R; i++) {
        printf("Resource %d: ", i);
        scanf("%d", &available[i]);
    }

    // Input max demand matrix
    printf("\nEnter the maximum resource demand for each process (P=%d):\n", P);
    for (int i = 0; i < P; i++) {
        printf("P%d:\n", i);
        for (int j = 0; j < R; j++) {
            printf("  Max resource %d: ", j);
            scanf("%d", &max[i][j]);
        }
    }

    // Input allocation matrix
    printf("\nEnter the allocated resources for each process:\n");
    for (int i = 0; i < P; i++) {
        printf("P%d:\n", i);
        for (int j = 0; j < R; j++) {
            printf("  Allocated resource %d: ", j);
            scanf("%d", &allocation[i][j]);
            // Calculate need
            need[i][j] = max[i][j] - allocation[i][j];
        }
    }

    // Display initial state
    displayState();

    // Initial safety check
    if (isSafe()) {
        printf("\nInitial State: System is in a SAFE state.\n");
    } else {
        printf("\nInitial State: System is in an UNSAFE state!\n");
    }

    // Resource request
    int process, request[R];
    printf("\nEnter the process number making a resource request (0 to %d): ", P - 1);
    scanf("%d", &process);

    printf("Enter resource request for P%d:\n", process);
    for (int i = 0; i < R; i++) {
        printf("  Resource %d: ", i);
        scanf("%d", &request[i]);
    }

    requestResources(process, request);

    // Display final state
    displayState();

    return 0;
}
