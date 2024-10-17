using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesManager : MonoBehaviour {
    public static UpgradesManager Instance { get; private set; }


    [SerializeField] private List<Upgrade> UpgradeList;


    
    public List<Upgrade> GetUpgradesList()
    {
        return UpgradeList;
    }

}
