using System;
using System.Collections.Generic;

class LRUCache{
    private int capacity;
    private Dictionary<int, DLLNode> cache;
    private DoublyLinkedList cachedItems;

    public LRUCache(int capacity){
        this.capacity = capacity;
        cache = new Dictionary<int, DLLNode>(capacity);
        cachedItems = new DoublyLinkedList();
    }

    public void insertOrMoveToFront(int movieID, string title){
        //If item already exists in cache, move it to the front
        if(cache.ContainsKey(movieID)){
            cachedItems.moveFront(cache[movieID]);
        }
        //If the item does not exist in the cache, check if we need to evict an item, insert the item at the head of the list, 
        //and add the node to the cache
        else{
            evictLeastRecentlyWatched();
            cachedItems.insertAtHead(movieID, title);
            cache[movieID] = cachedItems.getHead();
        }
    }

    public void evictLeastRecentlyWatched(){
        if(cachedItems.getSize() >= capacity){
            cachedItems.removeFromTail();
        }
    }

    public void printCacheItems(){
        cachedItems.printList();
    }

}