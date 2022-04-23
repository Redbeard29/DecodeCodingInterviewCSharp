class PopularityAnalysisHelper{
    public static void Helper(){

        int[][] movieRatings = new int[][]{
            new int[]{1, 2, 2, 3},
            new int[]{4, 5, 6, 3, 4},
            new int[]{8, 8, 7, 6, 5, 4, 4, 1}
        };

        foreach(var ratingsGroup in movieRatings){

            if(PopularityAnalysis.isIncreasingOrDecreasing(ratingsGroup)){
                System.Console.WriteLine("This title's score is strictly increasing or decreasing.");
            }

            else{
                System.Console.WriteLine("This title's score is fluctuating.");
            }
            
        }

    }  

}