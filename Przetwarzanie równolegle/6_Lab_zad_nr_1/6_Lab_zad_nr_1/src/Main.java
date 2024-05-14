public class Main {
    public static void main(String[] args) {

        FabrykaLiczbNaturalnych fabrykaLiczbNaturalnych = new FabrykaLiczbNaturalnych();
        FabrykaLiczbUjemnych fabrykaLiczbUjemnych = new FabrykaLiczbUjemnych();
        int n = 25; //ilosc iteracji

        for(int i = 0; i < 8; i++){

            SumatorPrzeciwnych sumatorPrzeciwnych = new SumatorPrzeciwnych(fabrykaLiczbNaturalnych,fabrykaLiczbUjemnych, n);
            Thread w1 = new Thread(sumatorPrzeciwnych);
            Thread w2 = new Thread(sumatorPrzeciwnych);
            Thread w3 = new Thread(sumatorPrzeciwnych);
            Thread w4 = new Thread(sumatorPrzeciwnych);
            Thread w5 = new Thread(sumatorPrzeciwnych);

            w1.start();
            w2.start();
            w3.start();
            w4.start();
            w5.start();

        }

    }
}