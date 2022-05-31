using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeManager : MonoBehaviour
{
    public Text txtTime;
    public Text txtTimeFloored;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;

        txtTime.text = time.ToString();

        txtTimeFloored.text = Mathf.Floor(time).ToString();
    }
}
