#pragma once

class Student {
public:
	Student(const int& id, char* str):ID(id),Name(str){}
	~Student();
	int GetID();
	void SetID(const int& id);
	char* GetName();
protected:

private:
	int ID;
	char* Name;
};
