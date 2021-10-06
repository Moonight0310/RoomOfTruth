using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guest_manager : MonoBehaviour
{
  
    public GameObject Guest;


    // Start is called before the first frame update
    void Start()
    {
        guest_creat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void guest_creat()
    {
        Instantiate(Guest);

    }
}
