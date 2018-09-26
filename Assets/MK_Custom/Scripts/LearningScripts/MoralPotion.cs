using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Health Potion",menuName ="Inventory/Potion")]


public class MoralPotion : Item {//This is a created class from the Item script. Basically copy/pastes the code into this script
    public int moralModifier;
    MoralitySystem morals;

    void Start()
    {
        morals = MoralitySystem.instance;
    }

    public override void Use()
    {
        base.Use();
        ApplyEffect();
    }

    public void ApplyEffect()
    {
        morals.RaiseMorality(moralModifier);
    }
}
