namespace Model
{
    public interface IStatus
    {
        double Charge();
    }


    class ForeignStrategy : IStatus
    {
        public double Charge()
            => 500;

        public override string ToString()
            => "Foreign";
    }

    class DomesticStrategy : IStatus
    {
        public double Charge()
            => 0;
        
        public override string ToString()
            => "Domestic";
    }
}