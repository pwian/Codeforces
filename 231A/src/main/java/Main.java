import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static Integer getInt(Scanner scanner) {
        return scanner.nextInt();
    }

    public static List<Integer> getIntList(Scanner scanner, Integer count) {
        List<Integer> list = new ArrayList<>();
        for (int i = 0; i < count; i++) {
            var number = scanner.nextInt();
            list.add(number);
        }
        return list;
    }

    public static void main(String[] args) {
        var scanner = new Scanner(System.in);
        int n = getInt(scanner);
        var count = 0;
        for (int i = 0; i < n; i++) {
            List<Integer> list = getIntList(scanner, 3);
            if (list.stream().reduce(0, Integer::sum) >= 2){
                count++;
            }
        }

        System.out.println(count);
    }
}
