#include <iostream>
#include "MyClass.h"


int main() {

	std::cout << "hello" << std::endl;
	int id = 10;
	char str[] = "Authur";

	Student* stu = new Student(10, str);
	std::cout << "My name is " 
		      << stu->GetName() 
			  << "." << "I'm #" 
			  << stu->GetID()<<"." << std::endl;
	stu->SetID(5);
	std::cout << "My name is "
		<< stu->GetName()
		<< "." << "I'm #"
		<< stu->GetID() <<"." << std::endl;
	return 0;
}