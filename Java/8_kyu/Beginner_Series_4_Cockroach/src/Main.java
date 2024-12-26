public class Main {
    public int cockroachSpeed(double x) {
        return (int)((x * 100000) / 60) / 60;
    }

    public static void main(String[] args) {
        System.out.println(new Main().cockroachSpeed(1.08));    // 30
    }
}