#include <iostream>

using namespace std;


class TestNewDel{

private:

int TestVar;
char *TestPtr;



public:

TestNewDel();

int DisplayValue();

char* DisplayStr();

~TestNewDel();

};

 

// class implementation

// constructor

TestNewDel::TestNewDel()

{

// test how the constructor is invoked

static int x=1;

cout<<"In Constructor, pass #"<<x<<endl;

x++;

}

 

// simple function returning a value

int TestNewDel::DisplayValue()

{

return TestVar = 200;

}

 

// another function returning a string

char* TestNewDel::DisplayStr()

{

TestPtr = "Testing the new and delete";

return TestPtr;

}

 

// destructor

TestNewDel::~TestNewDel()

{

// test how destructor is invoked, use static type to retain previous value

static int y=1;

cout<<"In Destructor, pass #"<<y<<endl;

y++;

// clean up explicitly

TestVar = 0;

}

 

// main program

int main(void)

{

// instantiate an object, constructor should be invoked with proper memory allocation

TestNewDel Obj1;

 

cout<<"In main, testing 1...2...3..."<<endl;

 

// display the data value

cout<<"Default constructor value assign to Obj1 = "<<Obj1.DisplayValue()<<endl;

 

// invoke constructor explicitly, remember to clean up later explicitly

TestNewDel* Obj2 =new TestNewDel;

 

// re-confirm the allocation for Obj2

if(!Obj2)

cout<<"Allocation to Obj2 failed!"<<endl;

else

cout<<"Allocation to Obj2 is OK!"<<endl;

 

// display the data value

cout<<"Default constructor value "

<<"\n assigned to Obj2 = "<<"\'"<<Obj2->DisplayStr()<<"\'"<<endl;

 

// clean up the allocation explicitly

delete Obj2;

 

return 0;

}
