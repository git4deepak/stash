####
# Tick Tac Toe game
####

# Board Size 3X3
def run_game():
    """
    Runs the tic tac toe game
    """
     
    def new_board(x, y):
        """
        Creats and returns a board of given dimensions.
        """
        r = []
        for i in range(x):
            c = []
            for j in range(y):
                c.append(" ")
            r.append(c)
        return r
    #end new_board

    size = 3
    board = new_board(size, size)



    def print_board(board):
        """
        prints the given board.
        """
        for row in board:
            print(row)
    #end print_board 

    def fill_cell(x,y, player):
        """
        Fills the cell with given palyer mark.
        """
        board[x][y] = player
    
    #end fill_cell

    def has_same_elements(lst):
        """
        Rturn true is all elements given list are same
        """
        if len(lst) <= 1: return True
        if lst[0] == " ": return False

        for i in range(1, len(lst)):
            if (lst[i] != lst[i-1]): return False
        return True

    def did_player_win(p):
        """
        Evaluate the board to see if given player won.
        """
        r = []
        c = []
        d = [[],[]]
        i = 0
        # get rows columns and diagonals
        for row in board:
            r.append(row);
            j = 0
            for v in row:
                # skip empty values
                #if(v == p):
                #row
                if j < len(c): c[j].append(v)
                else: c.append([v])
                #diagonals
                if i==j : d[0].append(v)
                if i+j == size-1: d[1].append(v)
                j += 1
            i += 1
            
        # player won if length of any list is 'size'        
        for lst in (r + c + d):
            if(has_same_elements(lst)):
                return True
                
        return False
    #end eval_board


    print_board(board)
    i = 0
    game_won = False
    while (not game_won):
        if i%2 ==0 :
            p = "O"
        else:
            p = "X"

        prompt = "Player " + p + " Enter your cell as x,y: "
        s = input(prompt);
        (x,y) = s.split(",")
        fill_cell(int(x)-1, int(y)-1, p) 
        print("")
        print_board(board)
        print("")
        game_won = did_player_win(p)
        # declare if there is a winner
        if(game_won):
            print ("Player {} Won".format (p))

        i += 1
    #end run_game

