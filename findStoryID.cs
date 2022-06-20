class FindStoryId{

    public static int findStoryId(int[] storyIds, int val){

        int left = 0;
        int right = storyIds.Length - 1;
        
        while(left <= right){
            int middle = left + (right - left) / 2;

            if(storyIds[middle] == val){
                return middle;
            }

            else if(storyIds[left] <= storyIds[middle]){
                if(storyIds[middle] > val && storyIds[left] <= val){
                    right = middle - 1;
                }
                else{
                    left = middle + 1;
                }
            }

            else{
                if(storyIds[middle] < val && storyIds[right] >= val){
                    left = middle + 1;
                }
                else{
                    right = middle - 1;
                }
            }

        }

        return -1;
    }

}