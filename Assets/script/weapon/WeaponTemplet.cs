using UnityEngine;
using System.Collections;

/**
 * 武器模板图标，用于点选
 */
public class WeaponTemplet : MonoBehaviour,IClickEvent {

    /**
     * 武器对应的prefab的字符串
     */
    public string weaponStr;
    private GameObject weaponPrefab;
    public GameObject WeaponPrefab
    {
        get { return weaponPrefab; }
    }

	// Use this for initialization
	void Start () {
        weaponPrefab = Resources.Load(weaponStr) as GameObject;
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
        print(name + "unClick");
    }
}
