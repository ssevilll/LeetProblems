// public class Solution {
//     public int MinimumOperations(int[] nums) {
//         int ops = 0;

//         foreach (int x in nums) {
//             int r = x % 3;
//             ops += Math.Min(r, 3 - r);
//         }

//         return ops;
//     }
// }



// public class Solution {
//     public int EvalRPN(string[] tokens) { //["2","1","+","3","*"]
//         Stack<int> stack = new Stack<int>();

//         foreach (string token in tokens) {
//             if (token == "+" || token == "-" || token == "*" || token == "/") {
//                 int b = stack.Pop();
//                 int a = stack.Pop();
//                 int result = 0;

//                 switch (token) {
//                     case "+":
//                         result = a + b;
//                         break;
//                     case "-":
//                         result = a - b;
//                         break;
//                     case "*":
//                         result = a * b;
//                         break;
//                     case "/":
//                         result = a / b;
//                         break;
//                 }

//                 stack.Push(result);
//             } else {
//                 stack.Push(int.Parse(token));
//             }
//         }

//         return stack.Pop();
//     }
// }



// public class Solution {
//     public string FractionToDecimal(int numerator, int denominator) { //1,2,0.5
//         if (numerator == 0) return "0";
//         StringBuilder result = new StringBuilder();

//         // Handle sign
//         if ((numerator < 0) ^ (denominator < 0)) {
//             result.Append("-");
//         }

//         long num = Math.Abs((long)numerator);
//         long den = Math.Abs((long)denominator);

//         // Integral part
//         result.Append(num / den);
//         num %= den;

//         if (num == 0) return result.ToString();

//         result.Append(".");

//         // Fractional part
//         Dictionary<long, int> map = new Dictionary<long, int>();
//         while (num != 0) {
//             if (map.ContainsKey(num)) {
//                 int index = map[num];
//                 result.Insert(index, "(");
//                 result.Append(")");
//                 break;
//             }

//             map[num] = result.Length;
//             num *= 10;
//             result.Append(num / den);
//             num %= den;
//         }

//         return result.ToString();
//     }
// }



// public class Solution {
//     public int TrailingZeroes(int n) { //5! =>1
//         int count = 0;
//         while (n >= 5) {
//             n /= 5;
//             count += n;
//         }
//         return count;
//     }
// }


// public class Solution {
//     public void Rotate(int[] nums, int k) {
//         int n = nums.Length;
//         k = k % n;

//         Reverse(nums, 0, n - 1);
//         Reverse(nums, 0, k - 1);
//         Reverse(nums, k, n - 1);
//     }
//     private void Reverse(int[] nums, int left, int right) {
//         while (left < right) {
//             int temp = nums[left];
//             nums[left] = nums[right];
//             nums[right] = temp;
//             left++;
//             right--;
//         }
//     }
// }