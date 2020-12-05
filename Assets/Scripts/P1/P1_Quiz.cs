using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1_Quiz : MonoBehaviour

{

    public GameObject backBtn;
    public GameObject backToUnlit;
    

    // tower quiz buttons
    public GameObject b12pm;
    public GameObject b10pm;
    public GameObject b7pm;
    public GameObject b5pm;
    public GameObject b2pm;

    // tower quiz lit buttons 
    public GameObject b12pmLit;
    public GameObject b10pmLit;
    public GameObject b7pmLit;
    public GameObject b5pmLit;
    public GameObject b2pmLit;

    // booleans for if statements to switch btw lit/unlit states
    bool b12 = false;
    bool b10 = false;
    bool b7 = false;
    bool b5 = false;
    bool b2 = false;

    // Start is called before the first frame update
    void Start()
    {
        // hide all lit buttons
        b12pmLit.SetActive(false);
        b10pmLit.SetActive(false);
        b7pmLit.SetActive(false);
        b5pmLit.SetActive(false);
        b2pmLit.SetActive(false);

        // !!!!!!!!! HIDE BACK BUTTON TO LIT TOWER !!!!!!!!!!
        backBtn.SetActive(false);

        // btn @ 5pm lights up first
        Button btn5 = b5pm.GetComponent<Button>();

        // click event
        btn5.onClick.AddListener(click_b5pm);

    }

    // Update is called once per frame
    void Update()
    {
        if (b5)
        {
            b5pmLit.SetActive(true);
        } else 
            if (b10 || b2 || b7 || b5)
            {
                b5 = false;
                b5pmLit.SetActive(false);
                b12 = false;
                b12pmLit.SetActive(false);
                b10 = false;
                b10pmLit.SetActive(false);
                b2 = false;
                b2pmLit.SetActive(false);
                b7 = false;
                b7pmLit.SetActive(false);
            }
        

        Button btn12 = b12pm.GetComponent<Button>();
        Button btn10 = b10pm.GetComponent<Button>();
        Button btn2 = b2pm.GetComponent<Button>();
        Button btn7 = b7pm.GetComponent<Button>();

        btn12.onClick.AddListener(click_b12pm);
        btn10.onClick.AddListener(click_b10pm);
        btn2.onClick.AddListener(click_b2pm);
        btn7.onClick.AddListener(click_b7pm);

    }

    void click_b5pm()
    {
        b5 = true;

        
    }

    void click_b12pm()
    {
        b12 = true;

        checkButtonOrder1();

    }

    void click_b10pm()
    {
        b10 = true;

        checkButtonOrder2();
    }

    void click_b2pm()
    {
        b2 = true;

        checkButtonOrder3();
    }

    void click_b7pm()
    {
        b7 = true;

        checkButtonOrder4();
    }

    void checkButtonOrder1()
    {
        if (b12 && b5)
        {
            b12pmLit.SetActive(true);

        }
        else if (b10 || b2 || b7)
        {
                b5 = false;
                b5pmLit.SetActive(false);
                b12 = false;
                b12pmLit.SetActive(false);
                b10 = false;
            b10pmLit.SetActive(false);
            b2 = false;
            b2pmLit.SetActive(false);
            b7 = false;
            b7pmLit.SetActive(false);
        }
        
    }

    void checkButtonOrder2()
    {
        if (b12 && b5 && b10)
        {
            b10pmLit.SetActive(true);
        }
        else if(b2 || b7)
        {
            b5 = false;
            b5pmLit.SetActive(false);
            b12 = false;
            b12pmLit.SetActive(false);
            b10 = false;
            b10pmLit.SetActive(false);
            b2 = false;
            b2pmLit.SetActive(false);
            b7 = false;
            b7pmLit.SetActive(false);
        }
    }

    void checkButtonOrder3()
    {
        if (b12 && b5 && b10 && b2)
        {
            b2pmLit.SetActive(true);
        }
        else if (b7)
        {
            b5 = false;
            b5pmLit.SetActive(false);
            b12 = false;
            b12pmLit.SetActive(false);
            b10 = false;
            b10pmLit.SetActive(false);
            b2 = false;
            b2pmLit.SetActive(false);
            b7 = false;
            b7pmLit.SetActive(false);

        }
    }

    void checkButtonOrder4()
    {
        if (b12 && b5 && b10 && b2 && b7)
        {
            b7pmLit.SetActive(true);
            // !!!!!!!!! HIDE BACK BUTTON TO LIT TOWER !!!!!!!!!!
            backToUnlit.SetActive(false);
            backBtn.SetActive(true);
        }
        else
        {
            b5 = false;
            b5pmLit.SetActive(false);
            b12 = false;
            b12pmLit.SetActive(false);
            b10 = false;
            b10pmLit.SetActive(false);
            b2 = false;
            b2pmLit.SetActive(false);
            b7 = false;
            b7pmLit.SetActive(false);
        }
    }

}
