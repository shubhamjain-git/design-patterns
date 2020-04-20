namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public abstract class Beverage
    {
        public enum Size { SMALL, MEDIUM, LARGE };
        protected Size size = Size.SMALL;
        protected string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public void SetSize(Size size)
        {
            this.size = size;
        }

        public virtual Size GetSize()
        {
            return size;
        }
        public abstract float Cost();
    }
}
