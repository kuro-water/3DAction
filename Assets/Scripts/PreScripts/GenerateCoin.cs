using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCoin : MonoBehaviour
{
    public GameObject Coin;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = -4; x <= 4; x += 2)
        {
            for (int y = 0; y <= 6; y += 2)
            {
                Instantiate(Coin, new Vector3(x, y, 3), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
