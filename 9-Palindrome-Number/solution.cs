// E https://leetcode.com/problems/palindrome-number/

public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
            return false;
        if (x < 10)
            return true;

        var c = x.ToString().ToCharArray();
        int len = c.Length;


        if (c[len - 1] == '0')
            return false;
        
        // [0]...[len - 1]
        for (int i = 0; i < len / 2; ++i) {
            if (c[i] != c[len - 1 - i])
                return false;
        }
        return true;
    }
}

public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
            return false;
        if (x % 10 == 0 && x != 0)
            return false;
        
        int revNum = 0;
        while (x > revNum) {
            revNum = revNum * 10 + x % 10;
            x /= 10;
        }
        return x == revNum || x == revNum / 10;
    }
}