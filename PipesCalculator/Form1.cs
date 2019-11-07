using System;
using System.Windows.Forms;
using static PipesCalculator.Pipes;

namespace PipesCalculator
{
    public partial class Form1 : Form
    {
        private const string InitialTextBoxValue = "0.00";

        private bool isInputCorrect;
        private bool isEnterButtonPressed;
        private Pipes blankPipe;
        private Pipes pipe;
        private TextBoxInputHendler textBoxInput;
        private ManualForm manualInstruction;

        public Form1()
        {
            InitializeComponent();

            this.blankPipe = new Pipes();
            this.pipe = new Pipes();
            this.textBoxInput = new TextBoxInputHendler();
            manualInstruction = new ManualForm();

            if (BearingsRadioButton.Checked == true)
            {
                this.blankPipe.stellGrade = StellGrades.Bearings;
                this.blankPipe.empiricalCoefficient = BallBearingEmpiricalCoefficient;
                this.pipe.stellGrade = StellGrades.Bearings;
                this.pipe.empiricalCoefficient = BallBearingEmpiricalCoefficient;
            }
        }

        #region BEARINGS RADIO BUTTON
        private void BearingsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BearingsRadioButton.Checked == true)
            {
                this.blankPipe.stellGrade = StellGrades.Bearings;
                this.blankPipe.empiricalCoefficient = BallBearingEmpiricalCoefficient;
                this.pipe.stellGrade = StellGrades.Bearings;
                this.pipe.empiricalCoefficient = BallBearingEmpiricalCoefficient;

                BlankDimensionsGroup_Leave(sender, e);
                PipeDimensionsGroup_Leave(sender, e);
                BlankLengthGroup_Leave(sender, e);
                PipeLengthGroup_Leave(sender, e);
            }
            else
            {
                this.blankPipe.stellGrade = StellGrades.NoGrade;
                this.blankPipe.empiricalCoefficient = 0.0;
                this.pipe.stellGrade = StellGrades.NoGrade;
                this.pipe.empiricalCoefficient = 0.0;
            }
        }
        #endregion

        #region CARBON RADIO BUTTON
        private void CarbonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CarbonRadioButton.Checked == true)
            {
                this.blankPipe.stellGrade = StellGrades.Carbon;
                this.blankPipe.empiricalCoefficient = CarbonEmpiricalCoeffiecient;
                this.pipe.stellGrade = StellGrades.Carbon;
                this.pipe.empiricalCoefficient = CarbonEmpiricalCoeffiecient;

                BlankDimensionsGroup_Leave(sender, e);
                PipeDimensionsGroup_Leave(sender, e);
                BlankLengthGroup_Leave(sender, e);
                PipeLengthGroup_Leave(sender, e);
            }
            else
            {
                this.blankPipe.stellGrade = StellGrades.NoGrade;
                this.blankPipe.empiricalCoefficient = 0.0;
                this.pipe.stellGrade = StellGrades.NoGrade;
                this.pipe.empiricalCoefficient = 0.0;
            }
        }
        #endregion

        #region ORDER WEIGHT GROUP
        private void OrderWeightGroup_Leave(object sender, EventArgs e)
        {
            LengthOnOrderWarningMessagesHendler();
        }
        #endregion

        #region ORDER WEIGHT TEXT BOX
        private void OrderWeightTextBox_Enter(object sender, EventArgs e)
        {
            if (OrderWeightTextBox.Text.Equals(InitialTextBoxValue))
            {
                this.OrderWeightTextBox.Clear();
            }
        }

        private void OrderWeightTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.isEnterButtonPressed = false;
            this.isInputCorrect = textBoxInput.KeysInputHendler(OrderWeightTextBox, e);

            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterButtonPressed = true;
                this.isInputCorrect = true;
            }
        }

        private void OrderWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.isInputCorrect == false)
            {
                e.Handled = true;
            }

            if (isEnterButtonPressed == true)
            {
                e.Handled = true;
                this.BlankDiameterTextBox.Focus();
            }
        }

        private void OrderWeightTextBox_Leave(object sender, EventArgs e)
        {
            this.pipe.orderWeight = textBoxInput.FloatNumbersInputHendler(OrderWeightTextBox);

            if (this.pipe.orderWeight == 0)
            {
                OrderWeightTextBox.Text = InitialTextBoxValue;
            }


        }
        #endregion

        #region BLANK PIPE DIMENSIONS GROUP
        private void BlankDimensionsGroup_Leave(object sender, EventArgs e)
        {
            PipesDimentionsWarningMessagesHendler(blankPipe, BlankPipeWorningMessage, BlankMeterWeightTextBox);
            StretchingCoefficientWarningMessagesHendler();
            BlankLengthGroup_Leave(sender, e);
            PipeLengthGroup_Leave(sender, e);
        }
        #endregion

        #region BLANK DIAMETER TEXT BOX
        private void BlankDiameterTextBox_Enter(object sender, EventArgs e)
        {
            if (BlankDiameterTextBox.Text.Equals(InitialTextBoxValue))
            {
                BlankDiameterTextBox.Clear();
            }
        }

        private void BlankDiameterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.isEnterButtonPressed = false;
            this.isInputCorrect = textBoxInput.KeysInputHendler(BlankDiameterTextBox, e);

            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterButtonPressed = true;
                this.isInputCorrect = true;
            }
        }

        private void BlankDiameterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.isInputCorrect == false)
            {
                e.Handled = true;
            }

            if (isEnterButtonPressed == true)
            {
                e.Handled = true;
                this.BlankSideTextBox.Focus();
            }
        }

        private void BlankDiameterTextBox_Leave(object sender, EventArgs e)
        {
            this.blankPipe.diameter = textBoxInput.FloatNumbersInputHendler(BlankDiameterTextBox);

            if (this.blankPipe.diameter == 0)
            {
                BlankDiameterTextBox.Text = InitialTextBoxValue;
            }
        }
        #endregion

        #region BLANK SIDE TEXT BOX
        private void BlankSideTextBox_Enter(object sender, EventArgs e)
        {
            if (BlankSideTextBox.Text.Equals(InitialTextBoxValue))
            {
                BlankSideTextBox.Clear();
            }
        }

        private void BlankSideTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.isEnterButtonPressed = false;
            this.isInputCorrect = textBoxInput.KeysInputHendler(BlankSideTextBox, e);

            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterButtonPressed = true;
                this.isInputCorrect = true;
            }
        }

        private void BlankSideTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.isInputCorrect == false)
            {
                e.Handled = true;
            }

            if (isEnterButtonPressed == true)
            {
                e.Handled = true;
                this.PipeDiameterTextBox.Focus();
            }
        }

        private void BlankSideTextBox_Leave(object sender, EventArgs e)
        {
            this.blankPipe.side = textBoxInput.FloatNumbersInputHendler(BlankSideTextBox);

            if (this.blankPipe.side == 0)
            {
                BlankSideTextBox.Text = InitialTextBoxValue;
            }
        }
        #endregion

        #region PIPE DIMENSIONS GROUP
        private void PipeDimensionsGroup_Leave(object sender, EventArgs e)
        {
            PipesDimentionsWarningMessagesHendler(pipe, PipeWorningMessage, PipeMeterWeightTextBox);
            LengthOnOrderWarningMessagesHendler();
            StretchingCoefficientWarningMessagesHendler();
            BlankLengthGroup_Leave(sender, e);
            PipeLengthGroup_Leave(sender, e);
        }
        #endregion

        #region PIPE DIAMETER TEXT BOX
        private void PipeDiameterTextBox_Enter(object sender, EventArgs e)
        {
            if (PipeDiameterTextBox.Text.Equals(InitialTextBoxValue))
            {
                PipeDiameterTextBox.Clear();
            }
        }

        private void PipeDiameterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.isEnterButtonPressed = false;
            this.isInputCorrect = textBoxInput.KeysInputHendler(PipeDiameterTextBox, e);

            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterButtonPressed = true;
                this.isInputCorrect = true;
            }
        }

        private void PipeDiameterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.isInputCorrect == false)
            {
                e.Handled = true;
            }

            if (isEnterButtonPressed == true)
            {
                e.Handled = true;
                this.PipeSideTextBox.Focus();
            }
        }

        private void PipeDiameterTextBox_Leave(object sender, EventArgs e)
        {
            this.pipe.diameter = textBoxInput.FloatNumbersInputHendler(PipeDiameterTextBox);

            if (this.pipe.diameter == 0)
            {
                PipeDiameterTextBox.Text = InitialTextBoxValue;
            }
        }
        #endregion

        #region PIPE SIDE TEXT BOX
        private void PipeSideTextBox_Enter(object sender, EventArgs e)
        {
            if (PipeSideTextBox.Text.Equals(InitialTextBoxValue))
            {
                PipeSideTextBox.Clear();
            }
        }

        private void PipeSideTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.isEnterButtonPressed = false;
            this.isInputCorrect = textBoxInput.KeysInputHendler(PipeSideTextBox, e);

            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterButtonPressed = true;
                this.isInputCorrect = true;
            }
        }

        private void PipeSideTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.isInputCorrect == false)
            {
                e.Handled = true;
            }

            if (isEnterButtonPressed == true)
            {
                e.Handled = true;
                this.BlankLengthTextBox.Focus();
            }
        }

        private void PipeSideTextBox_Leave(object sender, EventArgs e)
        {
            this.pipe.side = textBoxInput.FloatNumbersInputHendler(PipeSideTextBox);

            if (this.pipe.side == 0)
            {
                PipeSideTextBox.Text = InitialTextBoxValue;
            }
        }
        #endregion

        #region BLANK PIPE LENGS GROUP
        private void BlankLengthGroup_Leave(object sender, EventArgs e)
        {
            if (blankPipe.length == 0 && pipe.stretchingCoeff == 0)
            {
                PipeLenghFromBlankTextBox.Text = InitialTextBoxValue;
            }
            else if (blankPipe.length != 0 && pipe.stretchingCoeff == 0)
            {
                PipeLenghFromBlankTextBox.Text = InitialTextBoxValue;
            }
            else if (blankPipe.length == 0 && pipe.stretchingCoeff != 0)
            {
                PipeLenghFromBlankTextBox.Text = InitialTextBoxValue;
            }
            else if (blankPipe.length != 0 && pipe.stretchingCoeff != 0)
            {
                PipeLenghFromBlankTextBox.Text = (blankPipe.length * pipe.stretchingCoeff).ToString("0");
            }
        }
        #endregion

        #region BLANK LENGTH TEXT BOX
        private void BlankLengthTextBox_Enter(object sender, EventArgs e)
        {
            if (BlankLengthTextBox.Text.Equals(InitialTextBoxValue))
            {
                BlankLengthTextBox.Clear();
            }
        }

        private void BlankLengthTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.isEnterButtonPressed = false;
            this.isInputCorrect = textBoxInput.KeysInputHendler(BlankLengthTextBox, e);

            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterButtonPressed = true;
                this.isInputCorrect = true;
            }
        }

        private void BlankLengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.isInputCorrect == false)
            {
                e.Handled = true;
            }

            if (isEnterButtonPressed == true)
            {
                e.Handled = true;
                this.PipeLengthTextBox.Focus();
            }
        }

        private void BlankLengthTextBox_Leave(object sender, EventArgs e)
        {
            this.blankPipe.length = textBoxInput.FloatNumbersInputHendler(BlankLengthTextBox);

            if (this.blankPipe.length == 0)
            {
                BlankLengthTextBox.Text = InitialTextBoxValue;
            }
        }
        #endregion

        #region PIPE LENGTH TEXT BOX
        private void PipeLenghTextBox_Enter(object sender, EventArgs e)
        {
            if (PipeLengthTextBox.Text.Equals(InitialTextBoxValue))
            {
                PipeLengthTextBox.Clear();
            }
        }

        private void PipeLenghTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.isEnterButtonPressed = false;
            this.isInputCorrect = textBoxInput.KeysInputHendler(PipeLengthTextBox, e);

            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterButtonPressed = true;
                this.isInputCorrect = true;
            }
        }

        private void PipeLenghTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.isInputCorrect == false)
            {
                e.Handled = true;
            }

            if (isEnterButtonPressed == true)
            {
                e.Handled = true;
                this.ResetButton.Focus();
            }
        }

        private void PipeLenghTextBox_Leave(object sender, EventArgs e)
        {
            this.pipe.length = textBoxInput.FloatNumbersInputHendler(PipeLengthTextBox);

            if (this.pipe.length == 0)
            {
                PipeLengthTextBox.Text = InitialTextBoxValue;
            }
        }
        #endregion

        #region PIPE LENGTH GROUP
        private void PipeLengthGroup_Leave(object sender, EventArgs e)
        {
            if (pipe.length == 0 && pipe.stretchingCoeff == 0)
            {
                BlankLengthOutOfPipeTextBox.Text = InitialTextBoxValue;
            }
            else if (pipe.length != 0 && pipe.stretchingCoeff == 0)
            {
                BlankLengthOutOfPipeTextBox.Text = InitialTextBoxValue;
            }
            else if (pipe.length == 0 && pipe.stretchingCoeff != 0)
            {
                BlankLengthOutOfPipeTextBox.Text = InitialTextBoxValue;
            }
            else if (pipe.length != 0 && pipe.stretchingCoeff != 0)
            {
                BlankLengthOutOfPipeTextBox.Text = (pipe.length / pipe.stretchingCoeff).ToString("0");
            }
        }
        #endregion

        #region RESET BUTTON
        private void Reset_Click(object sender, EventArgs e)
        {
            BearingsRadioButton.Checked = true;
            blankPipe.ResetParameters();
            pipe.ResetParameters();

            if (BearingsRadioButton.Checked == true)
            {
                blankPipe.stellGrade = StellGrades.Bearings;
                pipe.stellGrade = StellGrades.Bearings;
            }

            OrderWeightTextBox.Text = InitialTextBoxValue;
            BlankDiameterTextBox.Text = InitialTextBoxValue;
            BlankSideTextBox.Text = InitialTextBoxValue;
            BlankPipeWorningMessage.ResetText();
            BlankMeterWeightTextBox.Text = InitialTextBoxValue;
            PipeDiameterTextBox.Text = InitialTextBoxValue;
            PipeSideTextBox.Text = InitialTextBoxValue;
            PipeWorningMessage.ResetText();
            PipeMeterWeightTextBox.Text = InitialTextBoxValue;
            StretchingCoefficientTextBox.Text = InitialTextBoxValue;
            LengthOnOrderTextBox.Text = InitialTextBoxValue;
            BlankLengthTextBox.Text = InitialTextBoxValue;
            PipeLenghFromBlankTextBox.Text = InitialTextBoxValue;
            PipeLengthTextBox.Text = InitialTextBoxValue;
            BlankLengthOutOfPipeTextBox.Text = InitialTextBoxValue;

            StretchingCoefficientWarningMessage.ResetText();
            OrderLengthWarningMessage.ResetText();
        }
        #endregion

        private void LengthOnOrderWarningMessagesHendler()
        {
            OrderLengthWarningMessage.ResetText();

            if (pipe.orderWeight != 0 && pipe.weightOfMeter != 0)
            {
                LengthOnOrderTextBox.Text = pipe.CalculateMeteresOnOrder().ToString("0.0");
            }
            else if (pipe.orderWeight == 0 && pipe.weightOfMeter == 0)
            {
                OrderLengthWarningMessage.Left = 30;
                OrderLengthWarningMessage.Top = 50;
                OrderLengthWarningMessage.Text = "Введите вес по заказу\nи размеры готовой трубы";
                LengthOnOrderTextBox.Text = InitialTextBoxValue;
            }
            else if (pipe.orderWeight == 0 && pipe.weightOfMeter != 0)
            {
                OrderLengthWarningMessage.Left = 38;
                OrderLengthWarningMessage.Top = 57;
                OrderLengthWarningMessage.Text = "Введите вес по заказу";
                LengthOnOrderTextBox.Text = InitialTextBoxValue;
            }
            else if (pipe.orderWeight != 0 && pipe.weightOfMeter == 0)
            {
                OrderLengthWarningMessage.Left = 15;
                OrderLengthWarningMessage.Top = 57;
                OrderLengthWarningMessage.Text = "Введите размеры готовой трубы";
                LengthOnOrderTextBox.Text = InitialTextBoxValue;
            }
        }

        private void PipesDimentionsWarningMessagesHendler(Pipes pipe, Label warningMessage, TextBox textBoxResult)
        {
            warningMessage.ResetText();

            if (pipe.diameter == 0.00 && pipe.side == 0.00)
            {
                textBoxResult.Text = InitialTextBoxValue;
                pipe.weightOfMeter = 0.00;
            }
            else if (pipe.diameter == 0.00 && pipe.side != 0.00)
            {
                warningMessage.Left = 30;
                warningMessage.Top = 50;
                warningMessage.Text = "Диаметр не может\nравняться 0";
                textBoxResult.Text = InitialTextBoxValue;
                pipe.weightOfMeter = 0.00;
            }
            else if (pipe.diameter != 0.00 && pipe.side == 0.00)
            {
                warningMessage.Left = 155;
                warningMessage.Top = 50;
                warningMessage.Text = "Стенка не может\nравняться 0";
                textBoxResult.Text = InitialTextBoxValue;
                pipe.weightOfMeter = 0.00;
            }
            else if (!pipe.CheckRatioOfDiameterToSide())
            {
                warningMessage.Left = 15;
                warningMessage.Top = 55;
                warningMessage.Text = "Диаметр (D) должен быть больше стенки (S) * 2";
                textBoxResult.Text = InitialTextBoxValue;
                pipe.weightOfMeter = 0.00;
            }
            else if (pipe.CheckRatioOfDiameterToSide())
            {
                warningMessage.ResetText();
                textBoxResult.Text = pipe.CalculatePipesOneMetereWeight().ToString("0.00");
            }
        }

        private void StretchingCoefficientWarningMessagesHendler()
        {
            StretchingCoefficientWarningMessage.ResetText();

            if(blankPipe.CheckRatioOfDiameterToSide() && pipe.CheckRatioOfDiameterToSide())
            {

                StretchingCoefficientTextBox.Text
                    = pipe.CalculateStretchingCoefficient(blankPipe.diameter, blankPipe.side).ToString("0.000");
            }
            else
            {
                StretchingCoefficientWarningMessage.Text = "Введите размеры заготовки\nи/или размеры готовой трубы";
                StretchingCoefficientTextBox.Text = InitialTextBoxValue;
                pipe.stretchingCoeff = 0.00;
            }
        }

        private void HowToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manualInstruction.Show();
        }
    }
}
