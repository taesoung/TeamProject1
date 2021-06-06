using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public GameObject eventS;
    public GameObject Effect;
    private Vector3 mousePosition;


    public bool boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnMouseUp()
    {

        if (boss)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            eventS.GetComponent<stat>().clickMonster2();
            Destroy(Instantiate(Effect, new Vector3(mousePosition.x, mousePosition.y, -2.0f), Quaternion.identity), 0.8f);
            return;
        }

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        eventS.GetComponent<stat>().clickMonster();
         Destroy(Instantiate(Effect, new Vector3(mousePosition.x, mousePosition.y,-2.0f), Quaternion.identity), 0.8f);

        
    }

}
