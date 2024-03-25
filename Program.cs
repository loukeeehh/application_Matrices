namespace _5T24_LoukaConstant_appliMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[,] Matrice1;
            int[,] Matrice2;
            int[,] Matrice3;
            int[,] MatriceMulti;
            bool addition;
            int lignes;
            int colonnes;
            int nUser;
            string chaineResultat;
            string repeatProg;
            appliMatrices mesMatrices = new appliMatrices();

            do
            {
                //première matrice
                Console.WriteLine("Combien de lignes voulez-vous à votre matrices ?");
                lignes = int.Parse(Console.ReadLine());

                Console.WriteLine("Combien de colonnes voulez-vous à votre matrice ?");
                colonnes = int.Parse(Console.ReadLine());

                //traitement première matrice 
                mesMatrices.genereMatrice(lignes, colonnes, out Matrice1);

                //affichage première matrice
                Console.WriteLine("Voici votre première matrice :");
                mesMatrices.concateneMatrice(Matrice1, out chaineResultat);
                Console.WriteLine(chaineResultat);

                //deuxième matrice
                Console.WriteLine("Combien de lignes voulez-vous à votre deuxième matrice ?");
                lignes = int.Parse(Console.ReadLine());

                Console.WriteLine("Combien de colonnes voulez-vous à votre deuxième matrice ?");
                colonnes = int.Parse(Console.ReadLine());

                //traitement deuxième matrice
                mesMatrices.genereMatrice(lignes, colonnes, out Matrice2);

                //affichage deuxième matrice
                Console.WriteLine("Voici votre deuxieme matrice :");
                mesMatrices.concateneMatrice(Matrice2, out chaineResultat);
                Console.WriteLine(chaineResultat);


                //demande d'opération à faire 
                Console.WriteLine("Quelle opération voulez-vous réaliser à vos deux matrices ? Taper 1 pour l'addition et taper 2 pour la multiplication");
                nUser = int.Parse(Console.ReadLine());

                //opération addition
                if (nUser == 1)
                {
                    Console.WriteLine("Voici l'opération de l'addition :\n");
                    mesMatrices.concateneMatrice(Matrice1, out chaineResultat);
                    Console.WriteLine($"{chaineResultat}\n");
                    Console.WriteLine("+\n");
                    mesMatrices.concateneMatrice(Matrice2, out chaineResultat);
                    Console.WriteLine($"{chaineResultat}\n");
                    Console.WriteLine("=\n");
                    mesMatrices.additionMatrice(Matrice1, Matrice2, out Matrice3, out addition);
                    if (addition == true)
                    {
                        mesMatrices.concateneMatrice(Matrice3, out chaineResultat);
                        Console.WriteLine(chaineResultat);
                    }

                    else
                    {
                        Console.WriteLine("Vous ne pouvez pas faire cette opération !");
                    }

                }

                //opération multiplication
                else if (nUser == 2)
                {
                    Console.WriteLine("Voici l'opération de la multiplication :\n");
                    mesMatrices.concateneMatrice(Matrice1, out chaineResultat);
                    Console.WriteLine($"{chaineResultat}\n");
                    Console.WriteLine("*\n");
                    mesMatrices.concateneMatrice(Matrice2, out chaineResultat);
                    Console.WriteLine($"{chaineResultat}\n");
                    Console.WriteLine("=\n");
                    mesMatrices.multiplicationMatrice(Matrice1, Matrice2, out MatriceMulti, out addition);
                    if (addition == true)
                    {
                        mesMatrices.concateneMatrice(MatriceMulti, out chaineResultat);
                        Console.WriteLine(chaineResultat);
                    }

                    else
                    {
                        Console.WriteLine("Vous ne pouvez pas faire cette opération !");
                    }
                }

                //demande de reprise                
                Console.WriteLine("Voulez-vous recommencer ? 'o' = oui, 'n' = non.");
                repeatProg = Console.ReadLine();

            } while (repeatProg == "o");
        }
    }
}

