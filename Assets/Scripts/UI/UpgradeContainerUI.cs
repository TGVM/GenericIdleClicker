using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UpgradeContainerUI : MonoBehaviour
{
    [SerializeField] private UpgradeUI upgradePrefab;
    [SerializeField] private RectTransform container;

    private List<UpgradeUI> UpgradeList;


    private void Awake()
    {
        UpgradeList = new List<UpgradeUI>();
    }


    private void OnEnable()
    {
        UpgradesManager.AddUpgrade += UpgradesManager_AddUpgrade;
    }

    private void UpgradesManager_AddUpgrade(object sender, Upgrade e)
    {
        //create upgradeUI object and add to list
        UpgradeUI newUpgrade = Instantiate(upgradePrefab, container);
        newUpgrade.SetReference(e);
        UpgradeList.Add(newUpgrade);


    }
}
