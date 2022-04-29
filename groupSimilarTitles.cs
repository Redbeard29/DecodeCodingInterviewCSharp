using System.Collections.Generic;
using System.Text;
using System.Linq;

class GroupSimilarTitles{

    public static List<List<string>> groupTitles(string[] titles){
        if(titles.Length == 0){
            return new List<List<string>>();
        }

        Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();

        foreach(string title in titles){
            int[] count = new int[26];
            foreach(char ch in title){
                int idx = ch - 'a';
                count[idx] ++;
            }

            StringBuilder delimitedString = new StringBuilder("");
            foreach(int num in count){
                delimitedString.Append("#");
                delimitedString.Append(num);
            }

            string key = delimitedString.ToString();
            if(!results.ContainsKey(key)){
                results[key] = new List<string>();
            }
            results[key].Add(title);
        }

        return new List<List<string>>(results.Values.ToList());
    }

}