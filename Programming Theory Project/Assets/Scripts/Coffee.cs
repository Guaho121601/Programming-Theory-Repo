public class Coffee : Cup
{

    private int drinkVolume = 10; // ENCAPSULATION

    protected override void DrinkMethod() // POLYMORPHISM
    {
        base.DrinkMethod();
        if(GameController.healthCount <= 100 - drinkVolume)
            GameController.healthCount = GameController.healthCount + drinkVolume; 
        else
            GameController.healthCount = GameController.healthCount + (100 - GameController.healthCount);
    }
}
