using System;

public class CompteVip : Compte, Don
{


	public const double tauxAgios = 0.1;


	public override int Agios(int soldeActuelle)
	{
		//verifier si le compte est dans le rouge ou pas
		if (solde >= 0)
		{
			return 0;
		}
		else
		{
			//faire le calcul agios et caster en int
			return (int)(System.Math.Abs(solde) * TauxAgios);

		}


	}



    public void Don()
    {
        throw new NotImplementedException();
    }
}
