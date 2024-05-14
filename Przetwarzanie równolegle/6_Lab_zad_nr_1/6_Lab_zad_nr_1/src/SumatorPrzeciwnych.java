import java.util.Random;

public class SumatorPrzeciwnych implements Runnable {

    private final FabrykaLiczbNaturalnych fabrykaLiczbNaturalnych;
    private final FabrykaLiczbUjemnych fabrykaLiczbUjemnych;
    private final int n;
    private final Random r = new Random();

    public SumatorPrzeciwnych(FabrykaLiczbNaturalnych fabrykaLiczbNaturalnych, FabrykaLiczbUjemnych fabrykaLiczbUjemnych, int n) {
        this.fabrykaLiczbNaturalnych = fabrykaLiczbNaturalnych;
        this.fabrykaLiczbUjemnych = fabrykaLiczbUjemnych;
        this.n = n;
    }

    private void opoznij(){

        try{
            Thread.sleep(r.nextInt(500));
        } catch (InterruptedException e){
            e.printStackTrace();
        }

    }

    @Override
    public void run() {

        for(int i = 0; i < n; i++){
            int liczbaNaturalna = fabrykaLiczbNaturalnych.produkujLiczbe();
            //opoznij();
            int liczbaUjemna = fabrykaLiczbUjemnych.produkujLiczbe();

            //opoznij();

            int suma = liczbaNaturalna + liczbaUjemna;

            System.out.println("Suma nr " + i + " = " + liczbaNaturalna + " + " + liczbaUjemna + "  =  " + suma);
        }
    }
}
