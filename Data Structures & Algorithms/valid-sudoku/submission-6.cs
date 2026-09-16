// Implement using binary bit shifting on box next time

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<string, HashSet<char>> squares = new()
        {
            {"00", new()},
            {"01", new()},
            {"02", new()},
            {"10", new()},
            {"11", new()},
            {"12", new()},
            {"20", new()},
            {"21", new()},
            {"22", new()}
        };
        for (int i = 0; i < board.Length; i++){
            HashSet<char> columns = new();
            HashSet<char> rows = new();
            for (int j = 0; j < board[0].Length; j++){
                char symbolRow = board[i][j];
                char symbolCol = board[j][i];
                int x = i / 3;
                int y = j / 3;
                string sq = $"{x}{y}";

                if (!(symbolRow == '.')){
                    if (!rows.Add(board[i][j]) || !squares[sq].Add(board[i][j])){
                        return false;
                    }
                }
                if  (!(symbolCol == '.')){
                    if (!columns.Add(board[j][i])){
                        return false;                    
                    }
                }
            }
        }
        return true;
    }
}
