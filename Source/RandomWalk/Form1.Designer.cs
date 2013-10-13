namespace RandomWalk
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraphControlRandomWalk = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNumberOfBins = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxSaveData = new System.Windows.Forms.CheckBox();
            this.buttonDoEnsemble = new System.Windows.Forms.Button();
            this.textBoxNumberOfWalkers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNumberOfDimensions = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumberOfSteps = new System.Windows.Forms.TextBox();
            this.buttonDoWalk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zedGraphControlEnsemble = new ZedGraph.ZedGraphControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.zedGraphControlHistogram = new ZedGraph.ZedGraphControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControlRandomWalk
            // 
            this.zedGraphControlRandomWalk.Location = new System.Drawing.Point(6, 6);
            this.zedGraphControlRandomWalk.Name = "zedGraphControlRandomWalk";
            this.zedGraphControlRandomWalk.ScrollGrace = 0;
            this.zedGraphControlRandomWalk.ScrollMaxX = 0;
            this.zedGraphControlRandomWalk.ScrollMaxY = 0;
            this.zedGraphControlRandomWalk.ScrollMaxY2 = 0;
            this.zedGraphControlRandomWalk.ScrollMinX = 0;
            this.zedGraphControlRandomWalk.ScrollMinY = 0;
            this.zedGraphControlRandomWalk.ScrollMinY2 = 0;
            this.zedGraphControlRandomWalk.Size = new System.Drawing.Size(721, 559);
            this.zedGraphControlRandomWalk.TabIndex = 0;
            this.zedGraphControlRandomWalk.GraphPane.Title.Text = "Random Walk";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNumberOfBins);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.checkBoxSaveData);
            this.groupBox1.Controls.Add(this.buttonDoEnsemble);
            this.groupBox1.Controls.Add(this.textBoxNumberOfWalkers);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxNumberOfDimensions);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNumberOfSteps);
            this.groupBox1.Controls.Add(this.buttonDoWalk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random Walk Control Panel";
            // 
            // textBoxNumberOfBins
            // 
            this.textBoxNumberOfBins.Location = new System.Drawing.Point(346, 39);
            this.textBoxNumberOfBins.Name = "textBoxNumberOfBins";
            this.textBoxNumberOfBins.Size = new System.Drawing.Size(111, 20);
            this.textBoxNumberOfBins.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Number of Bins";
            // 
            // checkBoxSaveData
            // 
            this.checkBoxSaveData.AutoSize = true;
            this.checkBoxSaveData.Checked = true;
            this.checkBoxSaveData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveData.Location = new System.Drawing.Point(487, 28);
            this.checkBoxSaveData.Name = "checkBoxSaveData";
            this.checkBoxSaveData.Size = new System.Drawing.Size(108, 17);
            this.checkBoxSaveData.TabIndex = 8;
            this.checkBoxSaveData.Text = "Save Data to File";
            this.checkBoxSaveData.UseVisualStyleBackColor = true;
            // 
            // buttonDoEnsemble
            // 
            this.buttonDoEnsemble.Location = new System.Drawing.Point(346, 65);
            this.buttonDoEnsemble.Name = "buttonDoEnsemble";
            this.buttonDoEnsemble.Size = new System.Drawing.Size(111, 23);
            this.buttonDoEnsemble.TabIndex = 7;
            this.buttonDoEnsemble.Text = "Do an Ensemble";
            this.buttonDoEnsemble.UseVisualStyleBackColor = true;
            this.buttonDoEnsemble.Click += new System.EventHandler(this.buttonDoEnsemble_Click);
            // 
            // textBoxNumberOfWalkers
            // 
            this.textBoxNumberOfWalkers.Location = new System.Drawing.Point(346, 13);
            this.textBoxNumberOfWalkers.Name = "textBoxNumberOfWalkers";
            this.textBoxNumberOfWalkers.Size = new System.Drawing.Size(111, 20);
            this.textBoxNumberOfWalkers.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of Walkers";
            // 
            // textBoxNumberOfDimensions
            // 
            this.textBoxNumberOfDimensions.Location = new System.Drawing.Point(125, 39);
            this.textBoxNumberOfDimensions.Name = "textBoxNumberOfDimensions";
            this.textBoxNumberOfDimensions.Size = new System.Drawing.Size(111, 20);
            this.textBoxNumberOfDimensions.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Dimensions";
            // 
            // textBoxNumberOfSteps
            // 
            this.textBoxNumberOfSteps.Location = new System.Drawing.Point(125, 13);
            this.textBoxNumberOfSteps.Name = "textBoxNumberOfSteps";
            this.textBoxNumberOfSteps.Size = new System.Drawing.Size(111, 20);
            this.textBoxNumberOfSteps.TabIndex = 2;
            // 
            // buttonDoWalk
            // 
            this.buttonDoWalk.Location = new System.Drawing.Point(125, 65);
            this.buttonDoWalk.Name = "buttonDoWalk";
            this.buttonDoWalk.Size = new System.Drawing.Size(111, 23);
            this.buttonDoWalk.TabIndex = 1;
            this.buttonDoWalk.Text = "Do a Random Walk";
            this.buttonDoWalk.UseVisualStyleBackColor = true;
            this.buttonDoWalk.Click += new System.EventHandler(this.buttonDoWalk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Steps";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Daniel Bank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(703, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PHY 541";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(686, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Homework 2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 597);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.zedGraphControlRandomWalk);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Random Walk";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.zedGraphControlEnsemble);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(733, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ensemble";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // zedGraphControlEnsemble
            // 
            this.zedGraphControlEnsemble.Location = new System.Drawing.Point(6, 6);
            this.zedGraphControlEnsemble.Name = "zedGraphControlEnsemble";
            this.zedGraphControlEnsemble.ScrollGrace = 0;
            this.zedGraphControlEnsemble.ScrollMaxX = 0;
            this.zedGraphControlEnsemble.ScrollMaxY = 0;
            this.zedGraphControlEnsemble.ScrollMaxY2 = 0;
            this.zedGraphControlEnsemble.ScrollMinX = 0;
            this.zedGraphControlEnsemble.ScrollMinY = 0;
            this.zedGraphControlEnsemble.ScrollMinY2 = 0;
            this.zedGraphControlEnsemble.Size = new System.Drawing.Size(721, 559);
            this.zedGraphControlEnsemble.TabIndex = 1;
            this.zedGraphControlEnsemble.GraphPane.Title.Text = "Ensemble Endpoints";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.zedGraphControlHistogram);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(733, 571);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Histogram";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // zedGraphControlHistogram
            // 
            this.zedGraphControlHistogram.Location = new System.Drawing.Point(6, 6);
            this.zedGraphControlHistogram.Name = "zedGraphControlHistogram";
            this.zedGraphControlHistogram.ScrollGrace = 0;
            this.zedGraphControlHistogram.ScrollMaxX = 0;
            this.zedGraphControlHistogram.ScrollMaxY = 0;
            this.zedGraphControlHistogram.ScrollMaxY2 = 0;
            this.zedGraphControlHistogram.ScrollMinX = 0;
            this.zedGraphControlHistogram.ScrollMinY = 0;
            this.zedGraphControlHistogram.ScrollMinY2 = 0;
            this.zedGraphControlHistogram.Size = new System.Drawing.Size(721, 559);
            this.zedGraphControlHistogram.TabIndex = 1;
            this.zedGraphControlHistogram.GraphPane.Title.Text = "RMS Histogram";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Blake Chobanian";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(690, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Problem 2.5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 727);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Random Walk in D Dimensions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControlRandomWalk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNumberOfDimensions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumberOfSteps;
        private System.Windows.Forms.Button buttonDoWalk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl zedGraphControlEnsemble;
        private System.Windows.Forms.Button buttonDoEnsemble;
        private System.Windows.Forms.TextBox textBoxNumberOfWalkers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private ZedGraph.ZedGraphControl zedGraphControlHistogram;
        private System.Windows.Forms.CheckBox checkBoxSaveData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNumberOfBins;
        private System.Windows.Forms.Label label9;
    }
}

