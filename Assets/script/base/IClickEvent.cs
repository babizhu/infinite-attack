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
    /**
     * 是否反选上一个被选择项目，比如点选grid就不应该反选上一个点击对象，而点击武器模板就应该要反选择上一个点击对象
     */
    bool isUnchoosePrevObject(GameObject prevChoose);
}
