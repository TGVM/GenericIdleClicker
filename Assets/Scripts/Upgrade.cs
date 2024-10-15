using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[System.Serializable]
public class Upgrade
{
    [SerializeField] private int price;
    [SerializeField] private string upgradeName;
    [SerializeField] private string upgradeDescription;
    [SerializeField] private Image icon;

    [SerializeField] private int addToCPS;

    public void increasePrice()
    {
        float multiplyer = 0.7f;
        price += (int)(price * multiplyer);
    }


}
