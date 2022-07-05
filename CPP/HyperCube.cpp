
#include <iostream>
#include <cmath>


int main()
{   
    
    int number,n,d, i=0,k=0;
    int result = 0;
    int temp = 0;
    std::cin>>number;
    for (; i<number; i++) {
        std::cin>>n>>d;
        d > n/2 ? k=n-d: k=d;
    //    std::cout<<pow(2,n-1)<<"\n";
    //    std::cout<<tgamma(k+1)<<"\n";
    //    std::cout<<tgamma(n-k+1)<<"\n";
    //    std::cout<<tgamma(n+1)<<"\n";
    //    std::cout<<temp<<"\n";
        result = pow(2,n-1)*(tgamma(n+1)/(tgamma(k+1)*tgamma((n-k)+1)));
        std::cout<<result<<" "<<"\n";
    }
    

    return 0;
}
