using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
	public GameObject squareheart1, squareheart2, squareheart3, cirkelwins;
	public static int health;

    void Start()
    {
		health = 3;
        squareheart1.gameObject.SetActive(true);
        squareheart2.gameObject.SetActive(true);
        squareheart3.gameObject.SetActive(true);
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
                squareheart1.gameObject.SetActive(true);
                squareheart2.gameObject.SetActive(true);
                squareheart3.gameObject.SetActive(true);
				break;

			case 2:
                squareheart1.gameObject.SetActive(true);
                squareheart2.gameObject.SetActive(true);
                squareheart3.gameObject.SetActive(false);
				break;

			case 1:
                squareheart1.gameObject.SetActive(true);
                squareheart2.gameObject.SetActive(false);
                squareheart3.gameObject.SetActive(false);
				break;

			case 0:
                squareheart1.gameObject.SetActive(false);
                squareheart2.gameObject.SetActive(false);
                squareheart3.gameObject.SetActive(false);
				cirkelwins.gameObject.SetActive(true);
				Time.timeScale = 0;
				break;
		}
    }
}
