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
    [SerializeField] private int level;

    [SerializeField] private int addToCPS;

    public void IncreasePrice()
    {
        float multiplyer = 0.7f;
        price += (int)(price * multiplyer);
    }

    public bool UpgradeBought()
    {
        if(Manager.Instance.GetCurrency() >= price)
        {
            Manager.Instance.IncreaseCurrencyPerSecond(addToCPS);
            Manager.Instance.IncreaseCurrency(-price);
            IncreasePrice();
            level++;
            return true;
        }
        return false;
    }

    public string GetUpgradeName() { return upgradeName; }
    public string GetUpgradeDescription() {  return upgradeDescription; }
    public int GetLevel() { return level; }
    public int GetPrice() {  return price; }

}
