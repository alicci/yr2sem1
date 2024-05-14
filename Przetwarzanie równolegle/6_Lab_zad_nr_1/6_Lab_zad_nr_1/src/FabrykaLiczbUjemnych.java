public class FabrykaLiczbUjemnych extends FabrykaLiczb{

    public FabrykaLiczbUjemnych(){
        super(-1);
    }

    public Integer produkujLiczbe(){
        int liczba = getLiczbaAktualna();
        setLiczbaAktualna(liczba - 1);
        return liczba;
    }
}
