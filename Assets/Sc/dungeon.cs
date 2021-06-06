using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dungeon : MonoBehaviour
{
    [SerializeField] GameObject MONSETR;
    [SerializeField] GameObject BossMONSETR;

    [SerializeField] stat stat;
    [SerializeField] misson misson;
    Monster info;
    [SerializeField] Text diate;

    float num;
    bool boss;
    public int dia;

    // Start is called before the first frame update
    void Start()
    {
        boss = false;
        info = this.gameObject.GetComponent<Monster>();
        num = 1;
        diate.text = "100000";
    }

    // Update is called once per frame
    void Update()
    {

        if (boss)
        {
            if (info.HPzero())
            {
                diate.text = "" + info.diaText();
                misson.numPlus(0);
                num++;
                MONSETR.SetActive(true);
                BossMONSETR.SetActive(false);
                boss = false;
            }
        }

}

    public void SetMonsetr()
    {
        MONSETR.SetActive(false);
        BossMONSETR.SetActive(true);
        info.SetProfile2(0, num);
        diate.text = "" + info.diaText();
        boss = true;
    }

}
