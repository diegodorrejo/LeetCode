// https://leetcode.com/problems/richest-customer-wealth/description/

public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int Max = 0;
        for(int i = 0; i < accounts.Length; i++){
            int BankTotal = 0;
            for(int j = 0; j < accounts[i].Length; j++){
                BankTotal += accounts[i][j];
            }
            if(BankTotal >= max){
                Max = BankTotal;
            }
        }
        return Max;
    }
}