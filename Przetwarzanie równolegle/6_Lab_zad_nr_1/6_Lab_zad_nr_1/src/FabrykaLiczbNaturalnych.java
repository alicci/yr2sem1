public class FabrykaLiczbNaturalnych extends FabrykaLiczb{


    public FabrykaLiczbNaturalnych(){
        super(1);
    }

    public Integer produkujLiczbe(){
        int liczba = getLiczbaAktualna();
        setLiczbaAktualna(liczba + 1);
        return liczba;
    }


}
