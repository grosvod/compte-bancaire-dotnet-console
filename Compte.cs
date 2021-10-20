using System;

public abstract  class Compte 
{


	public String nom { get; set; }
	public String prenom { get; set; }
	public int solde { get; set; }
	public int joursADecouvert { get; set; }
	public int joursADecouvertAutorise { get; set; }

	public int decouvertAutorise { get; set; }

	public double TauxAgios;



	public int Crediter(int solde, int credit)
	{
		 return solde = solde + credit;
	}

	public int Debiter(int solde, int debit)
	{
		return solde = solde - debit;
	}



	public abstract int Agios(int soldeActuelle);

}
