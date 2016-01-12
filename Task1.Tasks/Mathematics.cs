using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tasks
{
    public class Mathematics
    {

        #region (Level 1) Simple mathematics

        /// <summary>
        /// Returns sum of a and b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Sum(int a, int b)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Rounds number to the max side, for example:
        /// 1.0 -> 1
        /// 1.6 -> 2
        /// 1.1 -> 2
        /// 0.1 -> 1
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int RoundToMax(double number)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns maximum of a and b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Max(int a, int b)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the length of number, example:
        /// 124 -> 3
        /// 12  -> 2
        /// 4   -> 1
        /// 81  -> 2
        /// 0   -> 1
        /// -10 -> 3
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int NumberLength(int number)
        {
            // TODO
            throw new NotImplementedException();
        }


        /// <summary>
        /// Returns sum of all elements of array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int Sum(int[] array)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns sum of all elements of matrix
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int Sum(int[,] matrix)
        {
            // TODO
            throw new NotImplementedException();
        }


        /// <summary>
        /// Returns sum of all BORDER elements of matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public int BorderSum(int[,] matrix)
        {
            //TODO
            throw new NotImplementedException();
        }
        #endregion

        #region (Level 2) Arrays

        /// <summary>
        /// Returns doubled array, example:
        /// [1,2,3,4] -> [2,4,6,8]
        /// [5,0,2,3] -> [10,0,4,6]
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] DoubleArray(int[] array)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns array contains onli unique elements, example:
        /// [1,1,1,1,1] -> [1]
        /// [1,2,3,3,2] -> [1,2,3]
        /// [2,4,5,4,6] -> [2,4,5,6]
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] UniqueArray(int[] array)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns array acording next examples:
        /// 3 -> [3,4,5]
        /// 2 -> [2,3]
        /// 5 -> [5,6,7,8,9]
        /// 1 -> [1]
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public int[] GenerateArray(int size)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generate matrix size n*m according example:
        ///        |1 1 1 1|
        /// 3,4 -> |1 0 0 1|
        ///        |1 1 1 1|
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public int[,] GenerateMatrix(int n, int m)
        {
            // TODO
            throw new NotImplementedException();
        }

        #endregion

        #region (Level 3) Classes

        /// <summary>
        /// Returns polynom in n degree, actualy p^n
        /// </summary>
        /// <param name="p"></param>
        /// <param name="degree"></param>
        /// <returns></returns>
        public Polynom Degree(Polynom p, int n)
        {
            // TODO
            throw new NotImplementedException();
        }



        #endregion

    }


    /// <summary>
    /// Class polynom, it is contain coefficients, that interpreting like
    /// [1,2,-3,4,-5]->1*x^4 + 2*x^3 - 3*x^2 + 4*x^1 - 5
    /// </summary>
    public class Polynom
    {
        public double[] coefficients;

        /// <summary>
        /// Must set cpefficients
        /// </summary>
        public Polynom(/* TODO Something may be here */)
        {
            // TODO
        }

        /// <summary>
        /// Returns sum of two operators
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static Polynom operator +(Polynom a1, Polynom a2)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns differense between a1 and a2
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static Polynom operator -(Polynom a1, Polynom a2)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Multiplying a1 and a2
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static Polynom operator *(Polynom a1, Polynom a2)
        {
            // TODO
            throw new NotImplementedException();
        }

        // TODO Add extra methods if you need
    }

    #region (Level 4) Properties (Getters and Setters)

    /// <summary>
    /// Your misson implement get and set functions, to set name not longer that 8 chars, example:
    /// Name = "vovanella95"  ->  name = "vovanell"
    /// Name = "mariasavkova" ->  name = "marisavk"
    /// </summary>
    public class HateLongNames
    {
        private string name;
        public string Name
        {
            get
            {
                // TODO
                throw new NotImplementedException();
            }
            set
            {
                // TODO
                throw new NotImplementedException();
            }
        }
    }

    #endregion



    #region (Level 5) Interfaces

    public interface IPlayer
    {
        string Name { get; set; }
        string SurName { get; set; }
        string FullName { get; set; }
        void SetNameAndSurname(string name, string surname);
    }

    // TODO Create class Player : IPlayer {}, implement interface and when
    // you get FullName it must be calculated using FirstName and LastName using setters
    public class Player : IPlayer
    {
        public string FullName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name { get; set; }

        public string SurName { get; set; }
       

        public void SetNameAndSurname(string name, string surname)
        {
            throw new NotImplementedException();
        }
    }


    #endregion

}
