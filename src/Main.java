import java.util.Arrays;
import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        String in = "(2x+5) (1 -2x)";
        var t = parseEx(in);

        int[] arr1 = t.get(0);
        int[] arr2 = t.get(1);
        var result = MultiplyTool.multy(arr1, arr2);
        Arrays.stream(result).forEachOrdered(System.out::println);
    }

    private static List<int[]> parseEx(String in) {
        in = in.replaceAll(" ", "");
        return Arrays.stream(in.split("\\)"))
                .map(s -> s.replaceAll("[()]", ""))
                .map(s -> {
                    Pattern p1 = Pattern.compile("[-]?[0-9]+(?=x)");
                    Pattern p2 = Pattern.compile("[-]?[0-9]+(?!x)");
                    Matcher m1 = p1.matcher(s);
                    Matcher m2 = p2.matcher(s);
                    if (m1.find() && m2.find())
                        return new int[]{Integer.parseInt(m2.group()),
                                Integer.parseInt(m1.group())};
                    return new int[]{0, 0};
                })
                .collect(Collectors.toList());
    }
}
