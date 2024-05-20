using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    Transform player;
    //odległośc od końca poziomu
    public float levelExitDistance = 100;
    //punkt końca poziomu
    public Vector3 exitPosition;
    public GameObject exitPrefab;
    public bool levelComplete = false;
    public bool levelFailed = false;
   
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        //znajdz gracza
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //wylosuj pozycję na kole o średnicy 100 jednostek
        Vector2 spawnCircle = Random.insideUnitCircle; //losowa pozycja x,y wewnątrz koła o r=1
        //chcemy tylko pozycję na okręgu, a nie wewnątrz koła
        spawnCircle = spawnCircle.normalized; //pozycje x,y w odległości 1 od środka
        spawnCircle *= levelExitDistance; //pozycja x,y w odległości 100 od środka
        //konwertujemy do Vector3
        //podstawiamy: x=x, y=0, z=y
        exitPosition = new Vector3(spawnCircle.x, 0, spawnCircle.y);
        Instantiate(exitPrefab, exitPosition, Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    //funkcja jest utuchamiana kiedy dany poziom (level) jest zakoñczony sukcesem
    public void OnSuccess()
    {
        //zatrzymaj fizykê gry
        Time.timeScale = 0f;
        //ustaw flagê - poziom zakoñczony
        levelComplete = true;
        //zatrzymaj ambientowa muzyczke
        Camera.main.transform.GetComponent<AudioSource>().Stop();
        //odegraj dŸwiêk koñca poziomu
        
        //Camera.main.transform.Find("LevelCompleteSound").GetComponent<AudioSource>().Play();
        //przenisione do elementu interfejsu
    }

    public void OnFailure()
    {
        //zatrzymaj fizykê
        Time.timeScale = 0f;
        //ustaw flagê, ¿e nie uda³o siê ukoñczyæ poziomu
        levelFailed = true;
        //zatrzymaj ambientowa muzyczke
        Camera.main.transform.GetComponent<AudioSource>().Stop();
        //odgrywmay dzwiek przegranej
        
        //Camera.main.transform.Find("GameOverScreen").GetComponent<AudioSource>().Play();
        //przenisione do elementu interfejsu
    }
}
