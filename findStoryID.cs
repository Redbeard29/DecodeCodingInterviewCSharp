class FindStoryId{

    public static int findStoryId(int[] storyIds, int id){

        int left = 0;
        int right = storyIds.Length - 1;
        
        while(left <= right){
            int middle = (left + right) / 2;

            if(storyIds[middle] == id){
                return middle;
            }

            else if(storyIds[middle] > id){
                right = middle - 1;
            }

            else if(storyIds[middle] < id){
                left = middle + 1;
            }
        }

        return -1;
    }

}