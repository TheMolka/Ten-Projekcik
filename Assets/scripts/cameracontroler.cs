using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroler : MonoBehaviour
{
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        //pod��cz pozycje gracza do lokalnej zmiennej korzystaj�c z jego taga
        //to nie jest zapisane warto�ci jeden raz tylko referencje obiektu
        //znaczy ze player zawsze b�dzie zawiera� aktualn� pozycje gracza
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //oblicz docelow� pozycje gracza
        Vector3 targetPosition = player.position + Vector3.up * 10;
        //p�ynne przesuniencie kamery w kierunku gracza
        //funkcja Vector3.lerp
        //p�ynnie przechodzi z pozycji pierwszego argumentu do drugiego w czasie trzeciego 
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }
}
