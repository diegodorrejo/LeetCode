// https://leetcode.com/problems/fizz-buzz/description/

/*
 * Initial solution implemented by me. After solving the problem, 
 * I explored other approaches to learn more about C# features.
 * This alternative solution demonstrates the use of Enumerable.Range, 
 * LINQ's Select, and tuple pattern matching for a more concise implementation.
 */

public class Solution {
    public IList<string> FizzBuzz(int n) {
        var elements = new List<string>();
        for(int i = 1; i <= n; i++){
            if(i % 3 == 0 && i % 5 == 0){
                elements.Add("FizzBuzz");
            }else
            if(i % 5 == 0){
                elements.Add("Buzz");
                
            }else
            if(i % 3 == 0){
                elements.Add("Fizz");
                
            }else{
                elements.Add($"{i}");

            }
        }
        return elements;
    }
}



public class Solution {
    public IList<string> FizzBuzz(int n) {
        return Enumerable
            .Range(1, n)
            .Select(x =>
                (x % 3, x % 5) switch {
                    (0, 0) => "FizzBuzz",
                    (0, _) => "Fizz",
                    (_, 0) => "Buzz",
                        _  => x.ToString()
                })
            .ToList();
    }
}