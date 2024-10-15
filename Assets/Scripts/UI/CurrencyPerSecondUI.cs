using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrencyPerSecondUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currencyPerSecondText;


    // Update is called once per frame
    void Update()
    {
        currencyPerSecondText.text = Manager.Instance.GetCurrencyPerSecond().ToString();
    }
}
