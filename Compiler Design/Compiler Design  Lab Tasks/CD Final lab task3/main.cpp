#include<bits/stdc++.h>
using namespace std;

void printRandom(char a,char b,char c,char d){

char cap,small,spc,num;
    int r;

    srand (time(NULL));
    for (int i=0; i<2; i++)
    {    r = rand() % 26;
          cap = 'A' + r;
          cout << cap;
    }

    srand (time(NULL));
    for (int i=0; i<2; i++)
    {    r = rand() %5 ;
          spc = '!'+r;
          cout << spc;
    }

    srand (time(NULL));
    for (int i=0; i<2; i++)
    {    r = rand() % 26;
          small = 'a' + r;
          cout << small;
    }

    srand (time(NULL));
    for (int i=0; i<3; i++)
    {    r = rand() % 10;
         num  = '0' + r;
          cout << num;
    }
}

int main(){

 char c,s,sp,n;
 printRandom(c,s,sp,n);

return 0;
}
