// public class Solution {
//     public int CountPalindromicSubsequence(string s) {
//         HashSet<string> palindromicSubsequences = new HashSet<string>();
//         int n = s.Length;

//         for (int i = 0; i < n; i++) {
//             for (int j = i + 1; j < n; j++) {
//                 if (s[i] == s[j]) {
//                     for (int k = i + 1; k < j; k++) {
//                         palindromicSubsequences.Add(s[i] + s[k].ToString() + s[j]);
//                     }
//                 }
//             }
//         }

//         return palindromicSubsequences.Count;
//     }
// }

// public class Solution {
//     public int FirstUniqChar(string s) {
//         int[] freq = new int[26];

//         foreach (char c in s)
//             freq[c - 'a']++;

//         for (int i = 0; i < s.Length; i++) {
//             if (freq[s[i] - 'a'] == 1)
//                 return i;
//         }

//         return -1;
//     }
// }


// public class Solution {
//     public int CompareVersion(string version1, string version2) {
//         int i = 0, j = 0;
//         int n1 = version1.Length, n2 = version2.Length;

//         while (i < n1 || j < n2) {
//             int num1 = 0, num2 = 0;

//             while (i < n1 && version1[i] != '.') {
//                   num1 = num1 * 10 + (version1[i] - '0');
//                   i++;
//             }

//             i++;

//             while (j < n2 && version2[j] != '.') {
//                   num2 = num2 * 10 + (version2[j] - '0');
//                   j++;
//             }

//             j++;

//             if (num1 < num2) return -1;
//             if (num1 > num2) return 1;
//         }

//         return 0;
//     }
// }
