using UnityEngine;
using System.Collections;

/**
 * 控制WeaponTempletList的相关代码
 */
public class WeaponTempletList : MonoBehaviour {

    public float speed = 10;
    public float highLimit = -0.1139f;
    public float lowLimit = -2;
    private Vector3 target;
   // private int direction = -1;
   // private Renderer renderer;
	// Use this for initialization
	void Start () {
        target = transform.localPosition;
        target.x = lowLimit;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void show( )
    {
        StartCoroutine(move());  
        
    }

    /**
     * 移动面板,达到隐藏或者显示的目的
     */
    private IEnumerator move()
    {
        while (transform.localPosition != target)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, target, Time.deltaTime * speed);            
            yield return new WaitForEndOfFrame();            
        }
        toggle();
    }

    /**
     * 到达目的地后反向运动
     */
    private void toggle()
    {
        // 
        if (target.x == lowLimit)
        {
            target.x = highLimit;
        }
        else
        {
            target.x = lowLimit;
        }
            
    }  

    /**
     * 判断面板是否应该停止移动
     */
    //private bool stopMove(){
    //    return (transform.localPosition.x <= lowLimit && direction == -1) || (transform.localPosition.x >= highLimit  && direction == 1);
    //}
    public bool isShow()
    {
        return transform.localPosition.x >= -1;
    }

}
