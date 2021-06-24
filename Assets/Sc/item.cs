using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{

    public GameObject HomeWindow;
    public GameObject shopWindow;
    public GameObject workWindow;
    public GameObject dungeonWindow;
    [SerializeField] AudioSource aa;
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
        aa.Play();
        shopWindow.SetActive(true);
    }
    public void workOn()
    {
        allfalse(); aa.Play();
        workWindow.SetActive(true);
    }
    public void HomeOn()
    {
        allfalse(); aa.Play();
        HomeWindow.SetActive(true);
    }
    public void dungeonOn()
    {
        allfalse(); aa.Play();
        dungeonWindow.SetActive(true);
    }

}
