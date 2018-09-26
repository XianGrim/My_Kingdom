using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST_Morality : MonoBehaviour
{
    private Rigidbody rb;
    public bool interactable = false;
    public int moralValue = 0;

    private string moralStamp;

    void Update()
    {
        rb = GetComponent<Rigidbody>();
        if (interactable && Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            Interact();
        }
    }
    public void Interact()
    {
        MoralityStampSystem();
        Debug.Log("Player's Moral Stamp is now "+moralStamp);
    }
    private void MoralityStampSystem()
    {
        /////////////////////////////////////EVIL
        if (moralValue <= -100)
        {
            moralStamp = "Malevolent";
        }
        if (moralValue <= -90)
        {
            moralStamp = "Malicious";
        }
        if (moralValue <= -80)
        {
            moralStamp = "Wicked";
        }
        if (moralValue <= -60)
        {
            moralStamp = "Nefarious";
        }
        if (moralValue <= -40)
        {
            moralStamp = "Corrupt";
        }
        if (moralValue < -20)
        {
            moralStamp = "Offensive";
        }
        //////////////////////////////////////NEUTRAL
        if (moralValue >= -20 && moralValue <= 20)
        {
            moralStamp = "Unbiased";
        };
        //////////////////////////////////////GOOD
        if (moralValue > 20)
        {
            moralStamp = "Okay";
        };
        if (moralValue >= 40)
        {
            moralStamp = "Decent";
        };
        if (moralValue >= 60)
        {
            moralStamp = "Honest";
        };
        if (moralValue >= 80)
        {
            moralStamp = "Honorable";
        };
        if (moralValue >= 90)
        {
            moralStamp = "Righteous";
        };
        if (moralValue >= 100)
        {
            moralStamp = "Benevolent";
        };
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && gameObject.tag == "GoodSphere")
        {
            interactable = true;
            moralValue += 10;
            MoralityStampSystem();
            print("+10 Moral Value! Morals are currently at " + moralValue + "and you are now " + moralStamp);
        };
        if (other.gameObject.tag == "Player" && gameObject.tag == "NeutralSphere")
        {
            interactable = true;
            MoralityStampSystem();
            print("No Moral Value! Morals are currently at " + moralValue + "and you are now " + moralStamp);
        }
        if (other.gameObject.tag == "Player" && gameObject.tag == "EvilSphere")
        {
            interactable = true;
            moralValue -= 10;
            MoralityStampSystem();
            print("-10 Moral Value! Morals are currently at '" + moralValue + "' and you are now " + moralStamp);
        };
    }

}























//    public GameObject playerMoralityScript;
//    public SphereCollider sphereCol;
//    public bool interactable = false;
//    public int moralValue = 0;
//    private string moralStamp;

//    // Use this for initialization
//    void Start () {
//        sphereCol = GetComponent<SphereCollider>();
//	}

//    public void Interact()
//    {
//        MoralityCheck();
//        MoralityStampSystem();
//        Player_Morality pm = playerMoralityScript.GetComponent<Player_Morality>();
//        Debug.Log("Player's Moral Value is now " + pm.playerMorality);

//        //print("You have " + moralValue + " moral points and are now " + moralStamp);
//    }
//    private void MoralityCheck()
//    {
//        if (sphereCol.tag == "GoodSphere")
//        {
//            moralValue += 10;
//        };

//        if (sphereCol.tag == "EvilSphere")
//        {
//            moralValue -= 10;
//        };
//        if (sphereCol.tag == "NeutralSphere")
//        {
//            moralValue += 0;
//        };

//    }
//    private void MoralityStampSystem()
//    {
//        /////////////////////////////////////EVIL
//        if (moralValue <= -100)
//        {
//            moralStamp = "Malevolent";
//        }
//        if (moralValue <= -90)
//        {
//            moralStamp = "Malicious";
//        }
//        if (moralValue <= -80)
//        {
//            moralStamp = "Wicked";
//        }
//        if (moralValue <= -60)
//        {
//            moralStamp = "Nefarious";
//        }
//        if (moralValue <= -40)
//        {
//            moralStamp = "Corrupt";
//        }
//        if (moralValue < -20)
//        {
//            moralStamp = "Offensive";
//        }
//        //////////////////////////////////////NEUTRAL
//        if (moralValue >= -20 && moralValue <= 20)
//        {
//            moralStamp = "Unbiased";
//        };
//        //////////////////////////////////////GOOD
//        if (moralValue > 20)
//        {
//            moralStamp = "Okay";
//        };
//        if (moralValue >= 40)
//        {
//            moralStamp = "Decent";
//        };
//        if (moralValue >= 60)
//        {
//            moralStamp = "Honest";
//        };
//        if (moralValue >= 80)
//        {
//            moralStamp = "Honorable";
//        };
//        if (moralValue >= 90)
//        {
//            moralStamp = "Righteous";
//        };
//        if (moralValue >= 100)
//        {
//            moralStamp = "Benevolent";
//        };
//    }
//    // Update is called once per frame
//    void Update()
//    {
//        if (interactable && Input.GetKeyDown(KeyCode.JoystickButton2))
//        {
//            Interact();
//        }
//    }

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.gameObject.tag == "Player")
//        {
//            interactable = true;
//        }
//    }
//    private void OnTriggerExit(Collider other)
//    {
//        if (other.gameObject.tag == "Player")
//        {
//            interactable = false;
//        }
//    }