#include <stdio.h>
#include <stdlib.h>

// Function to calculate absolute difference
int absolute_difference(int a, int b) {
    return a > b ? a - b : b - a;
}

// Bubble sort to sort the request array
void sort_requests(int requests[], int count) {
    for (int i = 0; i < count - 1; i++) {
        for (int j = 0; j < count - i - 1; j++) {
            if (requests[j] > requests[j + 1]) {
                int temp = requests[j];
                requests[j] = requests[j + 1];
                requests[j + 1] = temp;
            }
        }
    }
}

// Function to print the path of head movement and total movement
void print_head_movement_path(int path[], int steps, int total_movement) {
    printf("Head Movement Path: ");
    for (int i = 0; i < steps; i++) {
        printf("%d ", path[i]);
    }
    printf("\nTotal Head Movement: %d\n", total_movement);
}

// First-Come, First-Served
void FCFS(int requests[], int num_requests, int head_position) {
    int total_movement = 0;
    int path[200], path_index = 0;
    path[path_index++] = head_position;

    for (int i = 0; i < num_requests; i++) {
        total_movement += absolute_difference(head_position, requests[i]);
        head_position = requests[i];
        path[path_index++] = head_position;
    }

    print_head_movement_path(path, path_index, total_movement);
}

// Shortest Seek Time First
void SSTF(int requests[], int num_requests, int head_position) {
    int visited[100] = {0};
    int total_movement = 0;
    int path[200], path_index = 0;
    path[path_index++] = head_position;

    for (int i = 0; i < num_requests; i++) {
        int min_distance = 1e9, closest_index = -1;

        for (int j = 0; j < num_requests; j++) {
            if (!visited[j]) {
                int distance = absolute_difference(head_position, requests[j]);
                if (distance < min_distance) {
                    min_distance = distance;
                    closest_index = j;
                }
            }
        }

        visited[closest_index] = 1;
        total_movement += min_distance;
        head_position = requests[closest_index];
        path[path_index++] = head_position;
    }

    print_head_movement_path(path, path_index, total_movement);
}

// SCAN (Elevator Algorithm)
void SCAN(int requests[], int num_requests, int head_position, int direction, int disk_size) {
    sort_requests(requests, num_requests);
    int total_movement = 0;
    int path[200], path_index = 0;
    path[path_index++] = head_position;

    int i = 0;
    while (i < num_requests && requests[i] < head_position) i++;

    if (direction) { // Moving right
        for (int j = i; j < num_requests; j++) {
            total_movement += absolute_difference(head_position, requests[j]);
            head_position = requests[j];
            path[path_index++] = head_position;
        }
        if (head_position != disk_size - 1) {
            total_movement += absolute_difference(head_position, disk_size - 1);
            head_position = disk_size - 1;
            path[path_index++] = head_position;
        }
        for (int j = i - 1; j >= 0; j--) {
            total_movement += absolute_difference(head_position, requests[j]);
            head_position = requests[j];
            path[path_index++] = head_position;
        }
    } else { // Moving left
        for (int j = i - 1; j >= 0; j--) {
            total_movement += absolute_difference(head_position, requests[j]);
            head_position = requests[j];
            path[path_index++] = head_position;
        }
        if (head_position != 0) {
            total_movement += absolute_difference(head_position, 0);
            head_position = 0;
            path[path_index++] = head_position;
        }
        for (int j = i; j < num_requests; j++) {
            total_movement += absolute_difference(head_position, requests[j]);
            head_position = requests[j];
            path[path_index++] = head_position;
        }
    }

    print_head_movement_path(path, path_index, total_movement);
}

