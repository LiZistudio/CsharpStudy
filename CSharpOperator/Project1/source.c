#include <stdio.h>
#include <malloc.h>

typedef struct Student {
	int number;
	char* Name;
}Student;

int main() {
	//Student Stu1 = { 1,"LiHua" };
	/*Student Stu1;
	Stu1.Name = "LiHua";*/
	Student* Stu1 = (Student*)malloc(sizeof(Student));
	Stu1->Name = "lihua";
	printf("%s\n", Stu1->Name);
	free(Stu1);
	Stu1 = NULL;
	return 0;
}