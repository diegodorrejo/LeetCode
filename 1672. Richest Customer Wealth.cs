public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int max = 0;
        for(int i = 0; i < accounts.Length; i++){
            int BankTotal = 0;
            for(int j = 0; j < accounts[i].Length; j++){
                BankTotal += accounts[i][j];
            }
            if(BankTotal >= max){
                max = BankTotal;
            }
        }
        return max;
    }
}