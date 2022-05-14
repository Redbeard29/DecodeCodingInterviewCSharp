/* 
For the first feature, we want to suggest products customers can buy to make their orders eligible for free delivery. The minimum
order amount to qualify for free shipping varies by customer location. When a customer views their cart and the current total does
not quality for free shipping, we want to show them a pair of products that can be bought together to make the total amount equal
to the amount required to be eligible for free delivery. You can assume that it was a corporate decision to show a pair of products
instead of a single product. Historical data collected by your team shows that customers are more willing to buy multiple products
as it gives the illusion of a better deal. Also, the UX team says that only two items should be displayed given the screen space
for this feature. 

To implement this feature, we will have access to a list of products that the customer is likely to buy. These products will include
the items from their wishlist and other items based on previous purchases. We will also be given the amount, n, that the customer
needs to spend in addition to the current total: n = [free shipping price - current total]. Let's say you are given a list of numbers
containing prices of products that a customer is likely to buy - [2, 30, 56, 34, 55, 10, 11, 20, 15, 60, 45, 39, 51]. In addition,
the amount that needs to be spent to claim the free delivery offer is 61 dollars. Then, we can see that the sum of 10 and 51 is 61.
Therefore, we will suggest the customer buys these products. Our program should return the indices of these products in an array
such as: [5, 12]. You can assume that the list always contains at least one pair of products to suggest. If there is more than one
pair, you can suggest any of them. 

*/

using System.Collections.Generic;

class SuggestItemsForFreeDelivery{

    public static int[] suggestTwoProducts(int[] itemPrices, int targetPrice){

        Dictionary<int, int> currentPrices = new Dictionary<int, int>();

        for(int x = 0; x < itemPrices.Length; x++){
            int price = itemPrices[x];
            int difference = targetPrice - price;

            if(currentPrices.ContainsKey(difference)){
                return new int[]{currentPrices[difference], x};
            }
            else{
                currentPrices[price] = x;
            }
        }

        return new int[0];
    }

}