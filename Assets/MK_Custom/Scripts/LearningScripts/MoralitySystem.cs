using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoralitySystem : MonoBehaviour {

    #region Singleton
    public static MoralitySystem instance;


    private void Awake()
    {
        instance = this;
    }
    #endregion

    public int maxMorality = 50;
    public int currentMorality { get; private set; }//this allows other scripts to GET values but not SET values

	// Use this for initialization
	void Start ()
    {
        currentMorality = maxMorality;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void LowerMorality(int moralsDown)
    {
        currentMorality -= moralsDown;
        if(currentMorality <= 25)
        {
            Evil();
        }
    }

    public void RaiseMorality(int moralsUp)
    {
        currentMorality += moralsUp;
        if(currentMorality >= 75)
        {
            Benevolent();
        }
    }

    public void Benevolent()
    {
        print("BENEVOLENT Morality| Moral Value: " + currentMorality);
    }

    public void Evil()
    {
        print("EVIL Morality| Moral value: " + currentMorality);
    }
}
