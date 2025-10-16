import networkx as nx;
import matplotlib.pyplot as plt;

node=input("enter node");
visit=set();

graph={'kankavli':['devgad','oros'],
       'devgad':['kankavli'],
       'oros':['kankavli','malvan','kudal'],
       'kudal':['malvan','oros','sawantwadi'],
       'malvan':['oros','kudal'],
       'sawantwadi':['kudal']}

def dfs(node,visit,graph):
    if node not in visit:
        print(node);
        visit.add(node);
        for i in graph[node]:
            dfs(i,visit,graph);

dfs(node,visit,graph);

G=nx.Graph();
for node in graph:
    for n in graph[node]:
        G.add_edge(node,n);

nx.draw(G,with_labels=True)
plt.show();

