using System;
using System.Collections.Generic;

public class Graph{

    private Dictionary<string, HashSet<string>> adjacencyList;

    public Graph(){
        adjacencyList = new Dictionary<string, HashSet<string>>();
    }

    public void addVertex(string key){
        if(!adjacencyList.ContainsKey(key)){
            adjacencyList[key] = new HashSet<string>();
        }
    }

    public void addEdge(string vertex1, string vertex2){
        if(adjacencyList.ContainsKey(vertex1) && adjacencyList.ContainsKey(vertex2)){
            adjacencyList[vertex1].Add(vertex2);
            adjacencyList[vertex2].Add(vertex1);
        }
    }

}