#include <stdio.h>
#include <math.h>

double GetCylinderVolume(const double r, const double h) {
	double result = 3.14 * r * r * h;
	return result;
}

int main() {
	double res = GetCylinderVolume(2.00, 10.00);
	printf("%f\n", res);
	return 0;
}