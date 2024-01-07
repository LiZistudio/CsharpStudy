#include "MyFunction.h"


MyFunction::~MyFunction() {
	delete[] str;
}

double& MyFunction::AddAndab(const double& x, const double& y) {
	double Result = a+b+x+y;
	return Result;
}