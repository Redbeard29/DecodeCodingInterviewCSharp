using System.Collections.Generic;

class SuggestItemsForSpecialOfferHelper{

    public static void Helper(){
        int[] itemPrices = {100, 75, 150, 200, 50, 65, 40, 30, 15, 25, 60};
        List<int[]> triplets = SuggestItemsForSpecialOffer.suggestThreeProducts(itemPrices);

        foreach(int[] triplet in triplets){
            System.Console.WriteLine("[{0}]", string.Join(", ", triplet));
        }
        
    }

}