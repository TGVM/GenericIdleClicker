using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static event EventHandler<int> ClickedOnMainButton;

    public static Manager Instance { get; private set; }

    [SerializeField] private int currency;
    [SerializeField] private int currencyPerSecond;

    private int currentParticleLevel = 0;

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
        ClickedOnMainButton?.Invoke(this, currentParticleLevel);
    }

    public void IncreaseCurrencyPerSecond(int value)
    {
        currencyPerSecond += value;
        UpdateParticleLevel();
    }

    public int GetCurrency()
    {
        return currency;
    }

    public int GetCurrencyPerSecond()
    {
        return currencyPerSecond;
    }

    public void UpdateParticleLevel()
    {
        if(currencyPerSecond == 0) currentParticleLevel = 0;
        currentParticleLevel = currencyPerSecond.ToString().Length;
    }

}
