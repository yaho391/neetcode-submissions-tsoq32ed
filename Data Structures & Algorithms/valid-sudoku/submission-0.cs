public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var seen = new HashSet<string>();
        for(var row = 0; row < 9; row++)
        {
            for(var col = 0; col < 9; col++)
            {
                 char value = board[row][col];

                 if(value == '.')
                    continue;
                
                string rowCheck = value + " in row " + row;
                string colCheck = value + " in col " + col;
                string boxCheck = value + " in box " + (row/3) + "-" + (col/3);

                if(seen.Contains(rowCheck) || seen.Contains(colCheck) || seen.Contains(boxCheck))
                    return false;
                
                seen.Add(rowCheck);
                seen.Add(colCheck);
                seen.Add(boxCheck);
                
            }
        }
        return true;
    }
}
