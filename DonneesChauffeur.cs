public static class DonneesChauffeur
{
	public static string NomPrenom;
	public static string Entreprise;
	public static string TypeDechet;
	public static decimal Poids1;
	public static decimal Poids2;
	public static DateTime DatePassage;

	public static decimal PoidsNet => Poids1 - Poids2;
}
