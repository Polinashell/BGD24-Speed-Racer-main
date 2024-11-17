using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    void Start()
    {
        Debug.Log($"The car model is {carModel} with an engine type of {engineType}.");

        CheckWeight();

        if (yearMade <= 2009)
        {
            Debug.Log($"The car was introduced in {yearMade}.");
            int carAge = CalculateAge(yearMade);
            Debug.Log($"The car is {carAge} years old.");
        }
        else
        {
            Debug.Log("The car was introduced in the 2010’s.");
            Debug.Log($"The car's maximum acceleration is {maxAcceleration}.");
        }

        Debug.Log(CheckCharacteristics());
    }

    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            Debug.Log($"{carModel} weighs less than 1500 kg.");
        }
        else
        {
            Debug.Log($"{carModel} weighs over 1500 kg.");
        }
    }

    int CalculateAge(int year)
    {
        return 2023 - year;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            return $"{carModel} is a sedan.";
        }
        else if (hasFrontEngine)
        {
            return $"{carModel} is not a sedan but has a front engine.";
        }
        else
        {
            return $"{carModel} is neither a sedan nor does it have a front engine.";
        }
    }
}
