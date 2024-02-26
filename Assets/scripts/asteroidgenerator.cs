using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidgenerator : MonoBehaviour
{
    //model zawieraj�cy 3 kostki
    GameObject model;
    //wylosowana rotacja/s
    // Start is called before the first frame update

    void Start()
    {
        //przypisuje do zmiennej model obiekt-pojemnik zawieraj�cy kostki
        //b�d�ce cz�ci� modelu asteroidy
        model = transform.Find("model").gameObject;

        
        //iteruj przez cz�ci modelu 
        foreach (Transform cube in model.transform)
        {
            //wylosuj obr�t we wszystkich 3 osiach w zakresie <0;90)
            cube.rotation = Random.rotation;
            //losowa liczba
            float scale = Random.Range(0.9f, 1.1f);
            //[rzeskaluj
            cube.localScale = new Vector3 (scale, scale, scale);    


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
