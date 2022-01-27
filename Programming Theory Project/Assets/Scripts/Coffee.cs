public class Coffee : Cup
{

    private int drinkVolume = 10;

    protected override void DrinkMethod()
    {
        base.DrinkMethod();
        if(GameController.healthCount <= 100 - drinkVolume)
            GameController.healthCount = GameController.healthCount + drinkVolume; 
        else
            GameController.healthCount = GameController.healthCount + (100 - GameController.healthCount);
    }
}
