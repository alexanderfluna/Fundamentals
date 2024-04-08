// Example:
 
#include<iostream>
using namespace std;
 
class A
{
              protected:
              int a;
   
              public:
                  void set_A()
                  {
                        cout<<"Enter the Value of A=";
                        cin>>a;
          
                  }
 
                  void disp_A()
                  {
                        cout<<endl<<"Value of A="<<a;
                  }
};
 
class B: public A
{
           protected:
                int b;
             
           public:
                   void set_B()
                {
                      cout<<"Enter the Value of B=";
                       cin>>b;
                   }
 
         
                void disp_B()
                  {
                     cout<<endl<<"Value of B="<<b;
                  }
};
 
class C: public B
{
      int c,p;
       
      public:
          void set_C()
          {
                 cout<<"Enter the Value of C=";
                 cin>>c;
           }
         
           void disp_C()
           {
                 cout<<endl<<"Value of C="<<c;
           }
     
            void cal_product()
             {
                   p=a*b*c;
                  cout<<endl<<"Product of "<<a<<" * "<<b<<" * "<<c<<" = "<< p << endl;
              }
};
 
int main()
{
     
    C _c;
    _c.set_A();
    _c.set_B();
    _c.set_C();
    _c.disp_A();
    _c.disp_B();
    _c.disp_C();
    _c.cal_product();
     
    return 0;
     
}