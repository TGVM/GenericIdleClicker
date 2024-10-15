using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance { get; private set; }

    [SerializeField] private int currency;
    [SerializeField] private int currencyPerSecond;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currency = 0;
        currencyPerSecond = 0;


        InvokeRepeating("CurrencyIncreasePerSecond", 0, 1.0f);
    }


    void CurrencyIncreasePerSecond()
    {
        currency += currencyPerSecond;
    }

    public void IncreaseCurrency(int value)
    {
        currency += value;
    }

    public int GetCurrency()
    {
        return currency;
    }

    public int GetCurrencyPerSecond()
    {
        return currencyPerSecond;
    }

}
