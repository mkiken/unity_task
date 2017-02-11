using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController : MonoBehaviour
{
    public static GameObject prefab;
    // ビューを表示するstaticメソッド
    public static PopupController Show(){
        if (prefab == null){
            prefab = Resources.Load("Chat View") as GameObject;
        }

        // プレハブをインスタンス化してビューを表示
        GameObject obj = Instantiate(prefab) as GameObject;
        PopupController popupView = obj.GetComponent<PopupController>();

        return popupView;
    }

    // alertビューを閉じるメソッド
    public void Dismiss(){
        Destroy(gameObject);
    }
}
