// O(1) algorithm
public class Solution {
    private bool IsDot(ref char[][] board, int i, int j) {
        if (i < 0 || i >= board.Length) 
            return true;
        if (j < 0 || j >= board[0].Length)
            return true;
        return board[i][j] == '.';
    }
    private bool Right(ref char[][] board, int i, int j) {
        return IsDot(ref board, i - 1, j) && IsDot(ref board, i + 1, j) && IsDot(ref board, i, j - 1);
    }

    private bool Down(ref char[][] board, int i, int j) {
        return IsDot(ref board, i, j + 1) && IsDot(ref board, i + 1, j) && IsDot(ref board, i, j - 1);
    }

    public int CountBattleships(char[][] board) {
        int count = 0;
        for (int i = 0; i < board.Length; ++i)
            for (int j = 0; j < board[i].Length; ++j)
                if (board[i][j] == 'X' && (Right(ref board, i, j) || Down(ref board, i, j)))
                    ++count;

        return count;
    }
}