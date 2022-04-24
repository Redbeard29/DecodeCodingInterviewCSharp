class FetchTopMovies{

    public static LinkedList mergeTwoLists(LinkedList list1, LinkedList list2){

        Node dummy = new Node(-1);

        Node p1 = list1.head;
        Node p2 = list2.head;
        Node prev = dummy;

        while(p1 != null && p2 != null){

            if(p1.data >= p2.data){
                prev.next = p1;
                p1 = p1.next;
            }

            else{
                prev.next = p2;
                p2 = p2.next;
            }

            prev = prev.next;

        }

        if(p1 != null){
            prev.next = p1;
        }
        else{
            prev.next = p2;
        }

        return list1;
    }

    public static LinkedList mergeAllLists(LinkedList[] lists){
        if(lists.Length > 0){
            LinkedList result = lists[0];
            for(int x = 1; x < lists.Length; x++){
                result = mergeTwoLists(result, lists[x]);
            }
            return result;
        }
        return new LinkedList();
    }

}