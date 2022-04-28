class BrowseRatings{
    public static void getMaxRating(){
        MaxStack stack = new MaxStack();
        stack.push(5);
        stack.push(0);
        stack.push(2);
        stack.push(4);
        stack.push(6);
        stack.push(3);
        stack.push(10);

        System.Console.WriteLine("Current Max Rating: " + stack.getMaxRating());
        stack.pop();
        System.Console.WriteLine("Pressed back button");
        System.Console.WriteLine("Max rating is now: " + stack.getMaxRating());
        
    }
}