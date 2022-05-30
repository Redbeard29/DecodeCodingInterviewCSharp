class UpsellProductsHelper{

    public static void Helper(){
        ProductSet products = new ProductSet();
        products.insertProduct(1212);
        products.insertProduct(190);
        products.insertProduct(655);
        products.insertProduct(327);
        System.Console.WriteLine(products.getRandomProduct());
        products.removeProduct(190);
        products.removeProduct(1212);
        System.Console.WriteLine(products.getRandomProduct());
    }

}