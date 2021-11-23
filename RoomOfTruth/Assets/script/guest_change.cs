using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guest_change : MonoBehaviour
{
    private int id;

    public SpriteRenderer Eyes;
    public SpriteRenderer Rip;
    public SpriteRenderer Hair;
    public SpriteRenderer Cloths;

    public Sprite[] eyes;
    public Sprite[] rip;
    public Sprite[] hair;
    public Sprite[] cloths;

    private int eyes_num = 0;
    private int hair_num = 0;
    private int cloths_num = 0;

    void Start()
    {
        eyes = Resources.LoadAll<Sprite>("play_scene/guest/eyes_idle");
        hair = Resources.LoadAll<Sprite>("play_scene/guest/hair");
        cloths = Resources.LoadAll<Sprite>("play_scene/guest/cloth");
        rip = Resources.LoadAll<Sprite>("play_scene/guest/rip");
        change();
        
    }

    void change()
    {
        eyes_num = Random.Range(0, eyes.Length);
        hair_num = Random.Range(0, hair.Length);
        cloths_num = Random.Range(0, cloths.Length);

        Eyes.sprite = eyes[eyes_num];
        Rip.sprite = rip[0];
        Hair.sprite = hair[hair_num];
        Cloths.sprite = cloths[cloths_num];
    }
}
