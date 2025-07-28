using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public StatToChange statToChange = new StatToChange();
    public int amountToChangeStat;
    public AttributesToChange attributesToChange = new AttributesToChange();
    public int amountToChangeAttribute;

    public void UseItem()
    {
        if (statToChange == StatToChange.health)
        {
            Utility.health += amountToChangeStat;
            Debug.Log(Utility.health);
        }
        if (statToChange == StatToChange.health)
        {
            Utility.stamina += amountToChangeStat;
        }
        if (statToChange == StatToChange.health)
        {
            Utility.mana += amountToChangeStat;
        }
    }

    public enum StatToChange
    {
        none,
        health,
        stamina,
        mana
    };

    public enum AttributesToChange
    {
        none,
        strength,
        defense,
        agility
    };
}
