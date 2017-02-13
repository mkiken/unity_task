using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BannerControler : MonoBehaviour {

	// Use this for initialization
	public Image cardImagePrefab;
	public GameObject bannerField;
	public List<Image> imageList = new List<Image>();
	public List<Sprite> spriteList = new List<Sprite>();
	private int currentIndex = 0;
    void Start()
    {
        Object[] textures = Resources.LoadAll("Banner");
        foreach (Object obj in textures)
        {
			Texture2D texture = obj as Texture2D;
			// 多分metaファイル？を弾く
			if (texture == null){
				continue;
			}
            // Image card = Instantiate(cardImagePrefab);
            // card.sprite = Sprite.Create(texture as Texture2D, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
            spriteList.Add(Sprite.Create(texture as Texture2D, new Rect(0, 0, texture.width, texture.height), Vector2.zero));
            // card.transform.SetParent(bannerField.transform);
			// card.transform.localScale = bannerField.transform.localScale;
        }
		InvokeRepeating("setImage", 0.0f, 5.0f);
    }

	void setImage(){
		Image image = GetComponent<Image>();
		image.sprite = spriteList[currentIndex];
		currentIndex = (currentIndex + 1) % spriteList.Count;
	}
	
}
