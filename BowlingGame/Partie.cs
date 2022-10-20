namespace BowlingGame;

public class Partie
{
    private readonly List<int> _historique = new ();

    public void Lancer(int nombreQuillesTombées)
    {
        _historique.Add(nombreQuillesTombées);

        if(EstUnStrike()) return;
        if(EstUnSpare()) return;

        if (TermineUneFrame())
        {
            Score = DeuxDerniersLancers.Sum();
        }

        if (EstDansLeScopeDuSpare())
        {
            var bonus = 10 + nombreQuillesTombées;
            Score = bonus + nombreQuillesTombées;
        }

        if (EstDansLeScopeDuStrike())
        {
            var bonus = 10 + nombreQuillesTombées + _historique[_historique.Count - 2];
            Score = bonus + nombreQuillesTombées + _historique[_historique.Count - 2];
        }
    }

    private IEnumerable<int> DeuxDerniersLancers => _historique.AsEnumerable().Reverse().Take(2);
    private bool TermineUneFrame() => _historique.Count % 2 == 0;
    private bool EstUnSpare() => DeuxDerniersLancers.Sum() == 10;
    private bool EstUnStrike() => _historique.Last() == 10;

    private bool EstDansLeScopeDuSpare()
    {
        if(_historique.Count >= 3)
        {
            var v1 = _historique[_historique.Count - 3];
            var v2 = _historique[_historique.Count - 2];
            return (v1 + v2) == 10;
        }else
        {
            return false;
        }
        
    }

    private bool EstDansLeScopeDuStrike()
    {
        if(_historique.Count >= 3)
        {
            var v = _historique[_historique.Count - 3];
            return v == 10;
        }else
        {
            return false;
        }
    }

    public int Score { get; private set; }
}