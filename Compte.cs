using System;

public abstract  class Compte 
{


	public String nom { get; set; }
	public String prenom { get; set; }
	public int solde { get; set; }
	public int decouvertAutorise { get; set; }
	public int joursADecouvert { get; set; }
	public int joursADecouvertAutorise { get; set; }

	public double TauxAgios;


	public void Crediter(int credit)
	{
		solde = solde + credit;
	}

	public void Debiter(int debit)
	{
		 solde = solde - debit;
	}

	public int SetDecouvers(int soldeDeDepart)
	{
		 return decouvertAutorise;
	}


	public abstract int Agios(int soldeActuelle);

}
