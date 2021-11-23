using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guest_hairinfor : MonoBehaviour
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

    private void Start()
    {
        hair_information();
  
    }
    public SpriteRenderer Hair;

    private Nationality enhair;
    private gender eghair;

    private void hair_information()
    {
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
    }

    public int get_hair_eninfor()
    {
        if (enhair == Nationality.korea)
        { return 1; }
        else if (enhair == Nationality.china)
        { return 2; }
        else
            return 3;
    }

    public int get_hair_eginfor()
    {
        if (eghair == gender.man)
        { return 1; }
        else if (eghair == gender.woman)
        { return 2; }
        else
            return 3;
    }

}
