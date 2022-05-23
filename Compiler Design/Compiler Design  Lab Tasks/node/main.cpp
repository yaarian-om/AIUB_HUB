#include <iostream>

using namespace std;

struct node
{
    struct node*left;
    int age;
    string name;
    struct node*right;

};


int main()
{

    struct node*root= (struct node*)malloc(sizeof(struct node));
    root->age =80;
    root->left= NULL;
    root->name= "Mr x";

    struct node* n3 = new node();
    n3->age =82;
    n3->left= NULL;
    n3->name= "Mr p";
    //cout<<n1->left<<endl;

    root->right=n3;
    struct node*root1= root;


   /* cout<<"Name: "<<root->name<<endl;
    while(root->left= NULL)
        root = root->left;
    cout<<"Age: "<<n2->age<<endl;*/

    cout<<"Age 1: "<<root1->age<<endl;
    while(root1->left!= NULL)
        root1 = root1->left;
        //cout<<root1->age<<endl;
        cout<<"Name 1: "<<root1->name<<endl;
    root1=root;
     while(root1->right!= NULL)
        root1 = root1->right;
        cout<<"Age 2: "<<root1->age<<endl;
        cout<<"Name 2: "<<root1->name<<endl;




    return 0;
}
