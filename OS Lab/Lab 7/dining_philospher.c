#include <stdio.h>
#include <stdlib.h>
#include <semaphore.h>
#include <pthread.h>
#include <unistd.h>

#define PH_NUM 5
#define EAT_TIME 2
#define THINK_TIME 2

#define THINKING 0
#define EATING 1
#define HUNGRY 2

sem_t mutex;
sem_t S[PH_NUM];
int state[PH_NUM];

void test(int numb)
{
    if (state[numb] == HUNGRY && state[(numb + 1) % PH_NUM] != EATING && state[(numb + 4) % PH_NUM] != EATING)
    {
        state[numb] = EATING;
        printf("Philospher %d is eating\n", numb);
        sem_post(&S[numb]);
    }
}

void take_fork(int numb)
{
    sem_wait(&mutex);
    state[numb] = HUNGRY;
    printf("Philospher %d is hungry\n", numb);
    test(numb);
    sem_post(&mutex);
    sem_post(&S[numb]);
}
void put_fork(int numb)
{
    sem_wait(&mutex);
    state[numb] = THINKING;
    printf("Philospher %d puts down fork and starts to think\n", numb);

    test((numb + 1) % PH_NUM);
    test((numb + 4) % PH_NUM);
    sem_post(&mutex);
}

void *ph(void *arg)
{
    int ph_num = *((int *)arg);
    while (1)
    {
        printf("Philspher %d is thinking\n", ph_num + 1);
        sleep(THINK_TIME);
        take_fork(ph_num);
        sleep(EAT_TIME);
        put_fork(ph_num);
    }
    return NULL;
}

int main()
{
    pthread_t phil[PH_NUM];
    int ph_id[PH_NUM];

    sem_init(&mutex, 0, 1);
    for (int i = 0; i < PH_NUM; i++)
    {
        sem_init(&S[i], 0, 0);
        state[i] = THINKING;
    }
    for (int i = 0; i < PH_NUM; i++)
    {
        ph_id[i] = i;
        pthread_create(&phil[i], NULL, ph, &ph_id[i]);
    }
    for (int i = 0; i < PH_NUM; i++)
    {
        pthread_join(phil[i], NULL);
    }
    sem_destroy(&mutex);
    for (int i = 0; i < PH_NUM; i++)
    {
        sem_destroy(&S[i]);
    }
    return 0;
}
