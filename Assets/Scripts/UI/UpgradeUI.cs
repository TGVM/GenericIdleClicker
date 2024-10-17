using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UpgradeUI : MonoBehaviour
{
    [SerializeField] private Button buyButton;

    private Upgrade upgradeReference;


    public void SetReference(Upgrade upgrade) { 
        upgradeReference = upgrade;
    }


}
