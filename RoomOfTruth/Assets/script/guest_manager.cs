using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guest_manager : MonoBehaviour
{
  
    public GameObject Guest;
    private GameObject Guest_clone;
    public GameObject Text;
    public GameObject check_out;
    public GameObject Time_over;
    public Text Timeover_text;
    public Text fail_text;
    private talk_manager TalkM;

    int departure = 0;
    int impossible = 0;
    int guest_out = 0;
    int guest = 0;

    public float timeover = 10f;
    public float guestdelaytime = 1f;
    public float exitdelaytime = 4f;

    private int cloth_en = 0;
    private int hair_en = 0;

    private int cloth_eg = 0;
    private int hair_eg = 0;


    // Start is called before the first frame update
    void Start()
    {
        guest_creat();
        StartCoroutine("time_over");

    }


    void guest_creat()
    {
        guest++;
        Guest_clone = (GameObject)Instantiate(Guest);
        GameObject.Find("Gamemaster").GetComponent<talk_manager>().talk();
        Text.gameObject.SetActive(true);

    }

    public void guest_exit_yes()
    {
        int id = GameObject.Find("Gamemaster").GetComponent<talk_manager>().get_id();
        Destroy(Guest_clone, guestdelaytime);
        Text.gameObject.SetActive(false);
        departure++;
        if(guest_checking() == false && id < 1500)
        {
            check_out.gameObject.SetActive(true);
            fail_text.text = "���� ������\n�Ա��ɻ� ������";
            StartCoroutine("checkfail_Delay");
            guest_out++;
        }
        
        else if(id < 1500)
        {
            check_out.gameObject.SetActive(true);
            fail_text.text = "�Ա��ɻ� ������";
            StartCoroutine("checkfail_Delay");
            guest_out++;
        }
        else if(guest_checking() == false)
        {
            check_out.gameObject.SetActive(true);
            fail_text.text = "���� ������";
            StartCoroutine("checkfail_Delay");
            guest_out++;
        }
        StartCoroutine("guestDelay");
               
    }

    public void guest_exit_no()
    {
        int id = GameObject.Find("Gamemaster").GetComponent<talk_manager>().get_id();
        Destroy(Guest_clone, guestdelaytime);
        Text.gameObject.SetActive(false);
        impossible++;
        if (guest_checking() == true && id > 1500)
        {
            check_out.gameObject.SetActive(true);
            fail_text.text = "���� ���� �մ�";
            StartCoroutine("checkfail_Delay");
            guest_out++;
        }
        StartCoroutine("guestDelay");
        
    }

    public bool guest_checking()
    {
        cloth_en = GameObject.Find("clothes").GetComponent<guest_clothesinfor>().get_clothes_eninfor();
        hair_en = GameObject.Find("hair").GetComponent<guest_hairinfor>().get_hair_eninfor();

        cloth_eg = GameObject.Find("clothes").GetComponent<guest_clothesinfor>().get_clothes_eginfor();
        hair_eg = GameObject.Find("hair").GetComponent<guest_hairinfor>().get_hair_eginfor();

        if (cloth_en == hair_en && cloth_eg == hair_eg)
            return true;

        else 
            return false;

    }

    IEnumerator guestDelay()
    {
        yield return new WaitForSeconds(exitdelaytime);
        guest_creat();
    }

    IEnumerator checkfail_Delay()
    {
        yield return new WaitForSeconds(2f);
        check_out.gameObject.SetActive(false);
    }

    IEnumerator time_over()
    {
        yield return new WaitForSeconds(timeover);
        Timeover_text.text = ("�� �� �� ��\n\n���� �մ� �� : " + guest + "\n�Ա� �㰡�� ���� �մ� �� : " + departure + 
            "\n �Ա� ����� �մ� �� : " + impossible + "\n�ɻ翡 ������ �� �մ� �� : " + guest_out + "\n�ϴ� \n" + (guest*2500) + "\n- " + (guest_out*5000)
            + "\n-----------\n" + ((guest * 2500)- (guest_out * 5000)) + "\n ����ȭ������ ���ư��ðڽ��ϱ�?");
        Time_over.gameObject.SetActive(true);
    }


}
