using System;
using System.Collections.Generic;


class SuggestItemsForSpecialOffer{

    public static List<int[]> suggestThreeProducts(int[] itemPrices){

        List<int[]> triplets = new List<int[]>();
        Array.Sort(itemPrices);

        for(int x = 0; x < itemPrices.Length && itemPrices[x] < 200; x++){
            if(x == 0 || itemPrices[x - 1] != itemPrices[x]){
                twoProducts(itemPrices, x, triplets);
            }
        }

        return triplets;
    }

    public static void twoProducts(int[] itemPrices, int x, List<int[]> triplets){
        HashSet<int> visited = new HashSet<int>();
        int y = x + 1;

        while(y < itemPrices.Length){
            int difference = 200 - itemPrices[x] - itemPrices[y];
            if(visited.Contains(difference)){
                triplets.Add(new int[]{itemPrices[x], itemPrices[y], difference});
                while(y + 1 < itemPrices.Length && itemPrices[y] == itemPrices[y + 1]){
                    y++;
                }
            }

            visited.Add(itemPrices[y]);
            y++;
        }
    }
    
}