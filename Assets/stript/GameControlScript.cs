using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    //public GameObject player1;
    //public GameObject player2;
	public GameObject heart1, heart2, heart3, cirkelwins;
	public static int health;
    public GameObject cirkelheart1, cirkelheart2, cirkelheart3, firkantwins;
    void Start()
    {
		health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
       heart3.gameObject.SetActive(true);
        cirkelwins.gameObject.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
		if (health > 3)
			health = 3;

        switch (health)
		{
			case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
               heart3.gameObject.SetActive(true);
				break;

			case 2:
                heart1.gameObject.SetActive(true);
               heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
				break;

			case 1:
               heart1.gameObject.SetActive(true);
               heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
				break;

			case 0:
               heart1.gameObject.SetActive(false);
               heart2.gameObject.SetActive(false);
              heart3.gameObject.SetActive(false);
				cirkelwins.gameObject.SetActive(true);
				Time.timeScale = 0;
				break;
		}
        switch (health)
        {
            case 3:
                cirkelheart1.gameObject.SetActive(true);
                cirkelheart2.gameObject.SetActive(true);
                cirkelheart3.gameObject.SetActive(true);
                break;

            case 2:
                cirkelheart1.gameObject.SetActive(true);
                cirkelheart2.gameObject.SetActive(true);
                cirkelheart3.gameObject.SetActive(false);
                break;

            case 1:
                cirkelheart1.gameObject.SetActive(true);
                cirkelheart2.gameObject.SetActive(false);
                cirkelheart3.gameObject.SetActive(false);
                break;

            case 0:
                cirkelheart1.gameObject.SetActive(false);
                cirkelheart2.gameObject.SetActive(false);
                cirkelheart3.gameObject.SetActive(false);
                firkantwins.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;
        }
    
}
}
