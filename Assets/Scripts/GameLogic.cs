using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    [SerializeField] int min = 1;
    [SerializeField] int max = 1000;
    int guess = 500;
    [SerializeField] Text guessText;

    private void Start()
    {
        CalculateGuess();
    }

    void CalculateGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess + "";
        int[] values = { min, max, guess };
        Debug.Log($"\"{min}, {max}, {guess}\"");
    }

    void ResetGame()
    {
        min = 1;
        max = 1000;
        guess = 500;
    }

    public void Higher()
    {
        if (min == max)
            CalculateGuess();
        else
        {
            min = guess + 1;
            CalculateGuess();
        }
    }

    public void Lower()
    {
        if (min == max)
            CalculateGuess();
        else
        {
            max = guess - 1;
            CalculateGuess();
        }
    }
}
