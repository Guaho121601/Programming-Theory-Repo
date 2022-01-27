using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public Text health;
    public static int healthCount =  80;

    // Start is called before the first frame update
    void Start()
    {
        HealthCounting();
    }

    private void Update()
    {
        HealthCounting();
    }

    private void HealthCounting()
    {
        health.text = "Health: " + healthCount.ToString();
    }

}
