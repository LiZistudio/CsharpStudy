#include <iostream>

double Add (const double x,const double y){
    double result = x + y;
    return result;
}
double Sub (const double x,const double y){
    double result = x - y;
    return result;
}

int main(int argc, char){
    std::cout << "----------------hello------------------" <<std::endl;
    double (*FuncPointer[]) (double ,double ) = {Add, Sub};
    double num1 = 10.0;
    double num2 = 20.0;
    double res1 = FuncPointer[0] (num1,num2);
    double res2 = FuncPointer[1] (num1,num2);
    std::cout <<"通过指针数组调用求和函数（即委托的演变）值为:"<<res1
              <<"通过指针数组调用求差函数（即委托的演变）值为:"<<res2<<std::endl;
    return 0;
}