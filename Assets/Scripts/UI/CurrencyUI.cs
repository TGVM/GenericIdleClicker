using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CurrencyUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currencyText;


    // Update is called once per frame
    void Update()
    {
        currencyText.text = Manager.Instance.GetCurrency().ToString();
    }
}
