class FindStoryIdHelper{

    public static void Helper(){
        int[] firstTestCase = {6, 7, 1, 2, 3, 4, 5};
        int[] secondTestCase = {4000, 4132, 5876, 1, 3, 4, 5, 6, 8, 9, 15, 35, 42, 308};
        int[] thirdTestCase = {58, 79, 82, 83, 84, 1, 15, 35, 36, 37, 38, 39, 44};
        int[] fourthTestCase = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};

        System.Console.WriteLine(FindStoryId.findStoryId(secondTestCase, 4132));
    }

}