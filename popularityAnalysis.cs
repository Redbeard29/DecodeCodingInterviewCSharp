class popularityAnalysis{
    public static bool isIncreasingOrDecreasing(int[] ratings){

        bool increasing = true;
        bool decreasing = true;

        for(int x = 0; x < ratings.Length - 1; x++){
            if(ratings[x] > ratings[x + 1]){
                increasing = false;
            }
            if(ratings[x] < ratings[x + 1]){
                decreasing = false;
            }
        }

        return (increasing || decreasing);
    }
}