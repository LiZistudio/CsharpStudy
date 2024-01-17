
//CSharp中委托的演变：自c\c++的函数指针
//以下是函数指针和函数指针数组

#include <stdio.h>

int MyFunction() {
	printf("hello delegate\n");
	return 0;
}
int Add(const int a, const int b) {
	int result = a + b;
	return result;
}
int Sub(const int a, const int b) {
	int result = a - b;
	return result;
}

int main() {
	//void (*PointerFun) () = &MyFunction;
	//PointerFun();
	//int (*AddPointer) (int,int) = &Add;
	//printf("%d\n",AddPointer(3, 4));

	int (*FunPointer[]) () = { MyFunction,Add,Sub};
	FunPointer[0]();
	printf("%d\n%d\n", FunPointer[1](5,6),FunPointer[2](5,6));
	return 0;
}
