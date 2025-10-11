import heapq
def a_star(graph, heuristics, start, goal):
    open_list = []
    heapq.heappush(open_list, (heuristics[start], 0, start, []))
cost_so_far = {start: 0}

    while open_list:
        f, current_cost, current_node, path = heapq.heappop(open_list)
        if current_node == goal:
            return path + [current_node]
        for neighbor, cost in graph.get(current_node,{}).items():
            new_cost = current_cost + cost

            if neighbor not in cost_so_far or new_cost < cost_so_far[neighbor]:
                cost_so_far[neighbor] = new_cost
                priority = new_cost + heuristics[neighbor]
                heapq.heappush(open_list, (priority, new_cost, neighbor, path + [current_node]))

    return None
graph = {
    'Arad': {'Zerind': 75, 'Sibiu': 140, 'Timisoara': 118},
    'Zerind': {'Arad': 75, 'Oradea': 71},
    'Oradea': {'Zerind': 71, 'Sibiu': 151},
    'Timisoara': {'Arad': 118, 'Lugoj': 111},
    'Lugoj': {'Timisoara': 111, 'Mehadia': 70},
    'Mehadia': {'Lugoj': 70, 'Drobeta': 75},
    'Drobeta': {'Mehadia': 75, 'Craiova': 120},
    'Craiova': {'Drobeta': 120, 'Pitesti': 138, 'Rimnicu Vilcea': 146},
    'Rimnicu Vilcea': {'Craiova': 146, 'Sibiu': 80, 'Pitesti': 97},
    'Sibiu': {'Arad': 140, 'Oradea': 151, 'Rimnicu Vilcea': 80, 'Fagaras': 99},
    'Fagaras': {'Sibiu': 99, 'Bucharest': 211},
    'Pitesti': {'Rimnicu Vilcea': 97, 'Craiova': 138, 'Bucharest': 101},
    'Bucharest': {'Fagaras': 211, 'Pitesti': 101, 'Giurgiu': 90, 'Urziceni': 85},
    'Giurgiu': {'Bucharest': 90},
    'Urziceni': {'Bucharest': 85, 'Vaslui': 142, 'Hirsova': 98},
    'Hirsova': {'Urziceni': 98, 'Eforie': 86},
    'Eforie': {'Hirsova': 86},
    'Vaslui': {'Urziceni': 142, 'Iasi': 92},
    'Iasi': {'Vaslui': 92, 'Neamt': 87},
    'Neamt': {'Iasi': 87}
}
heuristics = {
    'Arad': 366, 'Zerind': 374, 'Oradea': 380, 'Timisoara': 329, 'Lugoj': 244,
    'Mehadia': 241, 'Drobeta': 242, 'Craiova': 160, 'Rimnicu Vilcea': 193,
    'Sibiu': 253, 'Fagaras': 176, 'Pitesti': 100, 'Bucharest': 0, 'Giurgiu': 77,
    'Urziceni': 80, 'Hirsova': 151, 'Eforie': 161, 'Vaslui': 199,
    'Iasi': 226, 'Neamt': 234
}
path = a_star(graph, heuristics,'Arad','Bucharest')
print("Path found:",path)
