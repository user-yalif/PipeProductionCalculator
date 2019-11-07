namespace PipesCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StellGradeGroup = new System.Windows.Forms.GroupBox();
            this.CarbonRadioButton = new System.Windows.Forms.RadioButton();
            this.BearingsRadioButton = new System.Windows.Forms.RadioButton();
            this.OrderWeightGroup = new System.Windows.Forms.GroupBox();
            this.OrderWeightTextBox = new System.Windows.Forms.TextBox();
            this.MetersOnOrderGroup = new System.Windows.Forms.GroupBox();
            this.LengthOnOrderTextBox = new System.Windows.Forms.TextBox();
            this.OrderLengthWarningMessage = new System.Windows.Forms.Label();
            this.BlankDimensionsGroup = new System.Windows.Forms.GroupBox();
            this.BlankPipeWorningMessage = new System.Windows.Forms.Label();
            this.BlankMeterWeightGroup = new System.Windows.Forms.GroupBox();
            this.BlankMeterWeightTextBox = new System.Windows.Forms.TextBox();
            this.BlankSideTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BlankDiameterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StretchingCoefficientGroup = new System.Windows.Forms.GroupBox();
            this.StretchingCoefficientWarningMessage = new System.Windows.Forms.Label();
            this.StretchingCoefficientTextBox = new System.Windows.Forms.TextBox();
            this.BlankLengthGroup = new System.Windows.Forms.GroupBox();
            this.BlankLengthTextBox = new System.Windows.Forms.TextBox();
            this.PipeLenghFromBlankGroup = new System.Windows.Forms.GroupBox();
            this.PipeLenghFromBlankTextBox = new System.Windows.Forms.TextBox();
            this.PipeLengthGroup = new System.Windows.Forms.GroupBox();
            this.PipeLengthTextBox = new System.Windows.Forms.TextBox();
            this.BlankLengthOutOfPipeGroup = new System.Windows.Forms.GroupBox();
            this.BlankLengthOutOfPipeTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PipeDiameterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PipeSideTextBox = new System.Windows.Forms.TextBox();
            this.PipeMeterWeightGroup = new System.Windows.Forms.GroupBox();
            this.PipeMeterWeightTextBox = new System.Windows.Forms.TextBox();
            this.PipeDimensionsGroup = new System.Windows.Forms.GroupBox();
            this.PipeWorningMessage = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.HowToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCalculatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StellGradeGroup.SuspendLayout();
            this.OrderWeightGroup.SuspendLayout();
            this.MetersOnOrderGroup.SuspendLayout();
            this.BlankDimensionsGroup.SuspendLayout();
            this.BlankMeterWeightGroup.SuspendLayout();
            this.StretchingCoefficientGroup.SuspendLayout();
            this.BlankLengthGroup.SuspendLayout();
            this.PipeLenghFromBlankGroup.SuspendLayout();
            this.PipeLengthGroup.SuspendLayout();
            this.BlankLengthOutOfPipeGroup.SuspendLayout();
            this.PipeMeterWeightGroup.SuspendLayout();
            this.PipeDimensionsGroup.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StellGradeGroup
            // 
            this.StellGradeGroup.Controls.Add(this.CarbonRadioButton);
            this.StellGradeGroup.Controls.Add(this.BearingsRadioButton);
            resources.ApplyResources(this.StellGradeGroup, "StellGradeGroup");
            this.StellGradeGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StellGradeGroup.Name = "StellGradeGroup";
            this.StellGradeGroup.TabStop = false;
            // 
            // CarbonRadioButton
            // 
            resources.ApplyResources(this.CarbonRadioButton, "CarbonRadioButton");
            this.CarbonRadioButton.ForeColor = System.Drawing.Color.Black;
            this.CarbonRadioButton.Name = "CarbonRadioButton";
            this.CarbonRadioButton.TabStop = true;
            this.CarbonRadioButton.UseVisualStyleBackColor = true;
            this.CarbonRadioButton.CheckedChanged += new System.EventHandler(this.CarbonRadioButton_CheckedChanged);
            // 
            // BearingsRadioButton
            // 
            resources.ApplyResources(this.BearingsRadioButton, "BearingsRadioButton");
            this.BearingsRadioButton.Checked = true;
            this.BearingsRadioButton.ForeColor = System.Drawing.Color.Black;
            this.BearingsRadioButton.Name = "BearingsRadioButton";
            this.BearingsRadioButton.TabStop = true;
            this.BearingsRadioButton.UseVisualStyleBackColor = true;
            this.BearingsRadioButton.CheckedChanged += new System.EventHandler(this.BearingsRadioButton_CheckedChanged);
            // 
            // OrderWeightGroup
            // 
            this.OrderWeightGroup.Controls.Add(this.OrderWeightTextBox);
            resources.ApplyResources(this.OrderWeightGroup, "OrderWeightGroup");
            this.OrderWeightGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OrderWeightGroup.Name = "OrderWeightGroup";
            this.OrderWeightGroup.TabStop = false;
            this.OrderWeightGroup.Leave += new System.EventHandler(this.OrderWeightGroup_Leave);
            // 
            // OrderWeightTextBox
            // 
            resources.ApplyResources(this.OrderWeightTextBox, "OrderWeightTextBox");
            this.OrderWeightTextBox.Name = "OrderWeightTextBox";
            this.OrderWeightTextBox.Enter += new System.EventHandler(this.OrderWeightTextBox_Enter);
            this.OrderWeightTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderWeightTextBox_KeyDown);
            this.OrderWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrderWeightTextBox_KeyPress);
            this.OrderWeightTextBox.Leave += new System.EventHandler(this.OrderWeightTextBox_Leave);
            // 
            // MetersOnOrderGroup
            // 
            this.MetersOnOrderGroup.Controls.Add(this.LengthOnOrderTextBox);
            this.MetersOnOrderGroup.Controls.Add(this.OrderLengthWarningMessage);
            resources.ApplyResources(this.MetersOnOrderGroup, "MetersOnOrderGroup");
            this.MetersOnOrderGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MetersOnOrderGroup.Name = "MetersOnOrderGroup";
            this.MetersOnOrderGroup.TabStop = false;
            // 
            // LengthOnOrderTextBox
            // 
            this.LengthOnOrderTextBox.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.LengthOnOrderTextBox, "LengthOnOrderTextBox");
            this.LengthOnOrderTextBox.Name = "LengthOnOrderTextBox";
            this.LengthOnOrderTextBox.ReadOnly = true;
            this.LengthOnOrderTextBox.TabStop = false;
            // 
            // OrderLengthWarningMessage
            // 
            resources.ApplyResources(this.OrderLengthWarningMessage, "OrderLengthWarningMessage");
            this.OrderLengthWarningMessage.ForeColor = System.Drawing.Color.Red;
            this.OrderLengthWarningMessage.Name = "OrderLengthWarningMessage";
            // 
            // BlankDimensionsGroup
            // 
            this.BlankDimensionsGroup.Controls.Add(this.BlankPipeWorningMessage);
            this.BlankDimensionsGroup.Controls.Add(this.BlankMeterWeightGroup);
            this.BlankDimensionsGroup.Controls.Add(this.BlankSideTextBox);
            this.BlankDimensionsGroup.Controls.Add(this.label2);
            this.BlankDimensionsGroup.Controls.Add(this.BlankDiameterTextBox);
            this.BlankDimensionsGroup.Controls.Add(this.label1);
            resources.ApplyResources(this.BlankDimensionsGroup, "BlankDimensionsGroup");
            this.BlankDimensionsGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BlankDimensionsGroup.Name = "BlankDimensionsGroup";
            this.BlankDimensionsGroup.TabStop = false;
            this.BlankDimensionsGroup.Leave += new System.EventHandler(this.BlankDimensionsGroup_Leave);
            // 
            // BlankPipeWorningMessage
            // 
            resources.ApplyResources(this.BlankPipeWorningMessage, "BlankPipeWorningMessage");
            this.BlankPipeWorningMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BlankPipeWorningMessage.ForeColor = System.Drawing.Color.Red;
            this.BlankPipeWorningMessage.Name = "BlankPipeWorningMessage";
            // 
            // BlankMeterWeightGroup
            // 
            this.BlankMeterWeightGroup.Controls.Add(this.BlankMeterWeightTextBox);
            resources.ApplyResources(this.BlankMeterWeightGroup, "BlankMeterWeightGroup");
            this.BlankMeterWeightGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BlankMeterWeightGroup.Name = "BlankMeterWeightGroup";
            this.BlankMeterWeightGroup.TabStop = false;
            // 
            // BlankMeterWeightTextBox
            // 
            this.BlankMeterWeightTextBox.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.BlankMeterWeightTextBox, "BlankMeterWeightTextBox");
            this.BlankMeterWeightTextBox.Name = "BlankMeterWeightTextBox";
            this.BlankMeterWeightTextBox.ReadOnly = true;
            this.BlankMeterWeightTextBox.TabStop = false;
            // 
            // BlankSideTextBox
            // 
            resources.ApplyResources(this.BlankSideTextBox, "BlankSideTextBox");
            this.BlankSideTextBox.Name = "BlankSideTextBox";
            this.BlankSideTextBox.Enter += new System.EventHandler(this.BlankSideTextBox_Enter);
            this.BlankSideTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlankSideTextBox_KeyDown);
            this.BlankSideTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlankSideTextBox_KeyPress);
            this.BlankSideTextBox.Leave += new System.EventHandler(this.BlankSideTextBox_Leave);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Name = "label2";
            // 
            // BlankDiameterTextBox
            // 
            resources.ApplyResources(this.BlankDiameterTextBox, "BlankDiameterTextBox");
            this.BlankDiameterTextBox.Name = "BlankDiameterTextBox";
            this.BlankDiameterTextBox.Enter += new System.EventHandler(this.BlankDiameterTextBox_Enter);
            this.BlankDiameterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlankDiameterTextBox_KeyDown);
            this.BlankDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlankDiameterTextBox_KeyPress);
            this.BlankDiameterTextBox.Leave += new System.EventHandler(this.BlankDiameterTextBox_Leave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Name = "label1";
            // 
            // StretchingCoefficientGroup
            // 
            this.StretchingCoefficientGroup.Controls.Add(this.StretchingCoefficientWarningMessage);
            this.StretchingCoefficientGroup.Controls.Add(this.StretchingCoefficientTextBox);
            resources.ApplyResources(this.StretchingCoefficientGroup, "StretchingCoefficientGroup");
            this.StretchingCoefficientGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StretchingCoefficientGroup.Name = "StretchingCoefficientGroup";
            this.StretchingCoefficientGroup.TabStop = false;
            // 
            // StretchingCoefficientWarningMessage
            // 
            resources.ApplyResources(this.StretchingCoefficientWarningMessage, "StretchingCoefficientWarningMessage");
            this.StretchingCoefficientWarningMessage.ForeColor = System.Drawing.Color.Red;
            this.StretchingCoefficientWarningMessage.Name = "StretchingCoefficientWarningMessage";
            // 
            // StretchingCoefficientTextBox
            // 
            this.StretchingCoefficientTextBox.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.StretchingCoefficientTextBox, "StretchingCoefficientTextBox");
            this.StretchingCoefficientTextBox.Name = "StretchingCoefficientTextBox";
            this.StretchingCoefficientTextBox.ReadOnly = true;
            this.StretchingCoefficientTextBox.TabStop = false;
            // 
            // BlankLengthGroup
            // 
            this.BlankLengthGroup.Controls.Add(this.BlankLengthTextBox);
            resources.ApplyResources(this.BlankLengthGroup, "BlankLengthGroup");
            this.BlankLengthGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BlankLengthGroup.Name = "BlankLengthGroup";
            this.BlankLengthGroup.TabStop = false;
            this.BlankLengthGroup.Leave += new System.EventHandler(this.BlankLengthGroup_Leave);
            // 
            // BlankLengthTextBox
            // 
            resources.ApplyResources(this.BlankLengthTextBox, "BlankLengthTextBox");
            this.BlankLengthTextBox.Name = "BlankLengthTextBox";
            this.BlankLengthTextBox.Enter += new System.EventHandler(this.BlankLengthTextBox_Enter);
            this.BlankLengthTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlankLengthTextBox_KeyDown);
            this.BlankLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlankLengthTextBox_KeyPress);
            this.BlankLengthTextBox.Leave += new System.EventHandler(this.BlankLengthTextBox_Leave);
            // 
            // PipeLenghFromBlankGroup
            // 
            this.PipeLenghFromBlankGroup.Controls.Add(this.PipeLenghFromBlankTextBox);
            resources.ApplyResources(this.PipeLenghFromBlankGroup, "PipeLenghFromBlankGroup");
            this.PipeLenghFromBlankGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PipeLenghFromBlankGroup.Name = "PipeLenghFromBlankGroup";
            this.PipeLenghFromBlankGroup.TabStop = false;
            // 
            // PipeLenghFromBlankTextBox
            // 
            this.PipeLenghFromBlankTextBox.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.PipeLenghFromBlankTextBox, "PipeLenghFromBlankTextBox");
            this.PipeLenghFromBlankTextBox.Name = "PipeLenghFromBlankTextBox";
            this.PipeLenghFromBlankTextBox.ReadOnly = true;
            this.PipeLenghFromBlankTextBox.TabStop = false;
            // 
            // PipeLengthGroup
            // 
            this.PipeLengthGroup.Controls.Add(this.PipeLengthTextBox);
            resources.ApplyResources(this.PipeLengthGroup, "PipeLengthGroup");
            this.PipeLengthGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PipeLengthGroup.Name = "PipeLengthGroup";
            this.PipeLengthGroup.TabStop = false;
            this.PipeLengthGroup.Leave += new System.EventHandler(this.PipeLengthGroup_Leave);
            // 
            // PipeLengthTextBox
            // 
            resources.ApplyResources(this.PipeLengthTextBox, "PipeLengthTextBox");
            this.PipeLengthTextBox.Name = "PipeLengthTextBox";
            this.PipeLengthTextBox.Enter += new System.EventHandler(this.PipeLenghTextBox_Enter);
            this.PipeLengthTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PipeLenghTextBox_KeyDown);
            this.PipeLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PipeLenghTextBox_KeyPress);
            this.PipeLengthTextBox.Leave += new System.EventHandler(this.PipeLenghTextBox_Leave);
            // 
            // BlankLengthOutOfPipeGroup
            // 
            this.BlankLengthOutOfPipeGroup.Controls.Add(this.BlankLengthOutOfPipeTextBox);
            resources.ApplyResources(this.BlankLengthOutOfPipeGroup, "BlankLengthOutOfPipeGroup");
            this.BlankLengthOutOfPipeGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BlankLengthOutOfPipeGroup.Name = "BlankLengthOutOfPipeGroup";
            this.BlankLengthOutOfPipeGroup.TabStop = false;
            // 
            // BlankLengthOutOfPipeTextBox
            // 
            this.BlankLengthOutOfPipeTextBox.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.BlankLengthOutOfPipeTextBox, "BlankLengthOutOfPipeTextBox");
            this.BlankLengthOutOfPipeTextBox.Name = "BlankLengthOutOfPipeTextBox";
            this.BlankLengthOutOfPipeTextBox.ReadOnly = true;
            this.BlankLengthOutOfPipeTextBox.TabStop = false;
            // 
            // ResetButton
            // 
            resources.ApplyResources(this.ResetButton, "ResetButton");
            this.ResetButton.ForeColor = System.Drawing.Color.Red;
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Name = "label4";
            // 
            // PipeDiameterTextBox
            // 
            resources.ApplyResources(this.PipeDiameterTextBox, "PipeDiameterTextBox");
            this.PipeDiameterTextBox.Name = "PipeDiameterTextBox";
            this.PipeDiameterTextBox.Enter += new System.EventHandler(this.PipeDiameterTextBox_Enter);
            this.PipeDiameterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PipeDiameterTextBox_KeyDown);
            this.PipeDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PipeDiameterTextBox_KeyPress);
            this.PipeDiameterTextBox.Leave += new System.EventHandler(this.PipeDiameterTextBox_Leave);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Name = "label3";
            // 
            // PipeSideTextBox
            // 
            resources.ApplyResources(this.PipeSideTextBox, "PipeSideTextBox");
            this.PipeSideTextBox.Name = "PipeSideTextBox";
            this.PipeSideTextBox.Enter += new System.EventHandler(this.PipeSideTextBox_Enter);
            this.PipeSideTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PipeSideTextBox_KeyDown);
            this.PipeSideTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PipeSideTextBox_KeyPress);
            this.PipeSideTextBox.Leave += new System.EventHandler(this.PipeSideTextBox_Leave);
            // 
            // PipeMeterWeightGroup
            // 
            this.PipeMeterWeightGroup.Controls.Add(this.PipeMeterWeightTextBox);
            resources.ApplyResources(this.PipeMeterWeightGroup, "PipeMeterWeightGroup");
            this.PipeMeterWeightGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PipeMeterWeightGroup.Name = "PipeMeterWeightGroup";
            this.PipeMeterWeightGroup.TabStop = false;
            // 
            // PipeMeterWeightTextBox
            // 
            this.PipeMeterWeightTextBox.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.PipeMeterWeightTextBox, "PipeMeterWeightTextBox");
            this.PipeMeterWeightTextBox.Name = "PipeMeterWeightTextBox";
            this.PipeMeterWeightTextBox.ReadOnly = true;
            this.PipeMeterWeightTextBox.TabStop = false;
            // 
            // PipeDimensionsGroup
            // 
            this.PipeDimensionsGroup.Controls.Add(this.PipeWorningMessage);
            this.PipeDimensionsGroup.Controls.Add(this.PipeMeterWeightGroup);
            this.PipeDimensionsGroup.Controls.Add(this.PipeSideTextBox);
            this.PipeDimensionsGroup.Controls.Add(this.label3);
            this.PipeDimensionsGroup.Controls.Add(this.PipeDiameterTextBox);
            this.PipeDimensionsGroup.Controls.Add(this.label4);
            resources.ApplyResources(this.PipeDimensionsGroup, "PipeDimensionsGroup");
            this.PipeDimensionsGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PipeDimensionsGroup.Name = "PipeDimensionsGroup";
            this.PipeDimensionsGroup.TabStop = false;
            this.PipeDimensionsGroup.Leave += new System.EventHandler(this.PipeDimensionsGroup_Leave);
            // 
            // PipeWorningMessage
            // 
            resources.ApplyResources(this.PipeWorningMessage, "PipeWorningMessage");
            this.PipeWorningMessage.ForeColor = System.Drawing.Color.Red;
            this.PipeWorningMessage.Name = "PipeWorningMessage";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            resources.ApplyResources(this.MenuStrip, "MenuStrip");
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HowToUseToolStripMenuItem,
            this.aboutCalculatorToolStripMenuItem1});
            this.Menu.Name = "Menu";
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // HowToUseToolStripMenuItem
            // 
            this.HowToUseToolStripMenuItem.Name = "HowToUseToolStripMenuItem";
            resources.ApplyResources(this.HowToUseToolStripMenuItem, "HowToUseToolStripMenuItem");
            this.HowToUseToolStripMenuItem.Click += new System.EventHandler(this.HowToUseToolStripMenuItem_Click);
            // 
            // aboutCalculatorToolStripMenuItem1
            // 
            this.aboutCalculatorToolStripMenuItem1.Name = "aboutCalculatorToolStripMenuItem1";
            resources.ApplyResources(this.aboutCalculatorToolStripMenuItem1, "aboutCalculatorToolStripMenuItem1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StellGradeGroup);
            this.Controls.Add(this.OrderWeightGroup);
            this.Controls.Add(this.BlankDimensionsGroup);
            this.Controls.Add(this.PipeDimensionsGroup);
            this.Controls.Add(this.BlankLengthOutOfPipeGroup);
            this.Controls.Add(this.PipeLengthGroup);
            this.Controls.Add(this.PipeLenghFromBlankGroup);
            this.Controls.Add(this.BlankLengthGroup);
            this.Controls.Add(this.StretchingCoefficientGroup);
            this.Controls.Add(this.MetersOnOrderGroup);
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StellGradeGroup.ResumeLayout(false);
            this.StellGradeGroup.PerformLayout();
            this.OrderWeightGroup.ResumeLayout(false);
            this.OrderWeightGroup.PerformLayout();
            this.MetersOnOrderGroup.ResumeLayout(false);
            this.MetersOnOrderGroup.PerformLayout();
            this.BlankDimensionsGroup.ResumeLayout(false);
            this.BlankDimensionsGroup.PerformLayout();
            this.BlankMeterWeightGroup.ResumeLayout(false);
            this.BlankMeterWeightGroup.PerformLayout();
            this.StretchingCoefficientGroup.ResumeLayout(false);
            this.StretchingCoefficientGroup.PerformLayout();
            this.BlankLengthGroup.ResumeLayout(false);
            this.BlankLengthGroup.PerformLayout();
            this.PipeLenghFromBlankGroup.ResumeLayout(false);
            this.PipeLenghFromBlankGroup.PerformLayout();
            this.PipeLengthGroup.ResumeLayout(false);
            this.PipeLengthGroup.PerformLayout();
            this.BlankLengthOutOfPipeGroup.ResumeLayout(false);
            this.BlankLengthOutOfPipeGroup.PerformLayout();
            this.PipeMeterWeightGroup.ResumeLayout(false);
            this.PipeMeterWeightGroup.PerformLayout();
            this.PipeDimensionsGroup.ResumeLayout(false);
            this.PipeDimensionsGroup.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox StellGradeGroup;
        private System.Windows.Forms.GroupBox OrderWeightGroup;
        private System.Windows.Forms.TextBox OrderWeightTextBox;
        private System.Windows.Forms.GroupBox MetersOnOrderGroup;
        private System.Windows.Forms.TextBox LengthOnOrderTextBox;
        private System.Windows.Forms.RadioButton CarbonRadioButton;
        private System.Windows.Forms.RadioButton BearingsRadioButton;
        private System.Windows.Forms.GroupBox BlankDimensionsGroup;
        private System.Windows.Forms.GroupBox BlankMeterWeightGroup;
        private System.Windows.Forms.TextBox BlankMeterWeightTextBox;
        private System.Windows.Forms.TextBox BlankSideTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BlankDiameterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox StretchingCoefficientGroup;
        private System.Windows.Forms.TextBox StretchingCoefficientTextBox;
        private System.Windows.Forms.GroupBox BlankLengthGroup;
        private System.Windows.Forms.TextBox BlankLengthTextBox;
        private System.Windows.Forms.GroupBox PipeLenghFromBlankGroup;
        private System.Windows.Forms.TextBox PipeLenghFromBlankTextBox;
        private System.Windows.Forms.GroupBox PipeLengthGroup;
        private System.Windows.Forms.TextBox PipeLengthTextBox;
        private System.Windows.Forms.GroupBox BlankLengthOutOfPipeGroup;
        private System.Windows.Forms.TextBox BlankLengthOutOfPipeTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PipeDiameterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PipeSideTextBox;
        private System.Windows.Forms.GroupBox PipeMeterWeightGroup;
        private System.Windows.Forms.TextBox PipeMeterWeightTextBox;
        private System.Windows.Forms.GroupBox PipeDimensionsGroup;
        private System.Windows.Forms.Label BlankPipeWorningMessage;
        private System.Windows.Forms.Label PipeWorningMessage;
        private System.Windows.Forms.Label OrderLengthWarningMessage;
        private System.Windows.Forms.Label StretchingCoefficientWarningMessage;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem HowToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCalculatorToolStripMenuItem1;
    }
}

