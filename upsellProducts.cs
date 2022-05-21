using System;
using System.Collections.Generic;

class ProductSet{

    Dictionary<int, int> productDict;
    List<int> productList;
    Random random = new Random();

    public ProductSet(){
        productDict = new Dictionary<int, int>();
        productList = new List<int>();
    }

    public void insertProduct(int product){
        if(!productDict.ContainsKey(product)){
            productDict[product] = productList.Count;
            productList.Add(product);
        }
        else{
            System.Console.WriteLine("Product key already exists in product set.");
        }
    }

    public void removeProduct(int productKey){
        if(productDict.ContainsKey(productKey)){
            int lastItem = productList[productList.Count - 1];
            int prodIdx = productDict[productKey];
            productList[prodIdx] = lastItem;
            productDict[lastItem] = prodIdx;
            productList.Remove(productList[productList.Count - 1]);
            productDict.Remove(productKey);
        }
        else{
            System.Console.WriteLine("Product key does not exist in product set.");
        }
    }

    public int getRandomProduct(){
        return productList[random.Next(productList.Count)];
    }

}