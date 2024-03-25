using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5T24_LoukaConstant_appliMatrices
{
    public struct appliMatrices
    {
        public void genereMatrice(int lignes, int colonnes, out int[,] Matrice)

        {
            Matrice = new int[lignes, colonnes];
            Random alea = new Random();

            for (lignes = 0; lignes <= Matrice.GetLength(0) - 1; lignes++)
            {
                for (colonnes = 0; colonnes <= Matrice.GetLength(1) - 1; colonnes++)
                {
                    Matrice[lignes, colonnes] = alea.Next(0, 10);
                }
            }

        }

        public void concateneMatrice(int[,] Matrice, out string concatene)
        {
            concatene = "";

            for (int i = 0; i <= Matrice.GetLength(0) - 1; i++)
            {
                string lignes = "";

                for (int j = 0; j <= Matrice.GetLength(1) - 1; j++)
                {
                    lignes = lignes + Matrice[i, j];

                    if (j != Matrice.GetLength(1) - 1)
                    {
                        lignes = lignes + ",";
                    }
                }
                concatene = concatene + "\n" + lignes;
            }
        }
        public void additionMatrice(int[,] Matrice1, int[,] Matrice2, out int[,] Matrice3, out bool addition)
        {
            addition = true;
            int lignes;
            int colonnes;
            Matrice3 = new int[Matrice1.GetLength(0), Matrice1.GetLength(1)];

            if (Matrice1.GetLength(0) == Matrice2.GetLength(0) && Matrice1.GetLength(1) == Matrice2.GetLength(1))
            {

                for (lignes = 0; lignes <= Matrice1.GetLength(0) - 1; lignes++)
                {
                    for (colonnes = 0; colonnes <= Matrice2.GetLength(0) - 1; colonnes++)
                    {
                        Matrice3[lignes, colonnes] = Matrice1[lignes, colonnes] + Matrice2[lignes, colonnes];
                    }
                }

            }

            else
            {
                addition = false;

            }

        }

        public void multiplicationMatrice(int[,] Matrice1, int[,] Matrice2, out int[,] MatriceMulti, out bool addition)
        {
            if (Matrice1.GetLength(1) == Matrice2.GetLength(0))
            {
                addition = true;
                int lignes;
                int colonnes;
                int i;
                MatriceMulti = new int[Matrice1.GetLength(0), Matrice2.GetLength(1)];

                for (lignes = 0; lignes <= Matrice1.GetLength(0) - 1; lignes++)
                {
                    for (colonnes = 0; colonnes <= Matrice2.GetLength(1) - 1; colonnes++)
                    {
                        MatriceMulti[lignes, colonnes] = 0;

                        for (i = 0; i <= Matrice1.GetLength(1) - 1; i++)
                        {
                            MatriceMulti[lignes, colonnes] += Matrice1[lignes, i] * Matrice2[i, colonnes];
                        }

                    }

                }
            }

            else
            {
                addition = false;
                MatriceMulti = null;
            }


        }
    }
}