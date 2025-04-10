#include <stdio.h>
#include <stdlib.h>

int abs_diff(int a, int b) { return a > b ? a - b : b - a; }

void sort(int a[], int n) {
    for(int i = 0; i < n-1; i++)
        for(int j = 0; j < n-i-1; j++)
            if(a[j] > a[j+1]) { int t = a[j]; a[j] = a[j+1]; a[j+1] = t; }
}

void print_path(int path[], int count, int total) {
    printf("Head Movement Path: ");
    for(int i = 0; i < count; i++) printf("%d ", path[i]);
    printf("\nTotal Head Movement: %d\n", total);
}

void FCFS(int r[], int n, int h) {
    int t = 0, path[200], p = 0;
    path[p++] = h;
    for(int i = 0; i < n; i++) {
        t += abs_diff(h, r[i]);
        h = r[i]; path[p++] = h;
    }
    print_path(path, p, t);
}

void SSTF(int r[], int n, int h) {
    int d[100] = {0}, t = 0, path[200], p = 0;
    path[p++] = h;
    for(int i = 0; i < n; i++) {
        int m = 1e9, idx = -1;
        for(int j = 0; j < n; j++)
            if(!d[j] && abs_diff(h, r[j]) < m)
                m = abs_diff(h, r[j]), idx = j;
        t += m; h = r[idx]; d[idx] = 1; path[p++] = h;
    }
    print_path(path, p, t);
}

void SCAN(int r[], int n, int h, int d, int max) {
    sort(r, n);
    int t = 0, i, path[200], p = 0;
    path[p++] = h;
    for(i = 0; i < n && r[i] < h; i++);
    if(d) {
        for(int j = i; j < n; j++) t += abs_diff(h, r[j]), h = r[j], path[p++] = h;
        if(h != max-1) { t += abs_diff(h, max-1); h = max-1; path[p++] = h; }
        for(int j = i-1; j >= 0; j--) t += abs_diff(h, r[j]), h = r[j], path[p++] = h;
    } else {
        for(int j = i-1; j >= 0; j--) t += abs_diff(h, r[j]), h = r[j], path[p++] = h;
        if(h != 0) { t += abs_diff(h, 0); h = 0; path[p++] = h; }
        for(int j = i; j < n; j++) t += abs_diff(h, r[j]), h = r[j], path[p++] = h;
    }
    print_path(path, p, t);
}

void CSCAN(int r[], int n, int h, int max) {
    sort(r, n);
    int t = 0, i, path[200], p = 0;
    path[p++] = h;
    for(i = 0; i < n && r[i] < h; i++);
    for(int j = i; j < n; j++) t += abs_diff(h, r[j]), h = r[j], path[p++] = h;
    if(h != max-1) { t += abs_diff(h, max-1); h = max-1; path[p++] = h; }
    t += h; h = 0; path[p++] = h;
    for(int j = 0; j < i; j++) t += abs_diff(h, r[j]), h = r[j], path[p++] = h;
    print_path(path, p, t);
}

void LOOK(int r[], int n, int h, int d) {
    sort(r, n);
    int t = 0, i, path[200], p = 0;
    path[p++] = h;
    for(i = 0; i < n && r[i] < h; i++);
    if(d) {
        for(int j = i; j < n; j++) t += abs_diff(h, r[j]), h = r[j], path[p++] = h;
        for(int j = i-1; j >= 0; j--) t += abs_diff(h, r[j]), h = r[j], path[p++] = h;
    } else {
        for(int j = i-1; j >= 0; j--) t += abs_diff(h, r[j]), h = r[j], path[p++] = h;
        for(int j = i; j < n; j++) t += abs_diff(h, r[j]), h = r[j], path[p++] = h;
    }
    print_path(path, p, t);
}

void CLOOK(int r[], int n, int h) {
    sort(r, n);
    int t = 0, i, path[200], p = 0;
    path[p++] = h;
    for(i = 0; i < n && r[i] < h; i++);
    for(int j = i; j < n; j++) t += abs_diff(h, r[j]), h = r[j], path[p++] = h;
    if(i) { t += abs_diff(h, r[0]); h = r[0]; path[p++] = h; }
    for(int j = 0; j < i; j++) t += abs_diff(h, r[j]), h = r[j], path[p++] = h;
    print_path(path, p, t);
}

int main() {
    int r[100], n, h, ch, d, max = 200;
    printf("Enter number of requests: "); scanf("%d", &n);
    printf("Enter request queue: "); for(int i = 0; i < n; i++) scanf("%d", &r[i]);
    printf("Enter initial head position: "); scanf("%d", &h);

    do {
        printf("\n1.FCFS 2.SSTF 3.SCAN 4.C-SCAN 5.LOOK 6.C-LOOK 7.Exit\nChoice: ");
        scanf("%d", &ch);
        switch(ch) {
            case 1: FCFS(r, n, h); break;
            case 2: SSTF(r, n, h); break;
            case 3: printf("Direction (0=Left, 1=Right): "); scanf("%d", &d);
                    SCAN(r, n, h, d, max); break;
            case 4: CSCAN(r, n, h, max); break;
            case 5: printf("Direction (0=Left, 1=Right): "); scanf("%d", &d);
                    LOOK(r, n, h, d); break;
            case 6: CLOOK(r, n, h); break;
        }
    } while(ch != 7);
    return 0;
}
