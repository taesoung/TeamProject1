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


    Monster monster;
    Monster bossmonster;
    misson Misoon;
    // Start is called before the first frame update
    void Start()
    {
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
        diamond = 10000;
        Invoke("workMoneyUpdate", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void atteackPowerUpdate()
    {
        atteackPower = 1 + item1 + item2 * 10 + item3 * 50 + item4 * 100;
        itemAtTxt.text = "" + atteackPower;
        itemPrTxt.text = "" + diamond;

    }
    void workMoneyUpdate()
    {
        workMoney = work1 + work2 * 2 + work3 * 4 + work4 * 8;
        diamond += workMoney;
        itemPrTxt.text = "" + diamond;
        Invoke("workMoneyUpdate", 1.0f);
    }
    public void buyItem1()
    {
        if(diamond < item1 *10+10)
            return;

       
        diamond -= item1 * 10 + 10;
        item1 += 1;
        item1AtTxt.text = "" + item1;
        item1PrTxt.text = "" + (item1 * 10 +10);
        Misoon.numPlus(1);
        atteackPowerUpdate();
        return;
    }
    public void buyItem2()
    {
        if (diamond < item2 * 100+ 100)
            return;

        diamond -= item2 * 100+100;
        item2 += 1;
        item2AtTxt.text = "" + item2 *10;
        item2PrTxt.text = "" + (item2 * 100 + 100);
        Misoon.numPlus(1);
        atteackPowerUpdate();
        return;
    }
    public void buyItem3()
    {
        if (diamond < item3 * 400 +400)
            return;

        diamond -= item3 * 400+400;
        item3 += 1;
        item3AtTxt.text = "" + item3 * 50;
        item3PrTxt.text = "" + (item3 * 400 + 400);
        Misoon.numPlus(1);
        atteackPowerUpdate();
        return;
    }
    public void buyItem4()
    {
        if (diamond < item4 * 700+700)
            return;

        diamond -= item4 * 700+700;
        item4 += 1;
        item4AtTxt.text = "" + item4 * 100;
        item4PrTxt.text = "" + (item4 * 700 + 700);
        Misoon.numPlus(1);
        atteackPowerUpdate();
        return;
    }
    public void buyWork1()
    {


        work1 = 1;
        Destroy(image1);
        return;

    }

    public void buyWork2()
    {
        work2 = 1;
        Destroy(image2);
        return;

    }
    public void buyWork3()
    {


        work3 = 1;
        Destroy(image3);
        return;

    }
    public void buyWork4()
    {


        work4 = 1;
        Destroy(image4);
        return;

    }

    public void getDiamond(int nn) {

        diamond += nn;

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


}
