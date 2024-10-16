import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Set;
import java.util.TreeMap;

public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Hello, World!");

        // HashMap - elements are stored in unknown order (most efficient)
        // TreeMap - elements are stored in key sequenced order
        // LinkedHasMap - elements are stored in entry-sequence 

        // maps can onlu hold objects, use Javas Wrapper Classes to represent primitives 
        // Integer, Double, Float, Boolean, Char

        Map<String,Integer> favNumberMap = new LinkedHashMap<String,Integer>();

        favNumberMap.put("Ethan", 3);
        favNumberMap.put("Evan", 77);
        favNumberMap.put("Josh", 47);
        favNumberMap.put("Ashley", 19);
        favNumberMap.put("Kendall", 16);
        favNumberMap.put("Jay", 3);
        favNumberMap.put("Frank", 42);

        Set<String> names = favNumberMap.keySet();

        for (String currentName : names) {
            System.out.println(currentName + "'s favorite number: " + favNumberMap.get(currentName));
        }
    }
}
