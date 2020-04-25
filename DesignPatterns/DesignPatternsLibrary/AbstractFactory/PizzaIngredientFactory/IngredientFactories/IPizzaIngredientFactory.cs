namespace DesignPatternsLibrary.AbstractFactory.PizzaIngredientFactory
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();

        ISauce CreateSauce();

        ICheese CreateCheese();

        IVeggies[] CreateVeggies();

        IPepperoni CreatePepperoni();

        IClams CreateClam();
    }
}
