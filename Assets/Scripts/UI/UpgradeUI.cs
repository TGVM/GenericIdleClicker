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

    [SerializeField] private Color wrongColor;
    [SerializeField] private Color rightColor;
    private Color prevColor;

    private Upgrade upgradeReference;


    private void Start()
    {
        prevColor = buyButton.image.color;

        buyButton.onClick.AddListener(() =>
        {
            if(upgradeReference.UpgradeBought())
            {
                UpdateVisuals();
                RightBlink();
            }
            else {
                WrongBlink();
            }
        });
    }

    private void RightBlink()
    {
        buyButton.image.color = rightColor;
        Invoke("ReturnToDefaultColor", 0.15f);
    }

    private void WrongBlink()
    {
        buyButton.image.color = wrongColor;
        Invoke("ReturnToDefaultColor", 0.15f);

    }

    private void ReturnToDefaultColor()
    {
        buyButton.image.color = prevColor;
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
