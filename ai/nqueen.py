# N-Queens Problem in Python

N = int(input("Enter the number of queens: "))
print("\nThe Solution is:\n")

def display(board):
    for i in range(N):
        for j in range(N):
            print("♕" if board[i][j] == 1 else "⬜", end=" ")
        print()
    print()

def isSafe(board, row, col):
    # Check this row on left side
    for i in range(col):
        if board[row][i] == 1:
            return False

    # Check upper diagonal on left side
    for i, j in zip(range(row, -1, -1), range(col, -1, -1)):
        if board[i][j] == 1:
            return False

    # Check lower diagonal on left side
    for i, j in zip(range(row, N, 1), range(col, -1, -1)):
        if board[i][j] == 1:
            return False

    return True

def queen(board, col):
    if col >= N:
        return True

    for i in range(N):
        if isSafe(board, i, col):
            board[i][col] = 1
            if queen(board, col + 1):
                return True
            board[i][col] = 0  # backtrack
    return False

def solveNQueen():
    board = [[0 for _ in range(N)] for _ in range(N)]
    if not queen(board, 0):
        print("No solution exists.")
        return False
    display(board)
    return True

solveNQueen()
