using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace RandomWalk
{
    public partial class Form1 : Form
    {
        // Global variables
        RandomWalker walker;
        const string randomWalkFolder = ".\\RandomWalks\\";
        const string ensembleFolder = ".\\Ensembles\\";
        const string histogramFolder = ".\\Histograms\\";

        public Form1()
        {
            // Initialize a random walker for doing random walks
            walker = new RandomWalker();

            // Initialize the Graphical User Interface
            InitializeComponent();
        }

        /**********************************************************************************
        * buttonDoWalk_Click() Method                                                     *
        * Inputs:                                                                         *
        *     object sender                                                               *
        *     EventArgs e                                                                 *
        *                                                                                 *
        * Outputs                                                                         *
        *     none                                                                        *
        * Returns:                                                                        *
        *     void                                                                        *
        * Description:                                                                    *
        *     When the 'Do a Random Walk' button is clicked, set the number of steps and  *
        * number of dimensions for the walker object and then perform a random walk.      *
        * Display the results to the graph if the dimensionality is 1 or 2. Finally,      *
        * save the data to file if directed to.                                           *
        **********************************************************************************/

        private void buttonDoWalk_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the number of steps and number of dimensions to user inputs
                double[,] output = walker.doRandomWalk();
                walker.RandomSeed = DateTime.Now.Month + DateTime.Now.Second + DateTime.Now.Year;
                walker.NumberOfSteps = Convert.ToInt32(textBoxNumberOfSteps.Text);
                walker.NumberOfDimensions = Convert.ToInt32(textBoxNumberOfDimensions.Text);
                
                // Run the random walk
                double[,] steps = walker.doRandomWalk();

                // Graph 1D and 2D walks
                if (walker.NumberOfDimensions == 1 || walker.NumberOfDimensions == 2)
                {
                    GraphPane graphPane = zedGraphControlRandomWalk.GraphPane;
                    PointPairList points = new PointPairList();
                    PointPairList lastPoint = new PointPairList();

                    // Clear the graph
                    graphPane.CurveList.Clear();

                    // Create the new graph points
                    for (int N = 0; N < walker.NumberOfSteps; N++)
                    {
                        if (walker.NumberOfDimensions == 1)
                        {
                            if (N == walker.NumberOfSteps - 1)
                            {
                                lastPoint.Add(N, steps[N, 0]);
                                points.Add(N, steps[N, 0]);
                            }
                            else
                            {
                                points.Add(N, steps[N, 0]);
                            }
                        }
                        if (walker.NumberOfDimensions == 2)
                        {
                            if (N == walker.NumberOfSteps - 1)
                            {
                                lastPoint.Add(steps[N, 0], steps[N, 1]);
                                points.Add(steps[N, 0], steps[N, 1]);
                            }
                            else
                            {
                                points.Add(steps[N, 0], steps[N, 1]);
                            }
                        }
                    }
                    LineItem newWalk = graphPane.AddCurve("Random Walk", points, Color.Red, SymbolType.None);
                    LineItem endPoint = graphPane.AddCurve("Random Walk Endpoint", lastPoint, Color.Blue, SymbolType.Circle);
                    newWalk.Line.Width = 3F;

                    // Keep the XY aspect ratio = 1 if specified
                    graphPane.AxisChange();
                    if (walker.NumberOfDimensions == 2)
                    {
                        graphPane.XAxis.Scale.Min = -Math.Pow(walker.NumberOfSteps, 0.5);
                        graphPane.XAxis.Scale.Max = Math.Pow(walker.NumberOfSteps, 0.5);
                        graphPane.YAxis.Scale.Min = -Math.Pow(walker.NumberOfSteps, 0.5);
                        graphPane.YAxis.Scale.Max = Math.Pow(walker.NumberOfSteps, 0.5);
                    }

                    // Display the new graph
                    zedGraphControlRandomWalk.Invalidate();
                }

                // Store random walk points to file if specified
                if (checkBoxSaveData.Checked)
                {
                    string fileName = DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString() + "RandomWalk.txt";
                    string filePath = randomWalkFolder + fileName;
                    WriteToTextFile(filePath, steps);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("An error occured trying to generate this random walk.");
            }
        }

        /**********************************************************************************
        * buttonDoEnsemble_Click() Method                                                 *
        * Inputs:                                                                         *
        *     object sender                                                               *
        *     EventArgs e                                                                 *
        *                                                                                 *
        * Outputs                                                                         *
        *     none                                                                        *
        * Returns:                                                                        *
        *     void                                                                        *
        * Description:                                                                    *
        *     When the 'Do an Ensemble' button is clicked, set the number of steps and    *
        * number of dimensions for the walker object and then perform a user specified    *
        * number of random walk. Display the results to the graph if the dimensionality   *
        * is 1 or 2 dimensions. If the dimensionality is 1, compute the predicted and     *
        * actual histograms for the ensemble. Finally, save the data to file.             *
        **********************************************************************************/

        private void buttonDoEnsemble_Click(object sender, EventArgs e)
        {
            int numberOfWalkers = 0, numberOfBins = 50;
            double[,] endPoints;
            try
            {
                // Set the number of walkers, number of steps, and number of dimensions to user inputs
                walker.RandomSeed = DateTime.Now.Month + DateTime.Now.Second + DateTime.Now.Year;
                walker.NumberOfSteps = Convert.ToInt32(textBoxNumberOfSteps.Text);
                walker.NumberOfDimensions = Convert.ToInt32(textBoxNumberOfDimensions.Text);
                numberOfWalkers = Convert.ToInt32(textBoxNumberOfWalkers.Text);
                numberOfBins = Convert.ToInt32(textBoxNumberOfBins.Text);

                // Create a W x d matrix to store the endpoints for W random walks.
                endPoints = new double[numberOfWalkers,walker.NumberOfDimensions];

                for (int W = 0; W < numberOfWalkers; W++)
                {
                    // Run a random walk
                    double[,] steps = walker.doRandomWalk();

                    // Store the endpoint for the Wth walker
                    for (int d = 0; d < walker.NumberOfDimensions; d++)
                    {
                        endPoints[W, d] = steps[walker.NumberOfSteps - 1, d];
                    }
                }

                // Graph 1D and 2D ensembles
                if (walker.NumberOfDimensions == 1 || walker.NumberOfDimensions == 2)
                {
                    GraphPane graphPane = zedGraphControlEnsemble.GraphPane;
                    PointPairList points = new PointPairList();

                    // Clear the graph
                    graphPane.CurveList.Clear();

                    // Create the new graph points
                    for (int W = 0; W < numberOfWalkers; W++)
                    {
                        if (walker.NumberOfDimensions == 1)
                        {
                            points.Add(endPoints[W, 0], 0);
                        }
                        if (walker.NumberOfDimensions == 2)
                        {
                            points.Add(endPoints[W, 0], endPoints[W,1]);
                        }
                    }
                    LineItem newWalk = graphPane.AddCurve("Endpoints", points, Color.Red, SymbolType.Circle);
                    newWalk.Line.IsVisible = false;

                    // Display the new graph
                    graphPane.AxisChange();
                    zedGraphControlEnsemble.Invalidate();
                }

                // Store endpoints to file if specified
                if (checkBoxSaveData.Checked)
                {
                    string fileName = DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + "Ensemble.txt";
                    string filePath = ensembleFolder + fileName;
                    WriteToTextFile(filePath, endPoints);
                }

                // For 1-D random walks, create the RMS histogram also
                if (walker.NumberOfDimensions == 1)
                {
                    // Calculate the sigma and K for N number of steps
                    double test = walker.NumberOfSteps;
                    test /= 24;
                    double sigma = Math.Pow(test, 0.5);
                    double k = 1 / ((Math.Pow((2 * Math.PI), 0.5)) * sigma);

                    // Calculate the predicted RMS step size for N -> infinity
                    PointPairList predicted = new PointPairList();
                    for (double i = -3 * sigma; i < 3 * sigma; i += (6 * sigma / numberOfBins))
                    {
                        double x = i;
                        double exponent = Math.Pow(x / sigma, 2);
                        double rms = k * Math.Exp(-exponent/2);
                        predicted.Add(x, rms);
                    }

                    // Fractionalize the ensemble endpoints into B bins for the actual histogram
                    PointPairList actual = new PointPairList();
                    for (double i = -3 * sigma; i < 3 * sigma; i += (6 * sigma / numberOfBins))
                    {
                        // Count the number in the current bin
                        int numberInThisBin = 0;
                        for (int W = 0; W < numberOfWalkers; W++)
                        {
                            if (endPoints[W, 0] > i - (3 * sigma / numberOfBins) && endPoints[W, 0] <= i + (3 * sigma / numberOfBins))
                            {
                                numberInThisBin++;
                            }
                        }
                        double amplitude = (double)numberInThisBin / numberOfWalkers;
                        amplitude /= (6 * sigma / numberOfBins);
                        actual.Add(i, amplitude);
                    }

                    // Graph the predicted and actual RMS histograms
                    GraphPane histogramGraphPane = zedGraphControlHistogram.GraphPane;

                    // Clear the graph
                    histogramGraphPane.CurveList.Clear();

                    // Create the new graph points for the predicted RMS step size
                    LineItem predictedRMS = histogramGraphPane.AddCurve("Predicted RMS", predicted, Color.Blue, SymbolType.None);
                    predictedRMS.Line.IsSmooth = true;
                    LineItem actualRMS = histogramGraphPane.AddCurve("Actual RMS", actual, Color.Red, SymbolType.Circle);
                   
                    // Display the new graph
                    histogramGraphPane.AxisChange();
                    zedGraphControlHistogram.Invalidate();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("An error occured trying to generate this ensemble.");
            }
        }

        /**********************************************************************************
        * WriteToTextFile() Method                                                        *
        * Inputs:                                                                         *
        *     string filePath                                                             *
        *     double[,] steps                                                             *
        *                                                                                 *
        * Outputs                                                                         *
        *     none                                                                        *
        * Returns:                                                                        *
        *     void                                                                        *
        * Description:                                                                    *
        *     Writes the array of steps to a text file at the specified file path.        *                                    *
        **********************************************************************************/

        public void WriteToTextFile(string filePath, double[,] data)
        {
            try
            {
                // Get the size of the data matrix
                int m = data.GetUpperBound(0) + 1;
                int n = data.GetUpperBound(1) + 1;

                // Create a StreamWriter for writing the file
                StreamWriter writer = new StreamWriter(filePath, false);

                // Write the header
                writer.Write("Step #:\t");
                for (int i = 0; i < n; i++)
                {
                    int dimensionNum = i + 1;
                    writer.Write("d" + dimensionNum + ":\t");
                }
                writer.WriteLine();

                // Write the data
                for (int i = 0; i < m; i++)
                {
                    int stepNum = i + 1;
                    writer.Write(stepNum + "\t");
                    for (int j = 0; j < n; j++)
                    {
                        writer.Write(data[i, j] + "\t");
                    }
                    writer.WriteLine();
                }
                writer.WriteLine();

                // Close the file
                writer.Flush();   //flush the buffer text immediately into the text file
                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured trying to save data to file.");
            }
        }
    }
}
