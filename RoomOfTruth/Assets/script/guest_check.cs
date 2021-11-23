using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guest_check : MonoBehaviour
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

   

    float MaxDistance = 15f;
    Vector3 MousePosition;
    Camera Camera;
    public GameObject ui_ok;
    public GameObject ui_no;

    int infor_number = 0;
    public float ui_time = 2;
   

    SpriteRenderer infor1;
    SpriteRenderer infor2;

    private Nationality eninfor1;
    private gender eginfor1;

    private Nationality eninfor2;
    private gender eginfor2;

    private void Start()
    {
        Camera = GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MousePosition = Input.mousePosition;
            MousePosition = Camera.ScreenToWorldPoint(MousePosition);

            RaycastHit2D hit = Physics2D.Raycast(MousePosition, transform.forward, MaxDistance);
            if(hit)
            {
                if (infor_number == 0)
                {
                    infor1 = hit.transform.GetComponent<SpriteRenderer>();
                    
                    infor_number++;
                }
                else if (infor_number == 1)
                {
                    infor2 = hit.transform.GetComponent<SpriteRenderer>();
                    
                    infor_number--;
                    information();
                    check();
                }
            }
        }
    }

    private void information()
    {
        string sinfor1 = infor1.sprite.name;
        string[] sainfor1 = sinfor1.Split(new char[] { '_' });
        if (sainfor1[1] == "00")
            eninfor1 = Nationality.korea;
        if (sainfor1[1] == "01")
            eninfor1 = Nationality.china;
        if (sainfor1[2] == "00")
            eginfor1 = gender.man;
        if (sainfor1[2] == "01")
            eginfor1 = gender.woman;

        string sinfor2 = infor2.sprite.name;
        string[] sainfor2 = sinfor2.Split(new char[] { '_' });
        if (sainfor2[1] == "00")
            eninfor2 = Nationality.korea;
        if (sainfor2[1] == "01")
            eninfor2 = Nationality.china;
        if (sainfor2[2] == "00")
            eginfor2 = gender.man;
        if (sainfor2[2] == "01")
            eginfor2 = gender.woman;
    }

    private bool check()
    {
        if (eninfor1 == eninfor2 && eginfor1 == eginfor2)
        {
            StartCoroutine("check_ok");
            return true;
        }
        else
        {
            StartCoroutine("check_no");
            return false;
        }
    }

    IEnumerator check_ok()
    {
        ui_ok.gameObject.SetActive(true);
        yield return new WaitForSeconds(ui_time);
        ui_ok.gameObject.SetActive(false);
    }

    IEnumerator check_no()
    {
        ui_no.gameObject.SetActive(true);
        yield return new WaitForSeconds(ui_time);
        ui_no.gameObject.SetActive(false);
    }





}
