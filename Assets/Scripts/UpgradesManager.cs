using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesManager : MonoBehaviour {

    public static event EventHandler<Upgrade> AddUpgrade;


    [SerializeField] private List<Upgrade> UpgradeList;

    private void Start()
    {
        AddUpgradesToUI();
    }

    private void AddUpgradesToUI()
    {
        foreach (Upgrade upgrade in UpgradeList)
        {
            AddUpgrade?.Invoke(this, upgrade);
        }
        
    }

    public List<Upgrade> GetUpgradesList()
    {
        return UpgradeList;
    }

}
