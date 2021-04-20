using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは"+mp+"。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    void Start ()
    {
        int i;
        int []array ={ 1,2,3,4,5};
        for (i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for(i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        Boss sorcerer = new Boss();
        for (i = 0; i < 11; i++)
        {
            sorcerer.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
