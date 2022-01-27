public class Beer : Cup
{
    private int drinkVolume = 15;
    protected override void DrinkMethod() // POLYMORPHISM
    {
        base.DrinkMethod();
        if (GameController.healthCount > 0 && GameController.healthCount < drinkVolume)
            GameController.healthCount -= GameController.healthCount;
        else if (GameController.healthCount >= drinkVolume)
            GameController.healthCount = GameController.healthCount - drinkVolume;
        else return;
    }
}
 