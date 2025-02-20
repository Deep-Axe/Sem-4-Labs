#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <dirent.h>
#include <sys/stat.h>
#include <unistd.h>
#include <fcntl.h>

void listFiles()
{
    struct dirent *entry;
    struct stat fileStat;
    DIR *dir = opendir(".");

    if (dir == NULL)
    {
        perror("Could not open directory");
        return;
    }

    while ((entry = readdir(dir)) != NULL)
    {
        stat(entry->d_name, &fileStat);
        printf("%c%c%c%c%c%c%c%c%c%c %ld %s\n",
               (S_ISDIR(fileStat.st_mode)) ? 'd' : '-',
               (fileStat.st_mode & S_IRUSR) ? 'r' : '-',
               (fileStat.st_mode & S_IWUSR) ? 'w' : '-',
               (fileStat.st_mode & S_IXUSR) ? 'x' : '-',
               (fileStat.st_mode & S_IRGRP) ? 'r' : '-',
               (fileStat.st_mode & S_IWGRP) ? 'w' : '-',
               (fileStat.st_mode & S_IXGRP) ? 'x' : '-',
               (fileStat.st_mode & S_IROTH) ? 'r' : '-',
               (fileStat.st_mode & S_IWOTH) ? 'w' : '-',
               (fileStat.st_mode & S_IXOTH) ? 'x' : '-',
               fileStat.st_size, entry->d_name);
    }
    closedir(dir);
}

void copyFile(char *src, char *dest)
{
    int source = open(src, O_RDONLY);
    if (source < 0)
    {
        perror("Error opening source file");
        return;
    }

    int destination = open(dest, O_WRONLY | O_CREAT | O_TRUNC, 0644);
    if (destination < 0)
    {
        perror("Error opening destination file");
        close(source);
        return;
    }

    char buffer[1024];
    ssize_t bytes;
    while ((bytes = read(source, buffer, sizeof(buffer))) > 0)
    {
        write(destination, buffer, bytes);
    }

    close(source);
    close(destination);
    printf("File copied successfully.\n");
}

void wordCount(char *filename)
{
    FILE *file = fopen(filename, "r");
    if (!file)
    {
        perror("Error opening file");
        return;
    }

    int lines = 0, words = 0, chars = 0;
    char ch, prev = ' ';
    while ((ch = fgetc(file)) != EOF)
    {
        chars++;
        if (ch == '\n')
            lines++;
        if ((ch == ' ' || ch == '\n' || ch == '\t') && (prev != ' ' && prev != '\n' && prev != '\t'))
            words++;
        prev = ch;
    }
    fclose(file);
    printf("Lines: %d Words: %d Characters: %d\n", lines, words, chars);
}

int main(int argc, char *argv[])
{
    if (argc < 2)
    {
        printf("Usage:\n  %s ls\n  %s cp <source> <destination>\n  %s wc <file>\n", argv[0], argv[0], argv[0]);
        return 1;
    }

    if (strcmp(argv[1], "ls") == 0)
    {
        listFiles();
    }
    else if (strcmp(argv[1], "cp") == 0)
    {
        if (argc != 4)
        {
            printf("Usage: %s cp <source> <destination>\n", argv[0]);
            return 1;
        }
        copyFile(argv[2], argv[3]);
    }
    else if (strcmp(argv[1], "wc") == 0)
    {
        if (argc != 3)
        {
            printf("Usage: %s wc <file>\n", argv[0]);
            return 1;
        }
        wordCount(argv[2]);
    }
    else
    {
        printf("Invalid command.\n");
    }

    return 0;
}
