namespace Exercicio_Polimorfismo.Entities
{
    public class OutsourcedEmployee: Employee
    {
        public double AdditionalChange { get; set; }
        public OutsourcedEmployee(){}
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalChange)
        :base(name, hours, valuePerHour)
        {
            AdditionalChange = additionalChange;
        }
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalChange;
        }
    }
}