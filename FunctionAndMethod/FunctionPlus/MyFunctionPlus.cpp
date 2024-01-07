#include <iostream>
#include "MyFunction.h"

int main() {
	std::cout << "MyFunction" << std::endl;
	MyFunction* mf1 = new MyFunction(10.0,20.0);
	double& result = mf1->AddAndab(6.66, 8.88);
	std::cout << result << std::endl;
	return 0;
}