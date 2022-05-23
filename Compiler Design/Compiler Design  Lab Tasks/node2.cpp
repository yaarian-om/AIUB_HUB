#include <iostream>

using namespace std;

struct node
{
    struct node*left;
    int data;
    struct node*right;

};


int main()
{

    struct node*root= (struct node*)malloc(sizeof(struct node));
    root->data =10;
    root->left= NULL;
    root->right= NULL;

    struct node* n3 = new node();
    n3->data = 8;
    n3->left= NULL;
    n3->right= NULL;
    //cout<<n1->left<<endl;

    root->right=n3;
    struct node*root1= root;

    cout<<root1->data<<endl;
    while(root1->left!= NULL)
        root1 = root1->left;
        cout<<root1->left<<endl;
    root1=root;
     while(root1->right!= NULL)
        root1 = root1->right;
        cout<<root1->data<<endl;




    return 0;
}
