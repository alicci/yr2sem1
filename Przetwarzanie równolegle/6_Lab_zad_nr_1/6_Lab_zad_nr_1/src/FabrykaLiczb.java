public abstract class FabrykaLiczb {

    private Integer liczbaPoczatkowa;
    private Integer liczbaAktualna;

    public abstract Integer produkujLiczbe();

    public FabrykaLiczb(Integer liczbaPoczatkowa) {
        this.liczbaPoczatkowa = liczbaPoczatkowa;
        this.liczbaAktualna = liczbaPoczatkowa;
    }

    public FabrykaLiczb() {
        this.liczbaPoczatkowa = 0;
        this.liczbaAktualna = 0;
    }

    public Integer getLiczbaPoczatkowa() {
        return liczbaPoczatkowa;
    }

    public Integer getLiczbaAktualna() {
        return liczbaAktualna;
    }

    protected void setLiczbaAktualna(Integer liczbaAktualna) {
        this.liczbaAktualna = liczbaAktualna;
    }
}