#include <stdio.h>
#include "MyFunction.h"

int main() {
	printf("my_function\n");
	double a = 6.66;
	double b = 8.88;
	double Res = Add(a, b);
	printf("%f+%fµÄºÍÎª:%f\n",a,b, Res);
	return 0;
}