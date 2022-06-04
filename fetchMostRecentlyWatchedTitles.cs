class FetchMostRecentlyWatchedTitles{

    public static void Helper(){

        LRUCache myCache = new LRUCache(5);
        myCache.insertOrMoveToFront(1, "The Lion King");
        myCache.insertOrMoveToFront(2, "Weekend at Bernie's");
        myCache.insertOrMoveToFront(3, "2 Fast, 2 Furious");
        myCache.insertOrMoveToFront(5, "Hustle & Flow");
        myCache.insertOrMoveToFront(15, "Encanto");
        myCache.insertOrMoveToFront(1, "The Lion King");
        // myCache.printCacheItems();
        myCache.insertOrMoveToFront(35, "Frozen II");
        myCache.printCacheItems();
    }

}
