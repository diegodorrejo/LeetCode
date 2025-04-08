//https://leetcode.com/problems/roman-to-integer/description

public class Solution {
    public int RomanToInt(string s) {
        int total = 0;
        int prev = 0;
        for(int i = 0; i < s.Length; i++){
            if(i > 0){
                prev = getRomanValue(s[i - 1]);
            }
            total += getRomanValue(s[i]);

            if(getRomanValue(s[i]) > prev){
                total -= (prev * 2);
            }
        }
        return total;
    }

    public int getRomanValue(char x){
        switch(x){
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                return 0;
        }
    }
}