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
    std::cout <<"ͨ��ָ�����������ͺ�������ί�е��ݱ䣩ֵΪ:"<<res1
              <<"ͨ��ָ�����������������ί�е��ݱ䣩ֵΪ:"<<res2<<std::endl;
    return 0;
}