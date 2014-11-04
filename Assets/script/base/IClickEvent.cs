using UnityEngine;
using System.Collections;

public interface IClickEvent{

    /**
     * 如果此物体是可处于选中状态的则返回true（如武器）,否则返回false(如grid)
     */
    bool click(GameObject prevChoose);

    /**
     * 取消选择时候执行
     */ 
    void unClick();
}
