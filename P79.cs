public class Solution {
    private bool Dfs(int stx, int sty,ref char[][] board, string word)
    {
        if (word == "")
            return true;
        
        var c = board[stx][sty];
        board[stx][sty] = ';';
        for (int i = -1; i <= 1; i += 2)
        {
            if (stx + i >= 0 && stx + i < board.Length && board[stx + i][sty] == word[0])
                if (Dfs(stx + i, sty, ref board, word.Substring(1)))
                    return true;
            if (sty + i >= 0 && sty + i < board[0].Length && board[stx][sty + i] == word[0])
                if (Dfs(stx, sty + i, ref board, word.Substring(1)))
                    return true;
        }
        board[stx][sty] = c;
        return false;
    }
    public bool Exist(char[][] board, string word) {
        if (board.Length == 0)
        {
            if (word == "")
                return true;
            else return false;
        }

        for (int i = 0; i < board.Length; ++i)
            for (int j = 0; j < board[0].Length; ++j)
                if (board[i][j] ==  word[0])
                    if (Dfs(i, j, ref board, word.Substring(1)))
                        return true;
        return false;
    }
}