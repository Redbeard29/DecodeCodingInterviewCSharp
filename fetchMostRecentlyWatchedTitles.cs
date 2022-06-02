using System;
using System.Collections.Generic;

class FetchMostRecentlyWatchedTitles{

    public static void Helper(){
        DoublyLinkedList myDLL = new DoublyLinkedList();
        myDLL.insertAtHead(1, "The Lion King");
        myDLL.insertAtHead(2, "Weekend at Bernie's");
        myDLL.insertAtHead(3, "2 Fast, 2 Furious");
        myDLL.insertAtHead(5, "Hustle & Flow");
        myDLL.printList();
        // myDLL.removeFromTail();
        myDLL.moveFront(myDLL.getTail());
        myDLL.insertAtHead(15, "Encanto");
        myDLL.insertAtHead(35, "Frozen II");
        myDLL.printList();
    }

}