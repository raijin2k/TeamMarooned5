using UnityEngine;
using UnityEngine.UI;

public class FuelBarHandler : MonoBehaviour
{
    private static Image FuelBarImage;

    /// <summary>
    /// Sets the Fuel bar value
    /// </summary>
    /// <param name="value">should be between 0 to 1</param>
    public static void SetFuelBarValue(float value)
    {
        FuelBarImage.fillAmount = value;
        if(FuelBarImage.fillAmount < 0.2f)
        {
            SetFuelBarColor(Color.green);
        }
        else if(FuelBarImage.fillAmount < 0.4f)
        {
            SetFuelBarColor(Color.yellow);
        }
        else
        {
            SetFuelBarColor(Color.green);
        }
    }

    public static float GetFuelBarValue()
    {
        return FuelBarImage.fillAmount;
    }

    /// <summary>
    /// Sets the Fuel bar color
    /// </summary>
    /// <param name="FuelColor">Color </param>
    public static void SetFuelBarColor(Color FuelColor)
    {
        FuelBarImage.color = FuelColor;
    }

    /// <summary>
    /// Initialize the variable
    /// </summary>
    private void Start()
    {
        FuelBarImage = GetComponent<Image>();
    }
}