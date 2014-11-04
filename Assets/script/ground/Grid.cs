using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// 代表大地上的一个格子，可以用来放置各种武器
/// </summary>
public class Grid : MonoBehaviour,IClickEvent {

    //GameObject weapon;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void unClick()
    {
        print(name + " unClick");
    }

    public bool click(GameObject prevChoose)
    {

        if (prevChoose != null && prevChoose.CompareTag("weaponTemplet"))//如果要放置的是武器
        {
            
            WeaponTemplet templet = prevChoose.GetComponent<WeaponTemplet>();
            Instantiate(templet.WeaponPrefab, transform.position, transform.rotation);
        }

        return false;
    }
}
