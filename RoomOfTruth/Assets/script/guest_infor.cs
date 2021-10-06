using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guest_infor : MonoBehaviour
{
    enum Nationality
    {
        korea = 0,
        china = 1
    }
    enum gender
    {
        man = 0,
        woman = 1
    }


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

    private Nationality enhair;
    private Nationality encloth;

    private gender eghair;
    private gender egcloth;


    // Start is called before the first frame update
    void Start()
    {
        eyes = Resources.LoadAll<Sprite>("play_scene/guest/eyes_idle");
        hair = Resources.LoadAll<Sprite>("play_scene/guest/hair");
        cloths = Resources.LoadAll<Sprite>("play_scene/guest/cloth");
        guest_change();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void guest_change()
    {
        eyes_num = Random.Range(0, eyes.Length);
        hair_num = Random.Range(0, hair.Length);
        cloths_num = Random.Range(0, cloths.Length);

        Eyes.sprite = eyes[eyes_num];
        Rip.sprite = rip[0];
        Hair.sprite = hair[hair_num];
        Cloths.sprite = cloths[cloths_num];

        string sHair = Hair.sprite.name;
        string[] saHair = sHair.Split(new char[] { '_' });
        if (saHair[1] == "00")
            enhair = Nationality.korea;
        if (saHair[1] == "01")
            enhair = Nationality.china;
        if (saHair[2] == "00")
            eghair = gender.man;
        if (saHair[2] == "01")
            eghair = gender.woman;

        string scloth = Cloths.sprite.name;
        string[] sacloth = scloth.Split(new char[] { '_' });
        if (sacloth[1] == "00")
            encloth = Nationality.korea;
        if (sacloth[1] == "01")
            encloth = Nationality.china;
        if (sacloth[2] == "00")
            egcloth = gender.man;
        if (sacloth[2] == "01")
            egcloth = gender.woman;

    }
}
