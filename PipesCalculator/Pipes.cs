namespace PipesCalculator
{
    public enum StellGrades
    {
        NoGrade,
        Bearings,
        Carbon
    }

    public class Pipes
    {
        public const double BallBearingEmpiricalCoefficient = 0.026;
        public const double CarbonEmpiricalCoeffiecient = 0.0246615;

        public StellGrades stellGrade { get; set; }
        public double empiricalCoefficient { get; set; }
        public double diameter { get; set; }
        public double side { get; set; }
        public double weightOfMeter { get; set; }
        public double length { get; set; }
        public double stretchingCoeff { get; set; }
        public double orderWeight { get; set; }

        public Pipes()
        {
            this.stellGrade = StellGrades.NoGrade;
            this.empiricalCoefficient = 0.0;
            this.diameter = 0.0;
            this.side = 0.0;
            this.weightOfMeter = 0.0;
            this.length = 0.0;
            this.stretchingCoeff = 0.0;
            this.orderWeight = 0.0;
        }

        public bool CheckRatioOfDiameterToSide()
        {
            return diameter != 0 && side != 0 && diameter > (side * 2);
        }

        public double CalculatePipesOneMetereWeight()
        {
            switch (this.stellGrade)
            {
                case StellGrades.Bearings:
                    this.weightOfMeter = (diameter - side) * side * BallBearingEmpiricalCoefficient;
                    break;
                case StellGrades.Carbon:
                    this.weightOfMeter = (diameter - side) * side * CarbonEmpiricalCoeffiecient;
                    break;
                default:
                    break;
            }

            return this.weightOfMeter;
        }

        public double CalculateMeteresOnOrder()
        {
            if (this.weightOfMeter != 0)
            {
                return this.orderWeight / this.weightOfMeter;
            }

            return default;
        }

        public double CalculateStretchingCoefficient(double blankPipeDiameter, double blankPipeSide)
        {
            this.stretchingCoeff = ((blankPipeDiameter - blankPipeSide) * blankPipeSide) / ((this.diameter - this.side) * this.side);

            return this.stretchingCoeff;
        }

        public void ResetParameters()
        {
            this.stellGrade = StellGrades.NoGrade;
            this.empiricalCoefficient = 0.0;
            this.diameter = 0.0;
            this.side = 0.0;
            this.weightOfMeter = 0.0;
            this.length = 0.0;
            this.stretchingCoeff = 0.0;
            this.orderWeight = 0.0;
        }
    }
}
