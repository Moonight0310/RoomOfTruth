using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guest_clothesinfor : MonoBehaviour
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
        clothes_information();
    }

    public SpriteRenderer Cloths;

    private Nationality encloth;
    private gender egcloth;

    private void clothes_information()
    {
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

    public int get_clothes_eninfor()
    {
        if (encloth == Nationality.korea)
        { return 1; }
        else if (encloth == Nationality.china)
        { return 2; }
        else
          return 3;
    }

    public int get_clothes_eginfor()
    {
        if (egcloth == gender.man)
        { return 1; }
        else if (egcloth == gender.woman)
        { return 2; }
        else
            return 3;
    }
}
