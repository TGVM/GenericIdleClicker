using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private TextMeshProUGUI priceText;
    //[SerializeField] private Image icon;
    [SerializeField] private Button buyButton;

    private Upgrade upgradeReference;


    //onclick
    //buy upgrade -> call function UpgradeBought on upgradeReference
    //              -> updateVisuals
    private void Start()
    {

        buyButton.onClick.AddListener(() =>
        {
            if(upgradeReference.UpgradeBought())
            {
                UpdateVisuals();
            }
            else {
                RedBlink();
            }
        });
    }

    private void RedBlink()
    {
        //TODO
    }

    private void UpdateVisuals()
    {
        titleText.text = upgradeReference.GetUpgradeName();
        descriptionText.text = upgradeReference.GetUpgradeDescription();
        priceText.text = upgradeReference.GetPrice().ToString();
    }

    public void SetReference(Upgrade upgrade) { 
        upgradeReference = upgrade;
        UpdateVisuals();
    }


}
