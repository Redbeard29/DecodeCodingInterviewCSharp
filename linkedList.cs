public class Node{
    public int data;
    public Node next;

    public Node(int data){
        this.data = data;
        this.next = null;
    }

}

public class LinkedList{
    public Node head;
    public int length;

    public LinkedList(){
        this.head = null;
        this.length = 0;
    }

    public Node append(int val){
        Node newNode = new Node(val);

        if(this.head == null){
            this.head = newNode;
            this.length++;
            return newNode;
        }

        Node currentNode = this.head;

        while(currentNode.next != null){
            currentNode = currentNode.next;
        }

        currentNode.next = newNode;
        this.length++;
        return currentNode.next;
    }

    public Node createLinkedList(int[] vals){

        foreach(int val in vals){
            this.append(val);
            this.length++;
        }

        return this.head;

    }

    public void printListVals(){
        int[] listHolder = new int[this.length];
        Node currentNode = this.head;
        for(int x = 0; x < this.length; x++){
            listHolder[x] = currentNode.data;
            if(currentNode.next != null){
                currentNode = currentNode.next;
            }
        }

        System.Console.WriteLine(listHolder);
    }
    
}

