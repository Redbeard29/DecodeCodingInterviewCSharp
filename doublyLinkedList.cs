public class DLLNode{

    public int data;
    public DLLNode next;
    public DLLNode prev;

    public DLLNode(int data){
        this.data = data;
        this.next = null;
        this.prev = null;
    }

    public DLLNode(int data, DLLNode next){
        this.data = data;
        this.next = next;
        this.prev = null;
    }

    public DLLNode(int data, DLLNode next, DLLNode prev){
        this.data = data;
        this.next = next;
        this.prev = prev;
    }

}

public class DoublyLinkedList{
    private DLLNode head;
    private DLLNode tail;
    private int size;

    public DoublyLinkedList(){
        this.head = null;
        this.tail = null;
        this.size = 0;
    }

    public void insertAtHead(int data){
        DLLNode currentNode = new DLLNode(data);
        if(this.head == null){
            this.head = currentNode;
            this.tail = currentNode;
        }
        else{
            currentNode.next = this.head;
            this.head.prev = currentNode;
            this.head = currentNode;
        }
        this.size++;
    }

    public void removeFromTail(){
        if(this.tail != null){
            DLLNode newTail = this.tail.prev;

            newTail.next = null;
            this.tail.prev = null;
            this.tail = newTail;

            this.size--;
        }

        else{
            System.Console.WriteLine("Tail is null, and therefore cannot be removed.");
        }

    }

    public DLLNode moveFront(DLLNode node){

        if(node == null){
            System.Console.WriteLine("This node contains a null value - please pass in a node that contains data.");
            return new DLLNode(null);
        }

        if(node == this.head){
            return node;
        }

        else if(node == this.tail){
            node.prev.next = null;
            this.tail = node.prev;
        }

        else if(node != this.tail){
            node.next.prev = node.prev;
            node.prev.next = node.next;
        }

        node.next = this.head;
        node.prev = null;
        this.head.prev = node;
        this.head = node;

        return node;

    }

    public void printList(){
        int[] listHolder = new int[this.size];
        DLLNode currentNode = this.head;
        int idx = 0;

        while(currentNode != null){
            listHolder[idx] = currentNode.data;
            currentNode = currentNode.next;
            idx++;
        }

        foreach(int item in listHolder){
            System.Console.WriteLine(item);
        }

    }

    public DLLNode getHead(){
        return this.head;
    }

    public DLLNode getTail(){
        return this.tail;
    }

    public void printListSize(){
        System.Console.WriteLine(this.size);
    }
}