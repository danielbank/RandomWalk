using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomWalk
{
    class RandomWalker
    {
        private int mRandomSeed;
        private int mNumberOfSteps;
        private int mNumberOfDimensions;

        /*************************************************
        * Default Constructor for the RandomWalker class *
        *************************************************/

        public RandomWalker()
        {
            mRandomSeed = DateTime.Now.Millisecond + DateTime.Now.Second;
            mNumberOfSteps = 10;
            mNumberOfDimensions = 2;
        }

        /*****************************************
        * Constructor for the RandomWalker class *
        *****************************************/

        public RandomWalker(int numberOfSteps, int numberOfDimensions)
        {
            mRandomSeed = DateTime.Now.Millisecond + DateTime.Now.Second;
            mNumberOfSteps = numberOfSteps;
            mNumberOfDimensions = numberOfDimensions;
        }

        /**********************************************************************************
        * doRandomWalk() Method  (2 overrides)                                            *
        * Inputs:                                                                         *
        *     none                                                                        *
        * Outputs                                                                         *
        *     none                                                                        *
        * Returns:                                                                        *
        *     double[][]                                                                  *
        * Description:                                                                    *
        *     Using the current values of N number of steps and d number of dimensions,   *
        * this method will generate an array of size N x d which contains the steps of    *
        * the random walk.                                                                *
        **********************************************************************************/

        public double[,] doRandomWalk()
        {
            // Create a random number generator
            Random randomNumberGenerator = new Random(mRandomSeed);
            mRandomSeed += 5;

            // Create a matrix for storing the steps
            double[,] steps = new double[mNumberOfSteps,mNumberOfDimensions];

            for (int N = 0; N < mNumberOfSteps; N++)
            {
                for (int d = 0; d < mNumberOfDimensions; d++)
                {
                    if (N == 0)
                    {
                        // For the first step, start from the origin
                        steps[N, d] = randomNumberGenerator.NextDouble() - 0.5;                
                    }
                    else
                    {
                        // For other steps, start from the last position
                        double lastPosition = steps[N - 1, d];
                        steps[N, d] = lastPosition + randomNumberGenerator.NextDouble() - 0.5;                
                    }
                }
            }
            return steps;
        }

        /**********************************************************************************
        * doRandomWalk() Method  (2 overrides)                                            *
        * Inputs:                                                                         *
        *     int numberOfSteps                                                           *
        *     int numberOfDimensions                                                      *
        *                                                                                 *
        * Outputs                                                                         *
        *     none                                                                        *
        * Returns:                                                                        *
        *     double[][]                                                                  *
        * Description:                                                                    *
        *     Sets the current values for N number of steps and d number of dimensions    *
        * to the provided inputs and generates an array of size N x d which contains      *
        * the steps of the random walk.                                                   *
        **********************************************************************************/

        public double[,] doRandomWalk(int numberOfSteps, int numberOfDimensions)
        {
            mNumberOfSteps = numberOfSteps;
            mNumberOfDimensions = numberOfDimensions;
            double[,] steps = doRandomWalk();
            return steps;
        }

        /***************************************
        * Properties of the RandomWalker class *
        ***************************************/

        public int NumberOfSteps
        {
            get { return mNumberOfSteps; }
            set { mNumberOfSteps = value; }
        }

        public int NumberOfDimensions
        {
            get { return mNumberOfDimensions; }
            set { mNumberOfDimensions = value; }
        }

        public int RandomSeed
        {
            get { return mRandomSeed; }
            set { mRandomSeed = value; }
        }
    }
}
