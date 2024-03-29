namespace PRJFuncionarioDespesa.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double additionalCHarge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour,double additionalCHarge)
            :base(name,hours,valuePerHour)
        {
            this.additionalCHarge = additionalCHarge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1*additionalCHarge;
        }
    }
}
