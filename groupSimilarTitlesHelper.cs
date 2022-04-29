using System.Collections.Generic;

class GroupSimilarTitlesHelper{
    public static void Helper(){

        string[] titles = {"duel", "dule", "speed", "spede", "deul", "cars"};
        List<List<string>> groupedTitles = GroupSimilarTitles.groupTitles(titles);
        string query = "spede";

        foreach(List<string> group in groupedTitles){
            if(group.Contains(query)){
                System.Console.WriteLine("[{0}]", string.Join(", ", group));
            }
        }
        
    }
}