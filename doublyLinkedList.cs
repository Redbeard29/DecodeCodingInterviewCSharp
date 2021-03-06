public class DLLNode{

    public int movieID;
    public string title;
    public DLLNode next;
    public DLLNode prev;

    public DLLNode(int movieID, string title){
        this.movieID = movieID;
        this.title = title;
        this.next = null;
        this.prev = null;
    }

    public DLLNode(int movieID, string title, DLLNode next){
        this.movieID = movieID;
        this.title = title;
        this.next = next;
        this.prev = null;
    }

    public DLLNode(int movieID, string title, DLLNode next, DLLNode prev){
        this.movieID = movieID;
        this.title = title;
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

    public void insertAtHead(int movieID, string title){
        DLLNode currentNode = new DLLNode(movieID, title);
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
        string[,] listHolder = new string[this.size, 2];
        DLLNode currentNode = this.head;
        int idx = 0;

        while(currentNode != null){
            string movieIDAsString = currentNode.movieID.ToString();
            listHolder[idx, 0] = movieIDAsString;
            listHolder[idx, 1] = currentNode.title;
            currentNode = currentNode.next;
            idx++;
        }

        for(int x = 0; x < listHolder.GetLength(0); x++){
            System.Console.WriteLine("{0}: {1}", listHolder[x, 0], listHolder[x, 1]);
        }

    }

    public DLLNode getHead(){
        return this.head;
    }

    public DLLNode getTail(){
        return this.tail;
    }

    public int getSize(){
        return this.size;
    }

    public void printListSize(){
        System.Console.WriteLine(this.size);
    }
}