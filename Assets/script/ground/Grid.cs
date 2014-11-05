using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// 代表大地上的一个格子，可以用来放置各种武器
/// </summary>
public class Grid : MonoBehaviour, IClickEvent
{

    //GameObject weapon;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void unClick()
    {
        print(name + " unClick");
    }

    public bool click(GameObject prevChoose)
    {

        if (prevChoose != null && prevChoose.CompareTag("weaponTemplet"))//如果要放置的是武器模板
        {

            WeaponTemplet templet = prevChoose.GetComponent<WeaponTemplet>();
            IWeapon w = Instantiate(templet.WeaponPrefab, transform.position, transform.rotation) as IWeapon;
            //print
        }

        return false;
    }

    public bool isUnchoosePrevObject(GameObject prevChoose)
    {
        return false;
    }
}