// C-SCAN (Circular SCAN)
void CSCAN(int requests[], int num_requests, int head_position, int disk_size) {
    sort_requests(requests, num_requests);
    int total_movement = 0;
    int path[200], path_index = 0;
    path[path_index++] = head_position;

    int i = 0;
    while (i < num_requests && requests[i] < head_position) i++;

    for (int j = i; j < num_requests; j++) {
        total_movement += absolute_difference(head_position, requests[j]);
        head_position = requests[j];
        path[path_index++] = head_position;
    }

    if (head_position != disk_size - 1) {
        total_movement += absolute_difference(head_position, disk_size - 1);
        head_position = disk_size - 1;
        path[path_index++] = head_position;
    }

    total_movement += head_position; // jump to 0
    head_position = 0;
    path[path_index++] = head_position;

    for (int j = 0; j < i; j++) {
        total_movement += absolute_difference(head_position, requests[j]);
        head_position = requests[j];
        path[path_index++] = head_position;
    }

    print_head_movement_path(path, path_index, total_movement);
}

// LOOK (like SCAN but doesn't go to end of disk)
void LOOK(int requests[], int num_requests, int head_position, int direction) {
    sort_requests(requests, num_requests);
    int total_movement = 0;
    int path[200], path_index = 0;
    path[path_index++] = head_position;

    int i = 0;
    while (i < num_requests && requests[i] < head_position) i++;

    if (direction) { // Right
        for (int j = i; j < num_requests; j++) {
            total_movement += absolute_difference(head_position, requests[j]);
            head_position = requests[j];
            path[path_index++] = head_position;
        }
        for (int j = i - 1; j >= 0; j--) {
            total_movement += absolute_difference(head_position, requests[j]);
            head_position = requests[j];
            path[path_index++] = head_position;
        }
    } else { // Left
        for (int j = i - 1; j >= 0; j--) {
            total_movement += absolute_difference(head_position, requests[j]);
            head_position = requests[j];
            path[path_index++] = head_position;
        }
        for (int j = i; j < num_requests; j++) {
            total_movement += absolute_difference(head_position, requests[j]);
            head_position = requests[j];
            path[path_index++] = head_position;
        }
    }

    print_head_movement_path(path, path_index, total_movement);
}

// C-LOOK (Circular LOOK)
void CLOOK(int requests[], int num_requests, int head_position) {
    sort_requests(requests, num_requests);
    int total_movement = 0;
    int path[200], path_index = 0;
    path[path_index++] = head_position;

    int i = 0;
    while (i < num_requests && requests[i] < head_position) i++;

    for (int j = i; j < num_requests; j++) {
        total_movement += absolute_difference(head_position, requests[j]);
        head_position = requests[j];
        path[path_index++] = head_position;
    }

    if (i > 0) {
        total_movement += absolute_difference(head_position, requests[0]);
        head_position = requests[0];
        path[path_index++] = head_position;

        for (int j = 0; j < i; j++) {
            total_movement += absolute_difference(head_position, requests[j]);
            head_position = requests[j];
            path[path_index++] = head_position;
        }
    }

    print_head_movement_path(path, path_index, total_movement);
}

int main() {
    int requests[100], num_requests, head_position, choice, direction;
    int disk_size = 200; // assume 0 to 199

    printf("Enter number of requests: ");
    scanf("%d", &num_requests);

    printf("Enter request queue: ");
    for (int i = 0; i < num_requests; i++) {
        scanf("%d", &requests[i]);
    }

    printf("Enter initial head position: ");
    scanf("%d", &head_position);

    do {
        printf("\n1.FCFS  2.SSTF  3.SCAN  4.C-SCAN  5.LOOK  6.C-LOOK  7.Exit\nEnter your choice: ");
        scanf("%d", &choice);

        switch (choice) {
            case 1:
                FCFS(requests, num_requests, head_position);
                break;
            case 2:
                SSTF(requests, num_requests, head_position);
                break;
            case 3:
                printf("Direction (0=Left, 1=Right): ");
                scanf("%d", &direction);
                SCAN(requests, num_requests, head_position, direction, disk_size);
                break;
            case 4:
                CSCAN(requests, num_requests, head_position, disk_size);
                break;
            case 5:
                printf("Direction (0=Left, 1=Right): ");
                scanf("%d", &direction);
                LOOK(requests, num_requests, head_position, direction);
                break;
            case 6:
                CLOOK(requests, num_requests, head_position);
                break;
        }

    } while (choice != 7);

    return 0;
}
