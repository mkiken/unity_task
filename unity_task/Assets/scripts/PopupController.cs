using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController : MonoBehaviour
{
    public static Dictionary<string, GameObject> prefabMap = new Dictionary<string, GameObject>();
    // ビューを表示するstaticメソッド
    public static PopupController Show(string viewName){
        if (!prefabMap.ContainsKey(viewName)){
            prefabMap[viewName] = Resources.Load(viewName) as GameObject;
        }

        // プレハブをインスタンス化してビューを表示
        GameObject obj = Instantiate(prefabMap[viewName]) as GameObject;
        PopupController popupView = obj.GetComponent<PopupController>();

        return popupView;
    }

    // alertビューを閉じるメソッド
    public void Dismiss(){
        Destroy(gameObject);
    }
}
