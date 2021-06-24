using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stat : MonoBehaviour
{

    private int atteackPower;
    private int item1;
    private int item2;
    private int item3;
    private int item4;
    private float diamond;

    public Text item1AtTxt;
    public Text item2AtTxt;
    public Text item3AtTxt;
    public Text item4AtTxt;

    public Text item1PrTxt;
    public Text item2PrTxt;
    public Text item3PrTxt;
    public Text item4PrTxt;


    public Text item1BTxt;
    public Text item2BTxt;
    public Text item3BTxt;
    public Text item4BTxt;

    public Text itemAtTxt;
    public Text itemPrTxt;


    public float work1;
    public GameObject image1;
    public float work2;
    public GameObject image2;
    public float work3;
    public GameObject image3;
    public float work4;
    public GameObject image4;
    public float workMoney;
    public GameObject OPOBJ;
    bool opB;
    Monster monster;
    Monster bossmonster;
    misson Misoon;
    AudioSource au;
    [SerializeField] AudioSource aa;
    // Start is called before the first frame update
    void Start()
    {
        opB = false;
           au = this.gameObject.GetComponent<AudioSource>();
        Misoon = this.gameObject.GetComponent<misson>();
        monster = this.gameObject.GetComponent<Monster>();
        atteackPower = 1;
        item1 = 0;
        item2 = 0;
        item3 = 0;
        item4 = 0;
        work1 = 0;
        work2 = 0;
        work3 = 0;
        work4 = 0;
        diamond = 100;
      
        Invoke("workMoneyUpdate", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void atteackPowerUpdate()
    {
        atteackPower = 1 + item1 + item2 * 3 + item3 * 5 + item4 * 10;
        itemAtTxt.text = "" + atteackPower;
        itemPrTxt.text = "" + diamond;

    }
    void workMoneyUpdate()
    {
        workMoney = work1 + work2 * 2 + work3 * 3 + work4 * 5;
        diamond += workMoney;
        itemPrTxt.text = "" + diamond;
        Invoke("workMoneyUpdate", 1.0f);
    }
    public void buyItem1()
    {
        if(diamond < 10 || item1 >= 10)
            return;

        aa.Play();
        diamond -= 10;
        item1 += 1;
        item1AtTxt.text = "" + item1;
        item1PrTxt.text = "" + 10;
        item1BTxt.text = "구매 : " + item1 + " / 10";
        Misoon.numPlus(1);
        atteackPowerUpdate();
        return;
    }
    public void buyItem2()
    {
        if (diamond <150 || item2 >= 10)
            return;
        aa.Play();
        item2BTxt.text = "구매 : " + item2 + " / 10";
        diamond -= 150;
        item2 += 1;
        item2AtTxt.text = "" + item2 *3;
        item2PrTxt.text = "" + 150;
        Misoon.numPlus(1);
        atteackPowerUpdate();
        return;
    }
    public void buyItem3()
    {
        if (diamond < 300 || item3 >= 10)
            return;
        aa.Play();
        item3BTxt.text = "구매 : " + item3 + " / 10";
        diamond -= 300;
        item3 += 1;
        item3AtTxt.text = "" + item3 * 5;
        item3PrTxt.text = "" + 300;
        Misoon.numPlus(1);
        atteackPowerUpdate();
        return;
    }
    public void buyItem4()
    {
        if (diamond < 1000 || item4 >= 10)
            return;
        aa.Play();
        item4BTxt.text = "구매 : " + item4 + " / 10";
        diamond -= 1000;
        item4 += 1;
        item4AtTxt.text = "" + item4 * 10;
        item4PrTxt.text = "" +1000;
        Misoon.numPlus(1);
        atteackPowerUpdate();
        return;
    }
    public void buyWork1()
    {
        if (diamond <500)
            return;
        aa.Play();
        diamond -= 500;

        work1 = 1;
        Destroy(image1);
        return;

    }

    public void buyWork2()
    {
        if (diamond < 1000)
            return;
        aa.Play();
        diamond -= 1000;
        work2 = 1;
        Destroy(image2);
        return;

    }
    public void buyWork3()
    {
        if (diamond < 2000)
            return;
        aa.Play();
        diamond -= 2000;

        work3 = 1;
        Destroy(image3);
        return;

    }
    public void buyWork4()
    {
        if (diamond < 3000)
            return;
        aa.Play();
        diamond -= 3000;

        work4 = 1;
        Destroy(image4);
        return;

    }

    public void getDiamond(int nn) {

        diamond += nn;

    }
    public float getAtteackPower()
    {
        return atteackPower;
    }
    public void clickMonster()
    {
        diamond += monster.HpDown(atteackPower);
    }
    public void clickMonster2()
    {
        diamond += bossmonster.HpDown(atteackPower);
    }

    public void bossmonsterSet(GameObject ga)
    {
        bossmonster = ga.GetComponent<Monster>();
    }

    public void bossmonsterSet(Slider sl)
    {
        au.volume = sl.value;
    }
    public void OP()
    {
        opB = !opB;
        OPOBJ.SetActive(opB);
    }
 
}
