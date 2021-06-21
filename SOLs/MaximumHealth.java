import java.util.*;

public class MaximumHealth {

    public static void main(String[] args) {
        int[][] accounts = { { 5,5,6}, { 3,2,1}, {10,2,1} };
        maximumWealth(accounts);
    }
    
    public static int maximumWealth(int[][] accounts) {
        int max = 0;
        for (int i = 0; i < accounts.length; i++) {
            int tempWealth = 0;
            for (int j = 0; j < accounts[i].length; j++) {
                tempWealth += accounts[i][j];
            }

            if (tempWealth >= max) {
                max = tempWealth;
            }
            tempWealth = max;
        }
        return max;
    }
}