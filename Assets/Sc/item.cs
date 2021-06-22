using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{

    public GameObject HomeWindow;
    public GameObject shopWindow;
    public GameObject workWindow;
    public GameObject dungeonWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void allfalse()
    {
        HomeWindow.SetActive(false);
        shopWindow.SetActive(false);
        workWindow.SetActive(false);
        dungeonWindow.SetActive(false);
    }
    public void shopOn()
    {
        allfalse();
        shopWindow.SetActive(true);
    }
    public void workOn()
    {
        allfalse();
        workWindow.SetActive(true);
    }
    public void HomeOn()
    {
        allfalse();
        HomeWindow.SetActive(true);
    }
    public void dungeonOn()
    {
        allfalse();
        dungeonWindow.SetActive(true);
    }

}
