Tehtävänä:

Tee luokka BusinessIdSpecification, joka toteuttaa seuraavan rajapinnan:

public interface ISpecification<in TEntity>
{
    IEnumerable<string> ReasonsForDissatisfaction { get; }
    bool IsSatisfiedBy(TEntity entity);
}
Luokan tehtävänä on tarkistaa merkkijonona annetun y-tunnuksen oikeellisuus, ja kertoa, miksi epäkelpo y-tunnus ei täytä vaatimuksia.

Konsoliin voi syöttää syötteen niin ohjelma tarkistaa onko annettu tieto sopiva Y-tunnukseksi.
