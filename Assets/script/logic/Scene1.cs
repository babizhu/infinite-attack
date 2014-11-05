using UnityEngine;
using System.Collections;

public class Scene1 : MonoBehaviour {

    /**
     * 武器模板列表，10秒后隐藏
     */
    public GameObject weaponTempletList;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //weaponTempletList.renderer.enable = true;
        }
	}
}
