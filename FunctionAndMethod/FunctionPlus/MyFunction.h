#pragma once

class MyFunction
{
public:
	MyFunction(const double x, const double y) :a(x), b(y){}
	~MyFunction();
	double& AddAndab(const double& x, const double& y);

protected:

private:
	double a;
	double b;
	char* str;
};

