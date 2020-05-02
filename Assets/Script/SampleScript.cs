using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SampleScript : MonoBehaviour
{
    #region DeclaringVariables

    public int numberToDisplay;
    public int numberToMultiplyBy = 6;

    #endregion DeclaringVariables

    // Start is called before the first frame update

    void Start()
    {
        SayHello();
        MultiplyNumber(5);
        Anonim();
    }

    private void SayHello()
    {
        var randomNumber = Random.Range(0, numberToDisplay);
        var displayText = "Heellloo";

        for(int i = 0; i < randomNumber; i++)
        {
            Debug.Log(displayText);
        }
    }

    private void MultiplyNumber(int numberToMultiply)
    {
        int product = numberToMultiply * numberToMultiplyBy;

        Debug.Log(product);
    }

    private void Anonim()
    {
        var enemy = new[] { new{ name = "Monster", hitPoints = 100 },
                            new{ name = "Goblin", hitPoints = 150 } };

        Debug.Log(enemy[1].name);

        foreach(var enem in enemy)
        {
            Debug.Log(enem.name + enem.hitPoints);
        }
    }
}
