public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (int i = 0; i < 9; i++) {
            var row = new HashSet<char>();
            var col = new HashSet<char>();
            var box = new HashSet<char>();

            for (int j = 0; j < 9; j++) {
                // Check row
                if (board[i][j] != '.') {
                    if (!row.Add(board[i][j]))
                        return false;
                }

                // Check column
                if (board[j][i] != '.') {
                    if (!col.Add(board[j][i]))
                        return false;
                }

                // Check 3x3 box
                int boxRow = (i / 3) * 3 + j / 3;
                int boxCol = (i % 3) * 3 + j % 3;

                if (board[boxRow][boxCol] != '.') {
                    if (!box.Add(board[boxRow][boxCol]))
                        return false;
                }
            }
        }

        return true;
    }
}
