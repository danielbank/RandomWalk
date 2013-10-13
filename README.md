RandomWalk
==========

A C# Windows application demonstrating random walks and emergent properties.  This project is a solution to Exercise 2.5 from Dr. James Sethna's *Statistical Mechanics: Entropy, Order Parameters, and Complexity* (http://pages.physics.cornell.edu/~sethna/StatMech/EntropyOrderParametersComplexity.pdf).

Installation Instructions:
===========

1. Download the compressed folder from the website by clicking the link 'Download Random Walk Application'

2. Unzip the compressed folder and open it.

3. There should be two .dll files in the folder (ZedGraph.dll and ZedGraph.Web.dll) and two folders (RandomWalks and Ensembles).  Do not remove or change the names of these files and folders as doing so will cause problems with the application.

4. Run RandomWalk.exe.

Application Instructions:
===========

1) To do a random walk in D dimensions, enter a number of steps and a number of dimensions and click the 'Do a Random Walk' button.  If the dimensionality is 1-D or 2-D, the random walk should appear in the graph on the 'Random Walk' tab.  If the 'Save Data to File' checkbox is clicked, the points of the N x d matrix will be written to an text file (it can be opened in Excel for easier perusal).

2) To do an ensemble of endpoints for W walkers, enter a number steps, number of dimensions, and number of bins (meaningful only for 1-D histograms) and click the 'Do an Ensemble' button.  If the dimensionality is 1-D or 2-D, the ensemble of endpoints should appear in the graph on the 'Ensemble' tab.  If the 'Save Data to File' checkbox is clicked, the points of the W x d matrix will be written to an text file (it can be opened in Excel for easier perusal).

3) To view the histogram of 1-D ensembles of endpoints, follow the instructions in (2) using a dimensionality of 1.  After clicking the 'Do an Ensemble' button, a graph of the predicted and actual histogram should appear in the graph on the 'Histogram' tab.

Graph Instructions:
===========

1) To zoom, click-drag the mouse across the graph to create a rectangular region of interest and release.  Another way to zoom is to use the scroll-wheel on the mouse.

2) To unzoom, right-click on the graph.  A pop-up list of options should appear.  Choose 'Undo All Zoom/Pan' or 'Set Scale to Default'.

3) To move the graph view without changing the zoom, hold the CTRL key and click-drag the mouse across the graph.

4) To view graph points, right-click on the graph.  A pop-up list of options should appear.  Choose 'Show Point Values'.

5) To save a copy of the graph, right-click on the graph.  A pop-uplist of options should appear.  Choose 'Save Image As...', browse to a directory, a file name, and click 'Save'.

Credits
===========

Daniel Bank (daniel.p.bank@gmail.com)
Blake Chobanian (blake.chobanian@gmail.com)
October 10th 2013
MIT License
https://github.com/danielbank/RandomWalk/blob/master/LICENSE