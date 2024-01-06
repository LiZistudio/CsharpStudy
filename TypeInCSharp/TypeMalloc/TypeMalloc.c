#include <stdio.h>

typedef struct Student {
	short Age;
	char* name;
	//struct Student* next;
}Student;

int main() {
	Student* XiaoMing = (Student*)malloc(sizeof(Student));
	XiaoMing->Age = 26;
	return 0;
}