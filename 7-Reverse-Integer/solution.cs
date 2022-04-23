// M https://leetcode.com/problems/reverse-integer/

public class Solution {
    public int Reverse(int x) {
        int sol = 0;
        
        int maxPre = int.MaxValue / 10;
        int maxMod = int.MaxValue % 10;
        int minPre = int.MinValue / 10;
        int minMod = int.MinValue % 10;
        while (x != 0){
            int mod = x % 10;

            // We need to check boundary!
            // Prefix Check
            if (sol > maxPre || sol < minPre)
                return 0;
            // Suffix Check
            if (sol == maxPre && mod > maxMod)
                return 0;
            if (sol == minPre && mod < minMod)
                return 0;

            sol = sol * 10 + mod;
            x /= 10;
        }
        
        return sol;
    }
}

public class Solution {
    public int Reverse(int x) {
        long sol = 0;
        
        while (x != 0){
            int mod = x % 10;
            sol = sol * 10 + mod;
            x /= 10;
        }
        
        int iSol = (int)sol;
        return sol == iSol ? iSol : 0;
    }
}