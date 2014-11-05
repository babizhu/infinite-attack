using UnityEngine;
using System.Collections;

public class IceGun : MonoBehaviour,IClickEvent,IWeapon{
    /**
     * 自己是否处于选中状态
     */
    private bool isChoose;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool click(GameObject prevChoose)
    {
        if (prevChoose != null)
        {


            switch (prevChoose.tag)
            {
                case "shovel":
                    Destroy(gameObject);                    
                    break;
                default:
                    //choose();
                    break;
            }
        }

        return false;
    }

   

    public void unClick()
    {

        print(name + " unClick");
    }

    public bool isUnchoosePrevObject(GameObject prevChoose)
    {
        return false;
    }
}
