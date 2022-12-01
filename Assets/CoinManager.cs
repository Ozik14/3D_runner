using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] int numberOfCoinsInLevel;

    [SerializeField] TextMeshProUGUI text;

    public void AddOne()
    {
        numberOfCoinsInLevel += 1;
        text.text = numberOfCoinsInLevel.ToString();
    }
}
