using System;

//Write your code here
class Calculator {
    public int power(int n, int p) {
        int result;
        if (p >= 0 && n >= 0) {
            result = Convert.ToInt32(Math.Pow(Convert.ToInt32(n), Convert.ToInt32(p)));
            return result;
        }
        else {
            throw new ArgumentException("n and p should be non-negative");
        }
    }
}

class Solution{
    static void Main(String[] args){
        Calculator myCalculator=new  Calculator();
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]); 
            try{
                int ans=myCalculator.power(n,p);
                Console.WriteLine(ans);
            }
            catch(Exception e){
               Console.WriteLine(e.Message);

            }
        }
        
        
        
    }
}