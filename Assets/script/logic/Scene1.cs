using UnityEngine;
using System.Collections;

public class Scene1 : MonoBehaviour {

    /**
     * 武器模板列表，10秒后隐藏
     */
    public GameObject weaponTempletList;
    private WeaponTempletList list;

	// Use this for initialization
	void Start () {
        list = weaponTempletList.GetComponent<WeaponTempletList>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            list.show( );
        }
	}
}
