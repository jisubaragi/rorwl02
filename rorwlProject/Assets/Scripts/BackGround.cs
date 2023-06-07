using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public Sprite[] sprites;

    SpriteRenderer sprite;
    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(AiManager.instance.numberManager.turn<3)
            sprite.sprite = sprites[0];
        else if(AiManager.instance.numberManager.turn >= 3&& AiManager.instance.numberManager.turn < 5)
            sprite.sprite = sprites[1];
        else if (AiManager.instance.numberManager.turn >= 5 && AiManager.instance.numberManager.turn < 7)
            sprite.sprite = sprites[2];
        else if(AiManager.instance.numberManager.turn >=7 && AiManager.instance.numberManager.choosePlaceNum == 1)
            sprite.sprite = sprites[3];
        else if (AiManager.instance.numberManager.turn >= 7 && AiManager.instance.numberManager.choosePlaceNum == 2)
            sprite.sprite = sprites[4];
        else if (AiManager.instance.numberManager.turn >= 7 && AiManager.instance.numberManager.choosePlaceNum == 3)
            sprite.sprite = sprites[5];
        else if (AiManager.instance.numberManager.turn >= 7 && AiManager.instance.numberManager.choosePlaceNum == 4)
            sprite.sprite = sprites[6];
    }
}
