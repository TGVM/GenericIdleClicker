using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollerUI : MonoBehaviour
{
    [SerializeField] private UpgradeUI upgradeUIPrefab;
    private List<UpgradeUI> upgradeUIList;

    // Start is called before the first frame update
    void Start()
    {
        
        //List<Upgrade> upgradesList = Manager.Instance.GetList();
        foreach(Upgrade u in upgradesList)
        {
            UpgradeUI upgradeUIiteration = upgradeUIPrefab;
            upgradeUIiteration.SetReference(u);
            upgradeUIList.Add(upgradeUIiteration);
        }
    }
}
