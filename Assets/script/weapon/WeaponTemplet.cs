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

    /**
     * 武器的边框，被选中的时候需要显示出来
     */
    public GameObject border;
    private Renderer borderRenderer;


    private GameObject weaponPrefab;
    public GameObject WeaponPrefab
    {
        get { return weaponPrefab; }
    }

	// Use this for initialization
	void Start () {
        weaponPrefab = Resources.Load(weaponStr) as GameObject;
        borderRenderer = border.GetComponent<Renderer>();
        showBorder(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool click(GameObject prevChoose)
    {
        showBorder(true);
        return true;
    }

    public void unClick()
    {
        showBorder(false);
        print(name + "unClick");
    }

    public void showBorder( bool isShow ){
        borderRenderer.enabled = isShow;
    }


    public bool isUnchoosePrevObject(GameObject prevChoose)
    {
        return true;
    }
}
