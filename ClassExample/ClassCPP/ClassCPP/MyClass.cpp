#include "MyClass.h"

//Student::Student(const int& id, char* str) {
//	ID = id;
//	Name = str;
//}

Student::~Student() {
	delete[] Name;
}

int Student::GetID() {
	return ID;
}
void Student::SetID(const int& id) {
	this->ID = id;
}

char* Student::GetName() {
	return Name;
}