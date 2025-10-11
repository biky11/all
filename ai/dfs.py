# Graph representation (Romania map example)
graph = {
    'oradea': ['zerind', 'sibiu', 'arad'],
    'zerind': ['arad', 'oradea'],
    'arad': ['timisoara', 'sibiu', 'zerind'],
    'timisoara': ['arad'],
    'sibiu': ['oradea', 'arad', 'rimnicu vilcea', 'fagaras'],
    'rimnicu vilcea': ['fagaras', 'sibiu', 'pitesti'],
    'pitesti': ['rimnicu vilcea', 'bucharest'],
    'fagaras': ['bucharest', 'sibiu', 'rimnicu vilcea'],
    'bucharest': ['fagaras', 'pitesti']
}

# Depth First Search (DFS)
def dfs(node, visited):
    if node not in visited:
        print(node)
        visited.add(node)
        for neighbor in graph.get(node, []):
            dfs(neighbor, visited)

# Start DFS
visited = set()
dfs('oradea', visited)
