public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        if (nums.Contains(original)) {
            return FindFinalVale(nums, original * 2);
        } else {
            return original;
        }
    }
}


public class Solution {
    public void MoveZeroes(int[] nums) {
        for (int i = 0, j = 0; j < nums.Length; j++) {
            if (nums[j] != 0) {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
            }
        }
    }
}


public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int i = 0, j = 0;
        while (i < g.Length && j < s.Length) {
            if (g[i] <= s[j]) {
                i++;
            }
            j++;
        }
        return i;
    }
}



public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        IList<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++) {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0) {
                nums[index] = -nums[index];
            }
        }
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) {
                result.Add(i + 1);
            }
        }
        return result;
        
    }
}


public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int perimeter = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;
        
        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid[r][c] == 1) {
                    perimeter += 4;
                    
                    if (r > 0 && grid[r - 1][c] == 1) {
                        perimeter -= 2;
                    }
                    if (c > 0 && grid[r][c - 1] == 1) {
                        perimeter -= 2;
                    }
                }
            }
        }
        
        return perimeter;
    }
}