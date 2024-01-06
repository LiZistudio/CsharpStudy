#include <stdio.h>
#include <malloc.h>

typedef struct Student {
	short Age;
	char* name;
	//struct Student* next;
}Student;

int main() {
	Student* XiaoMing = (Student*)malloc(sizeof(Student));
	XiaoMing->Age = 26;
	printf("小明的年龄为:%d\n", XiaoMing->Age);
	free(XiaoMing);
	XiaoMing = NULL;
	return 0;
}