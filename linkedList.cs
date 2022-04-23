public class Node{
    public int data;
    public Node next;

    public Node(int data){
        this.data = data;
        this.next = null;
    }

}

public class LinkedList{
    public Node head = null;

    public LinkedList(){
        this.head = null;
    }

    public Node append(int val){
        Node newNode = new Node(val);

        if(this.head == null){
            this.head = newNode;
            return newNode;
        }

        Node currentNode = this.head;

        while(currentNode.next != null){
            currentNode = currentNode.next;
        }

        currentNode.next = newNode;

        return currentNode.next;
    }

    public Node createLinkedList(int[] vals){

        foreach(int val in vals){
            this.append(val);
        }

        return this.head;

    }


    
}