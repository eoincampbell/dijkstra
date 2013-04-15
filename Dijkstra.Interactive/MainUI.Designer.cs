namespace Dijkstra.Interactive
{
    partial class MainUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VisualiseGraph = new System.Windows.Forms.Button();
            this.DirectRouteGroup = new System.Windows.Forms.GroupBox();
            this.TestDirectRoute = new System.Windows.Forms.Button();
            this.TestDirectRouteCustomText = new System.Windows.Forms.TextBox();
            this.TestDirectRouteCustom = new System.Windows.Forms.RadioButton();
            this.Test5 = new System.Windows.Forms.RadioButton();
            this.Test4 = new System.Windows.Forms.RadioButton();
            this.Test3 = new System.Windows.Forms.RadioButton();
            this.Test2 = new System.Windows.Forms.RadioButton();
            this.Test1 = new System.Windows.Forms.RadioButton();
            this.ShortestDistanceGroup = new System.Windows.Forms.GroupBox();
            this.TestShortestDistanceButton = new System.Windows.Forms.Button();
            this.TestShortestDistanceCustomEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TestShortestDistanceCustomStart = new System.Windows.Forms.TextBox();
            this.TestShortestDistanceCustom = new System.Windows.Forms.RadioButton();
            this.Test9 = new System.Windows.Forms.RadioButton();
            this.Test8 = new System.Windows.Forms.RadioButton();
            this.MaxNodeCountGroup = new System.Windows.Forms.GroupBox();
            this.TestCustomMaxNodeCountStops = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TestMaxNodeCountButton = new System.Windows.Forms.Button();
            this.TestCustomMaxNodeCountEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TestCustomMaxNodeCountStart = new System.Windows.Forms.TextBox();
            this.TestCustomMaxNodeCount = new System.Windows.Forms.RadioButton();
            this.Test6 = new System.Windows.Forms.RadioButton();
            this.ExactNodeCountGroup = new System.Windows.Forms.GroupBox();
            this.TestCustomExactNodeCountStops = new System.Windows.Forms.TextBox();
            this.Test7 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TestCustomExactNodeCount = new System.Windows.Forms.RadioButton();
            this.TestExactNodeCountButton = new System.Windows.Forms.Button();
            this.TestCustomExactNodeCountStart = new System.Windows.Forms.TextBox();
            this.TestCustomExactNodeCountEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxDistanceGroup = new System.Windows.Forms.GroupBox();
            this.TestCustomMaxDistanceDistance = new System.Windows.Forms.TextBox();
            this.Test10 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.TestCustomMaxDistance = new System.Windows.Forms.RadioButton();
            this.TestMaxDistanceButton = new System.Windows.Forms.Button();
            this.TestCustomMaxDistanceStart = new System.Windows.Forms.TextBox();
            this.TestCustomMaxDistanceEnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DirectRouteGroup.SuspendLayout();
            this.ShortestDistanceGroup.SuspendLayout();
            this.MaxNodeCountGroup.SuspendLayout();
            this.ExactNodeCountGroup.SuspendLayout();
            this.MaxDistanceGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(15, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "AB5, BC4, CD8, DC8, DE6, AD5, CE2, EB3, AE7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Graph Input";
            // 
            // VisualiseGraph
            // 
            this.VisualiseGraph.Location = new System.Drawing.Point(520, 10);
            this.VisualiseGraph.Name = "VisualiseGraph";
            this.VisualiseGraph.Size = new System.Drawing.Size(95, 23);
            this.VisualiseGraph.TabIndex = 3;
            this.VisualiseGraph.Text = "&Visualise Graph";
            this.VisualiseGraph.UseVisualStyleBackColor = true;
            this.VisualiseGraph.Click += new System.EventHandler(this.VisualiseGraphClick);
            // 
            // DirectRouteGroup
            // 
            this.DirectRouteGroup.Controls.Add(this.TestDirectRoute);
            this.DirectRouteGroup.Controls.Add(this.TestDirectRouteCustomText);
            this.DirectRouteGroup.Controls.Add(this.TestDirectRouteCustom);
            this.DirectRouteGroup.Controls.Add(this.Test5);
            this.DirectRouteGroup.Controls.Add(this.Test4);
            this.DirectRouteGroup.Controls.Add(this.Test3);
            this.DirectRouteGroup.Controls.Add(this.Test2);
            this.DirectRouteGroup.Controls.Add(this.Test1);
            this.DirectRouteGroup.Location = new System.Drawing.Point(622, 10);
            this.DirectRouteGroup.Name = "DirectRouteGroup";
            this.DirectRouteGroup.Size = new System.Drawing.Size(260, 130);
            this.DirectRouteGroup.TabIndex = 4;
            this.DirectRouteGroup.TabStop = false;
            this.DirectRouteGroup.Text = "Direct Route";
            // 
            // TestDirectRoute
            // 
            this.TestDirectRoute.Location = new System.Drawing.Point(7, 99);
            this.TestDirectRoute.Name = "TestDirectRoute";
            this.TestDirectRoute.Size = new System.Drawing.Size(245, 23);
            this.TestDirectRoute.TabIndex = 7;
            this.TestDirectRoute.Text = "TestDirectRoute";
            this.TestDirectRoute.UseVisualStyleBackColor = true;
            this.TestDirectRoute.Click += new System.EventHandler(this.TestDirectRouteClick);
            // 
            // TestDirectRouteCustomText
            // 
            this.TestDirectRouteCustomText.Location = new System.Drawing.Point(152, 73);
            this.TestDirectRouteCustomText.Name = "TestDirectRouteCustomText";
            this.TestDirectRouteCustomText.Size = new System.Drawing.Size(100, 20);
            this.TestDirectRouteCustomText.TabIndex = 6;
            this.TestDirectRouteCustomText.Text = "A-B-C";
            // 
            // TestDirectRouteCustom
            // 
            this.TestDirectRouteCustom.AutoSize = true;
            this.TestDirectRouteCustom.Location = new System.Drawing.Point(86, 74);
            this.TestDirectRouteCustom.Name = "TestDirectRouteCustom";
            this.TestDirectRouteCustom.Size = new System.Drawing.Size(60, 17);
            this.TestDirectRouteCustom.TabIndex = 5;
            this.TestDirectRouteCustom.TabStop = true;
            this.TestDirectRouteCustom.Text = "Custom";
            this.TestDirectRouteCustom.UseVisualStyleBackColor = true;
            // 
            // Test5
            // 
            this.Test5.AutoSize = true;
            this.Test5.Location = new System.Drawing.Point(86, 51);
            this.Test5.Name = "Test5";
            this.Test5.Size = new System.Drawing.Size(53, 17);
            this.Test5.TabIndex = 4;
            this.Test5.TabStop = true;
            this.Test5.Text = "A-E-D";
            this.Test5.UseVisualStyleBackColor = true;
            // 
            // Test4
            // 
            this.Test4.AutoSize = true;
            this.Test4.Location = new System.Drawing.Point(86, 28);
            this.Test4.Name = "Test4";
            this.Test4.Size = new System.Drawing.Size(73, 17);
            this.Test4.TabIndex = 3;
            this.Test4.TabStop = true;
            this.Test4.Text = "A-E-B-C-D";
            this.Test4.UseVisualStyleBackColor = true;
            // 
            // Test3
            // 
            this.Test3.AutoSize = true;
            this.Test3.Location = new System.Drawing.Point(7, 74);
            this.Test3.Name = "Test3";
            this.Test3.Size = new System.Drawing.Size(53, 17);
            this.Test3.TabIndex = 2;
            this.Test3.TabStop = true;
            this.Test3.Text = "A-D-C";
            this.Test3.UseVisualStyleBackColor = true;
            // 
            // Test2
            // 
            this.Test2.AutoSize = true;
            this.Test2.Location = new System.Drawing.Point(7, 51);
            this.Test2.Name = "Test2";
            this.Test2.Size = new System.Drawing.Size(43, 17);
            this.Test2.TabIndex = 1;
            this.Test2.TabStop = true;
            this.Test2.Text = "A-D";
            this.Test2.UseVisualStyleBackColor = true;
            // 
            // Test1
            // 
            this.Test1.AutoSize = true;
            this.Test1.Checked = true;
            this.Test1.Location = new System.Drawing.Point(7, 28);
            this.Test1.Name = "Test1";
            this.Test1.Size = new System.Drawing.Size(52, 17);
            this.Test1.TabIndex = 0;
            this.Test1.TabStop = true;
            this.Test1.Text = "A-B-C";
            this.Test1.UseVisualStyleBackColor = true;
            // 
            // ShortestDistanceGroup
            // 
            this.ShortestDistanceGroup.Controls.Add(this.TestShortestDistanceButton);
            this.ShortestDistanceGroup.Controls.Add(this.TestShortestDistanceCustomEnd);
            this.ShortestDistanceGroup.Controls.Add(this.label2);
            this.ShortestDistanceGroup.Controls.Add(this.TestShortestDistanceCustomStart);
            this.ShortestDistanceGroup.Controls.Add(this.TestShortestDistanceCustom);
            this.ShortestDistanceGroup.Controls.Add(this.Test9);
            this.ShortestDistanceGroup.Controls.Add(this.Test8);
            this.ShortestDistanceGroup.Location = new System.Drawing.Point(622, 147);
            this.ShortestDistanceGroup.Name = "ShortestDistanceGroup";
            this.ShortestDistanceGroup.Size = new System.Drawing.Size(260, 120);
            this.ShortestDistanceGroup.TabIndex = 5;
            this.ShortestDistanceGroup.TabStop = false;
            this.ShortestDistanceGroup.Text = "ShortestDistance";
            // 
            // TestShortestDistanceButton
            // 
            this.TestShortestDistanceButton.Location = new System.Drawing.Point(6, 88);
            this.TestShortestDistanceButton.Name = "TestShortestDistanceButton";
            this.TestShortestDistanceButton.Size = new System.Drawing.Size(245, 23);
            this.TestShortestDistanceButton.TabIndex = 8;
            this.TestShortestDistanceButton.Text = "Test Shortest Distance";
            this.TestShortestDistanceButton.UseVisualStyleBackColor = true;
            this.TestShortestDistanceButton.Click += new System.EventHandler(this.TestShortestDistanceButtonClick);
            // 
            // TestShortestDistanceCustomEnd
            // 
            this.TestShortestDistanceCustomEnd.Location = new System.Drawing.Point(152, 64);
            this.TestShortestDistanceCustomEnd.Name = "TestShortestDistanceCustomEnd";
            this.TestShortestDistanceCustomEnd.Size = new System.Drawing.Size(21, 20);
            this.TestShortestDistanceCustomEnd.TabIndex = 10;
            this.TestShortestDistanceCustomEnd.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "To";
            // 
            // TestShortestDistanceCustomStart
            // 
            this.TestShortestDistanceCustomStart.Location = new System.Drawing.Point(98, 64);
            this.TestShortestDistanceCustomStart.Name = "TestShortestDistanceCustomStart";
            this.TestShortestDistanceCustomStart.Size = new System.Drawing.Size(21, 20);
            this.TestShortestDistanceCustomStart.TabIndex = 8;
            this.TestShortestDistanceCustomStart.Text = "A";
            // 
            // TestShortestDistanceCustom
            // 
            this.TestShortestDistanceCustom.AutoSize = true;
            this.TestShortestDistanceCustom.Location = new System.Drawing.Point(6, 65);
            this.TestShortestDistanceCustom.Name = "TestShortestDistanceCustom";
            this.TestShortestDistanceCustom.Size = new System.Drawing.Size(86, 17);
            this.TestShortestDistanceCustom.TabIndex = 7;
            this.TestShortestDistanceCustom.Text = "Custom From";
            this.TestShortestDistanceCustom.UseVisualStyleBackColor = true;
            // 
            // Test9
            // 
            this.Test9.AutoSize = true;
            this.Test9.Location = new System.Drawing.Point(7, 42);
            this.Test9.Name = "Test9";
            this.Test9.Size = new System.Drawing.Size(63, 17);
            this.Test9.TabIndex = 3;
            this.Test9.Text = "B ==> B";
            this.Test9.UseVisualStyleBackColor = true;
            // 
            // Test8
            // 
            this.Test8.AutoSize = true;
            this.Test8.Checked = true;
            this.Test8.Location = new System.Drawing.Point(7, 19);
            this.Test8.Name = "Test8";
            this.Test8.Size = new System.Drawing.Size(63, 17);
            this.Test8.TabIndex = 2;
            this.Test8.TabStop = true;
            this.Test8.Text = "A ==> C";
            this.Test8.UseVisualStyleBackColor = true;
            // 
            // MaxNodeCountGroup
            // 
            this.MaxNodeCountGroup.Controls.Add(this.TestCustomMaxNodeCountStops);
            this.MaxNodeCountGroup.Controls.Add(this.label4);
            this.MaxNodeCountGroup.Controls.Add(this.TestMaxNodeCountButton);
            this.MaxNodeCountGroup.Controls.Add(this.TestCustomMaxNodeCountEnd);
            this.MaxNodeCountGroup.Controls.Add(this.label3);
            this.MaxNodeCountGroup.Controls.Add(this.TestCustomMaxNodeCountStart);
            this.MaxNodeCountGroup.Controls.Add(this.TestCustomMaxNodeCount);
            this.MaxNodeCountGroup.Controls.Add(this.Test6);
            this.MaxNodeCountGroup.Location = new System.Drawing.Point(622, 287);
            this.MaxNodeCountGroup.Name = "MaxNodeCountGroup";
            this.MaxNodeCountGroup.Size = new System.Drawing.Size(261, 104);
            this.MaxNodeCountGroup.TabIndex = 7;
            this.MaxNodeCountGroup.TabStop = false;
            this.MaxNodeCountGroup.Text = "Max Node Count";
            // 
            // TestCustomMaxNodeCountStops
            // 
            this.TestCustomMaxNodeCountStops.Location = new System.Drawing.Point(223, 41);
            this.TestCustomMaxNodeCountStops.Name = "TestCustomMaxNodeCountStops";
            this.TestCustomMaxNodeCountStops.Size = new System.Drawing.Size(28, 20);
            this.TestCustomMaxNodeCountStops.TabIndex = 17;
            this.TestCustomMaxNodeCountStops.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stops";
            // 
            // TestMaxNodeCountButton
            // 
            this.TestMaxNodeCountButton.Location = new System.Drawing.Point(6, 75);
            this.TestMaxNodeCountButton.Name = "TestMaxNodeCountButton";
            this.TestMaxNodeCountButton.Size = new System.Drawing.Size(245, 23);
            this.TestMaxNodeCountButton.TabIndex = 11;
            this.TestMaxNodeCountButton.Text = "Test Max Node Count";
            this.TestMaxNodeCountButton.UseVisualStyleBackColor = true;
            this.TestMaxNodeCountButton.Click += new System.EventHandler(this.TestMaxNodeCountButtonClick);
            // 
            // TestCustomMaxNodeCountEnd
            // 
            this.TestCustomMaxNodeCountEnd.Location = new System.Drawing.Point(152, 41);
            this.TestCustomMaxNodeCountEnd.Name = "TestCustomMaxNodeCountEnd";
            this.TestCustomMaxNodeCountEnd.Size = new System.Drawing.Size(21, 20);
            this.TestCustomMaxNodeCountEnd.TabIndex = 15;
            this.TestCustomMaxNodeCountEnd.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "To";
            // 
            // TestCustomMaxNodeCountStart
            // 
            this.TestCustomMaxNodeCountStart.Location = new System.Drawing.Point(98, 41);
            this.TestCustomMaxNodeCountStart.Name = "TestCustomMaxNodeCountStart";
            this.TestCustomMaxNodeCountStart.Size = new System.Drawing.Size(21, 20);
            this.TestCustomMaxNodeCountStart.TabIndex = 13;
            this.TestCustomMaxNodeCountStart.Text = "C";
            // 
            // TestCustomMaxNodeCount
            // 
            this.TestCustomMaxNodeCount.AutoSize = true;
            this.TestCustomMaxNodeCount.Location = new System.Drawing.Point(6, 42);
            this.TestCustomMaxNodeCount.Name = "TestCustomMaxNodeCount";
            this.TestCustomMaxNodeCount.Size = new System.Drawing.Size(86, 17);
            this.TestCustomMaxNodeCount.TabIndex = 12;
            this.TestCustomMaxNodeCount.Text = "Custom From";
            this.TestCustomMaxNodeCount.UseVisualStyleBackColor = true;
            // 
            // Test6
            // 
            this.Test6.AutoSize = true;
            this.Test6.Checked = true;
            this.Test6.Location = new System.Drawing.Point(7, 19);
            this.Test6.Name = "Test6";
            this.Test6.Size = new System.Drawing.Size(134, 17);
            this.Test6.TabIndex = 11;
            this.Test6.TabStop = true;
            this.Test6.Text = "C ==> C (Max Stops: 3)";
            this.Test6.UseVisualStyleBackColor = true;
            // 
            // ExactNodeCountGroup
            // 
            this.ExactNodeCountGroup.Controls.Add(this.TestCustomExactNodeCountStops);
            this.ExactNodeCountGroup.Controls.Add(this.Test7);
            this.ExactNodeCountGroup.Controls.Add(this.label5);
            this.ExactNodeCountGroup.Controls.Add(this.TestCustomExactNodeCount);
            this.ExactNodeCountGroup.Controls.Add(this.TestExactNodeCountButton);
            this.ExactNodeCountGroup.Controls.Add(this.TestCustomExactNodeCountStart);
            this.ExactNodeCountGroup.Controls.Add(this.TestCustomExactNodeCountEnd);
            this.ExactNodeCountGroup.Controls.Add(this.label6);
            this.ExactNodeCountGroup.Location = new System.Drawing.Point(622, 406);
            this.ExactNodeCountGroup.Name = "ExactNodeCountGroup";
            this.ExactNodeCountGroup.Size = new System.Drawing.Size(261, 105);
            this.ExactNodeCountGroup.TabIndex = 8;
            this.ExactNodeCountGroup.TabStop = false;
            this.ExactNodeCountGroup.Text = "Exact Node Count";
            // 
            // TestCustomExactNodeCountStops
            // 
            this.TestCustomExactNodeCountStops.Location = new System.Drawing.Point(224, 41);
            this.TestCustomExactNodeCountStops.Name = "TestCustomExactNodeCountStops";
            this.TestCustomExactNodeCountStops.Size = new System.Drawing.Size(28, 20);
            this.TestCustomExactNodeCountStops.TabIndex = 25;
            this.TestCustomExactNodeCountStops.Text = "4";
            // 
            // Test7
            // 
            this.Test7.AutoSize = true;
            this.Test7.Checked = true;
            this.Test7.Location = new System.Drawing.Point(8, 19);
            this.Test7.Name = "Test7";
            this.Test7.Size = new System.Drawing.Size(141, 17);
            this.Test7.TabIndex = 19;
            this.Test7.TabStop = true;
            this.Test7.Text = "A ==> C (Exact Stops: 4)";
            this.Test7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Stops";
            // 
            // TestCustomExactNodeCount
            // 
            this.TestCustomExactNodeCount.AutoSize = true;
            this.TestCustomExactNodeCount.Location = new System.Drawing.Point(7, 42);
            this.TestCustomExactNodeCount.Name = "TestCustomExactNodeCount";
            this.TestCustomExactNodeCount.Size = new System.Drawing.Size(86, 17);
            this.TestCustomExactNodeCount.TabIndex = 20;
            this.TestCustomExactNodeCount.Text = "Custom From";
            this.TestCustomExactNodeCount.UseVisualStyleBackColor = true;
            // 
            // TestExactNodeCountButton
            // 
            this.TestExactNodeCountButton.Location = new System.Drawing.Point(7, 67);
            this.TestExactNodeCountButton.Name = "TestExactNodeCountButton";
            this.TestExactNodeCountButton.Size = new System.Drawing.Size(245, 23);
            this.TestExactNodeCountButton.TabIndex = 18;
            this.TestExactNodeCountButton.Text = "Test Exact Node Count";
            this.TestExactNodeCountButton.UseVisualStyleBackColor = true;
            this.TestExactNodeCountButton.Click += new System.EventHandler(this.TestExactNodeCountButtonClick);
            // 
            // TestCustomExactNodeCountStart
            // 
            this.TestCustomExactNodeCountStart.Location = new System.Drawing.Point(99, 41);
            this.TestCustomExactNodeCountStart.Name = "TestCustomExactNodeCountStart";
            this.TestCustomExactNodeCountStart.Size = new System.Drawing.Size(21, 20);
            this.TestCustomExactNodeCountStart.TabIndex = 21;
            this.TestCustomExactNodeCountStart.Text = "A";
            // 
            // TestCustomExactNodeCountEnd
            // 
            this.TestCustomExactNodeCountEnd.Location = new System.Drawing.Point(153, 41);
            this.TestCustomExactNodeCountEnd.Name = "TestCustomExactNodeCountEnd";
            this.TestCustomExactNodeCountEnd.Size = new System.Drawing.Size(21, 20);
            this.TestCustomExactNodeCountEnd.TabIndex = 23;
            this.TestCustomExactNodeCountEnd.Text = "C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "To";
            // 
            // MaxDistanceGroup
            // 
            this.MaxDistanceGroup.Controls.Add(this.TestCustomMaxDistanceDistance);
            this.MaxDistanceGroup.Controls.Add(this.Test10);
            this.MaxDistanceGroup.Controls.Add(this.label7);
            this.MaxDistanceGroup.Controls.Add(this.TestCustomMaxDistance);
            this.MaxDistanceGroup.Controls.Add(this.TestMaxDistanceButton);
            this.MaxDistanceGroup.Controls.Add(this.TestCustomMaxDistanceStart);
            this.MaxDistanceGroup.Controls.Add(this.TestCustomMaxDistanceEnd);
            this.MaxDistanceGroup.Controls.Add(this.label8);
            this.MaxDistanceGroup.Location = new System.Drawing.Point(622, 527);
            this.MaxDistanceGroup.Name = "MaxDistanceGroup";
            this.MaxDistanceGroup.Size = new System.Drawing.Size(261, 110);
            this.MaxDistanceGroup.TabIndex = 9;
            this.MaxDistanceGroup.TabStop = false;
            this.MaxDistanceGroup.Text = "Max Distance";
            // 
            // TestCustomMaxDistanceDistance
            // 
            this.TestCustomMaxDistanceDistance.Location = new System.Drawing.Point(229, 38);
            this.TestCustomMaxDistanceDistance.Name = "TestCustomMaxDistanceDistance";
            this.TestCustomMaxDistanceDistance.Size = new System.Drawing.Size(22, 20);
            this.TestCustomMaxDistanceDistance.TabIndex = 33;
            this.TestCustomMaxDistanceDistance.Text = "30";
            // 
            // Test10
            // 
            this.Test10.AutoSize = true;
            this.Test10.Checked = true;
            this.Test10.Location = new System.Drawing.Point(9, 16);
            this.Test10.Name = "Test10";
            this.Test10.Size = new System.Drawing.Size(155, 17);
            this.Test10.TabIndex = 27;
            this.Test10.TabStop = true;
            this.Test10.Text = "C ==> C (Max Distance: 30)";
            this.Test10.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Distance";
            // 
            // TestCustomMaxDistance
            // 
            this.TestCustomMaxDistance.AutoSize = true;
            this.TestCustomMaxDistance.Location = new System.Drawing.Point(8, 39);
            this.TestCustomMaxDistance.Name = "TestCustomMaxDistance";
            this.TestCustomMaxDistance.Size = new System.Drawing.Size(86, 17);
            this.TestCustomMaxDistance.TabIndex = 28;
            this.TestCustomMaxDistance.Text = "Custom From";
            this.TestCustomMaxDistance.UseVisualStyleBackColor = true;
            // 
            // TestMaxDistanceButton
            // 
            this.TestMaxDistanceButton.Location = new System.Drawing.Point(8, 62);
            this.TestMaxDistanceButton.Name = "TestMaxDistanceButton";
            this.TestMaxDistanceButton.Size = new System.Drawing.Size(245, 23);
            this.TestMaxDistanceButton.TabIndex = 26;
            this.TestMaxDistanceButton.Text = "Test Max Distance";
            this.TestMaxDistanceButton.UseVisualStyleBackColor = true;
            this.TestMaxDistanceButton.Click += new System.EventHandler(this.TestMaxDistanceButtonClick);
            // 
            // TestCustomMaxDistanceStart
            // 
            this.TestCustomMaxDistanceStart.Location = new System.Drawing.Point(100, 38);
            this.TestCustomMaxDistanceStart.Name = "TestCustomMaxDistanceStart";
            this.TestCustomMaxDistanceStart.Size = new System.Drawing.Size(21, 20);
            this.TestCustomMaxDistanceStart.TabIndex = 29;
            this.TestCustomMaxDistanceStart.Text = "C";
            // 
            // TestCustomMaxDistanceEnd
            // 
            this.TestCustomMaxDistanceEnd.Location = new System.Drawing.Point(154, 38);
            this.TestCustomMaxDistanceEnd.Name = "TestCustomMaxDistanceEnd";
            this.TestCustomMaxDistanceEnd.Size = new System.Drawing.Size(21, 20);
            this.TestCustomMaxDistanceEnd.TabIndex = 31;
            this.TestCustomMaxDistanceEnd.Text = "C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "To";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 649);
            this.Controls.Add(this.MaxDistanceGroup);
            this.Controls.Add(this.ExactNodeCountGroup);
            this.Controls.Add(this.MaxNodeCountGroup);
            this.Controls.Add(this.ShortestDistanceGroup);
            this.Controls.Add(this.DirectRouteGroup);
            this.Controls.Add(this.VisualiseGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.DirectRouteGroup.ResumeLayout(false);
            this.DirectRouteGroup.PerformLayout();
            this.ShortestDistanceGroup.ResumeLayout(false);
            this.ShortestDistanceGroup.PerformLayout();
            this.MaxNodeCountGroup.ResumeLayout(false);
            this.MaxNodeCountGroup.PerformLayout();
            this.ExactNodeCountGroup.ResumeLayout(false);
            this.ExactNodeCountGroup.PerformLayout();
            this.MaxDistanceGroup.ResumeLayout(false);
            this.MaxDistanceGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VisualiseGraph;
        private System.Windows.Forms.GroupBox DirectRouteGroup;
        private System.Windows.Forms.RadioButton Test1;
        private System.Windows.Forms.RadioButton Test4;
        private System.Windows.Forms.RadioButton Test3;
        private System.Windows.Forms.RadioButton Test2;
        private System.Windows.Forms.TextBox TestDirectRouteCustomText;
        private System.Windows.Forms.RadioButton TestDirectRouteCustom;
        private System.Windows.Forms.RadioButton Test5;
        private System.Windows.Forms.Button TestDirectRoute;
        private System.Windows.Forms.GroupBox ShortestDistanceGroup;
        private System.Windows.Forms.Button TestShortestDistanceButton;
        private System.Windows.Forms.TextBox TestShortestDistanceCustomEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TestShortestDistanceCustomStart;
        private System.Windows.Forms.RadioButton TestShortestDistanceCustom;
        private System.Windows.Forms.RadioButton Test9;
        private System.Windows.Forms.RadioButton Test8;
        private System.Windows.Forms.GroupBox MaxNodeCountGroup;
        private System.Windows.Forms.GroupBox ExactNodeCountGroup;
        private System.Windows.Forms.GroupBox MaxDistanceGroup;
        private System.Windows.Forms.TextBox TestCustomMaxNodeCountStops;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TestMaxNodeCountButton;
        private System.Windows.Forms.TextBox TestCustomMaxNodeCountEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TestCustomMaxNodeCountStart;
        private System.Windows.Forms.RadioButton TestCustomMaxNodeCount;
        private System.Windows.Forms.RadioButton Test6;
        private System.Windows.Forms.TextBox TestCustomExactNodeCountStops;
        private System.Windows.Forms.RadioButton Test7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton TestCustomExactNodeCount;
        private System.Windows.Forms.Button TestExactNodeCountButton;
        private System.Windows.Forms.TextBox TestCustomExactNodeCountStart;
        private System.Windows.Forms.TextBox TestCustomExactNodeCountEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TestCustomMaxDistanceDistance;
        private System.Windows.Forms.RadioButton Test10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton TestCustomMaxDistance;
        private System.Windows.Forms.Button TestMaxDistanceButton;
        private System.Windows.Forms.TextBox TestCustomMaxDistanceStart;
        private System.Windows.Forms.TextBox TestCustomMaxDistanceEnd;
        private System.Windows.Forms.Label label8;
    }
}

