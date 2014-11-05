using UnityEngine;
using System.Collections;

public class Shovel : MonoBehaviour,IClickEvent {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool click(GameObject prevChoose)
    {
        return true;
    }

    public void unClick()
    {
        print(name + " unClick");
    }
    public bool isUnchoosePrevObject(GameObject prevChoose)
    {
        return true;
    }
}
