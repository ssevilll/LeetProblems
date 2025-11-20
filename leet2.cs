// public class Solution {
//     public int IntersectionSizeTwo(int[][] intervals) {
//         Array.Sort(intervals, (a, b) => a[1] != b[1] ? a[1] - b[1] : b[0] - a[0]);
//         int n = intervals.Length;
//         int count = 0;
//         int first = -1, second = -1;

//         for (int i = 0; i < n; i++) {
//             int start = intervals[i][0];
//             int end = intervals[i][1];

//             if (start <= first) {
//                 continue;
//             } else if (start > second) {
//                 count += 2;
//                 first = end - 1;
//                 second = end;
//             } else {
//                 count += 1;
//                 first = second;
//                 second = end;
//             }
//         }

//         return count;        
//     }
// }


// public class Solution {
//     public int LongestConsecutive(int[] nums) {
//         HashSet<int> numSet = new HashSet<int>(nums);
//         int longestStreak = 0;

//         foreach (int num in numSet) {
//             if (!numSet.Contains(num - 1)) {
//                 int currentNum = num;
//                 int currentStreak = 1;

//                 while (numSet.Contains(currentNum + 1)) {
//                     currentNum += 1;
//                     currentStreak += 1;
//                 }

//                 longestStreak = Math.Max(longestStreak, currentStreak);
//             }
//         }

//         return longestStreak;
//     }
// }


// public class Solution {
//     public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
//         HashSet<string> wordSet = new HashSet<string>(wordList);
//         if (!wordSet.Contains(endWord)) {
//             return 0;
//         }

//         Queue<(string word, int length)> queue = new Queue<(string word, int length)>();
//         queue.Enqueue((beginWord, 1));
//         HashSet<string> visited = new HashSet<string> { beginWord };

//         while (queue.Count > 0) {
//             var (currentWord, length) = queue.Dequeue();

//             if (currentWord == endWord) {
//                 return length;
//             }

//             for (int i = 0; i < currentWord.Length; i++) {
//                 char[] charArray = currentWord.ToCharArray();
//                 for (char c = 'a'; c <= 'z'; c++) {
//                     charArray[i] = c;
//                     string newWord = new string(charArray);

//                     if (wordSet.Contains(newWord) && !visited.Contains(newWord)) {
//                         visited.Add(newWord);
//                         queue.Enqueue((newWord, length + 1));
//                     }
//                 }
//             }
//         }

//         return 0;
//     }
// }


// public class Solution {
//     public bool WordPattern(string pattern, string s) {
//         string[] words = s.Split(' ');
//         if (pattern.Length != words.Length) {
//             return false;
//         }

//         Dictionary<char, string> charToWord = new Dictionary<char, string>();
//         Dictionary<string, char> wordToChar = new Dictionary<string, char>();

//         for (int i = 0; i < pattern.Length; i++) {
//             char c = pattern[i];
//             string word = words[i];

//             if (charToWord.ContainsKey(c)) {
//                 if (charToWord[c] != word) {
//                     return false;
//                 }
//             } else {
//                 charToWord[c] = word;
//             }

//             if (wordToChar.ContainsKey(word)) {
//                 if (wordToChar[word] != c) {
//                     return false;
//                 }
//             } else {
//                 wordToChar[word] = c;
//             }
//         }

//         return true;
//     }
// }