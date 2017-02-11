using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour
{
    public Image cardImagePrefab;
    public GameObject cardContent;

    // Use this for initialization
    void Start()
    {
        Object[] textures = Resources.LoadAll("cards");
        foreach (Object obj in textures)
        {
			Texture2D texture = obj as Texture2D;
			// 多分metaファイル？を弾く
			if (texture == null){
				continue;
			}
            Image card = Instantiate(cardImagePrefab);
            card.sprite = Sprite.Create(texture as Texture2D, new Rect(0, 0, 200, 300), Vector2.zero);
            card.transform.SetParent(cardContent.transform);
        }
    }
}
