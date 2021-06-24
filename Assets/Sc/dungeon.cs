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
    [SerializeField] Text[] diate;
    [SerializeField] click click1;
    [SerializeField] GameObject click2;
    [SerializeField] Text TimeText;
    float[] nums;
    float[] diaNums;
    int n;
    bool boss;
    public int dia;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        boss = false;
        info = this.gameObject.GetComponent<Monster>();
        nums = new float[4];
        diaNums = new float[4];
        for (int i = 0;i<4;i++)
        {
    
            nums[i] = 1;
        }
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (boss)
        {
            time -= Time.deltaTime;
            TimeText.text = "제한시간 : " + (int)time + " / 60";
            if (info.HPzero())
            {
                misson.numPlus(0);
                nums[n]++;
                float dias = nums[n] * 100 * diaNums[n];
                diate[n].text = "" + info.diaText();
              
                MONSETR.SetActive(true);
                BossMONSETR.SetActive(false);
                boss = false;
                TimeText.text = "";
                return;
            }
            if (time <=0)
            {
                MONSETR.SetActive(true);
                BossMONSETR.SetActive(false);
                click1.failTure();
                StartCoroutine(click2.GetComponent<effect>().CoFade(1.0f, 1.0f, 1.0f));
                boss = false;
            }
            return;
        }
        TimeText.text = "";
    }

    public void SetMonsetr(int num)
    {
        n = num;
        MONSETR.SetActive(false);
        BossMONSETR.SetActive(true);
        info.SetProfile2(num, nums[num]);
        boss = true;
        time = 60.0f;
    }

}
