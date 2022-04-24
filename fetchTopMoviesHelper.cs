class FetchTopMoviesHelper{

    public static void Helper(){

        LinkedList myFirstList = new LinkedList();
        LinkedList mySecondList = new LinkedList();
        LinkedList myThirdList = new LinkedList();
        int[] myVals = {1, 2, 5, 7, 8, 9, 11, 41, 51};
        int[] mySecondVals = {3, 4, 7, 10, 12, 14, 15, 21, 23, 42};
        int[] myThirdVals = {-3, 12, 13, 14, 17, 18, 25, 56, 66, 72};
        myFirstList.createLinkedList(myVals);
        mySecondList.createLinkedList(mySecondVals);
        myThirdList.createLinkedList(myThirdVals);
        myFirstList.printListVals();
        mySecondList.printListVals();
        myThirdList.printListVals();

        LinkedList[] lists = {myFirstList, mySecondList, myThirdList};

        LinkedList mergedList = FetchTopMovies.mergeAllLists(lists);

    }
    
}