using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GachaDrawController : MonoBehaviour
{
    public Image cardImagePrefab;
    public GameObject gachaResult;

    // Use this for initialization
    void Start()
    {
        List<Texture2D> textureList = new List<Texture2D>();
        Object[] textures = Resources.LoadAll("cards");
        foreach (Object obj in textures)
        {
            Texture2D texture = obj as Texture2D;
            // 多分metaファイル？を弾く
            if (texture == null)
            {
                continue;
            }
            textureList.Add(texture);
        }

        // 有効なTextureの中からランダムで1つ選ぶ
        Texture2D tex = textureList[Random.Range(0, textureList.Count)];
        Image card = Instantiate(cardImagePrefab);
        card.sprite = Sprite.Create(tex, new Rect(0, 0, 200, 300), Vector2.zero);
        card.transform.SetParent(gachaResult.transform);

		// 5秒後にシーン移動
		Invoke("goGachaScene", 5.0f);

    }

    void goGachaScene()
    {
        SceneManager.LoadScene("Gacha");
    }

}
