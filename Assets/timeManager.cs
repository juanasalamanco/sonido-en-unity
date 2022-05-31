﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeManager : MonoBehaviour
{
    public Text txtTime;
    public Text txtTimeFloored;
    public Text txtcustomtext;

    float customtime;
    bool iscounting;

    // Start is called before the first frame update
    void Start()
    {
        customtime = 0;
        iscounting = false;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;

        txtTime.text = time.ToString();

        txtTimeFloored.text = Mathf.Floor(time).ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            iscounting = true;
        }
        if (iscounting)
        {
            customtime += Time.deltaTime;
        }

        txtcustomtext.text = customtime.ToString();

        if(customtime > 10)
        {
            //perdiste
        }
    }
}
