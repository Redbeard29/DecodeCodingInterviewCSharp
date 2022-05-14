class SuggestItemsForFreeDeliveryHelper{
    
    public static void Helper(){

        int[] itemPrices = {2, 30, 56, 34, 55, 10, 11, 20, 15, 60, 45, 39, 51};
        int targetPrice = 61;
        int[] itemIndices = SuggestItemsForFreeDelivery.suggestTwoProducts(itemPrices, targetPrice);
        System.Console.WriteLine("[{0}]", string.Join(", ", itemIndices));

    }
}