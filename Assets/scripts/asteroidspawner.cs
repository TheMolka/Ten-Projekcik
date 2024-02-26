using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    

    // Start is called before the first frame update
    public class AsteroidSpawner : MonoBehaviour
    {
        //gracz( jego pozycja)
        Transform player;

        //prefab statycznej asteroidy
        public GameObject staticasteroid;

        float timeSinceSpawn;
    void Start()
    {
        //znajdz gracza i przypisz do zmiennej 
        player = GameObject.FindWithTag("Player").transform;
        timeSinceSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        if (timeSinceSpawn > 1) {
            GameObject asteroid = SpawnAsteroid(staticasteroid);
            timeSinceSpawn = 0;
        }
    }

    GameObject SpawnAsteroid(GameObject prefab)
    {
        //generyczna funkcja sluzonca do wylosowania wspolrzendnych i umieszczenia w tym miejscu prefab

        //losowa pozycja w odleglosci 10 jednostek od srodka swiata
        Vector3 randomPositon = Random.onUnitSphere * 10;
        //naloz pozycje gracza
        randomPositon += player.position;

        GameObject asteroid = Instantiate(staticasteroid, randomPositon, Quaternion.identity);
        // zwróc asteroide jako wynik dzialania
        return asteroid;
    }
}
