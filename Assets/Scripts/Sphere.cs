using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

    private Rigidbody SphereBody;
    private Renderer SphereRenderer;
	private Score score;

    public float SpeedX;

	// Use this for initialization
	void Start () {

        SphereBody = gameObject.GetComponent<Rigidbody> ();
		SphereRenderer = gameObject.GetComponent<Renderer> ();

    }
	
	// Update is called once per frame
	void Update () {

        SphereMove();
        ColorChange();
		
	}

    void SphereMove() {

        gameObject.transform.position += new Vector3(SpeedX * Time.deltaTime, 0, 0);
        SpeedX += 0.5f * Time.deltaTime;

    }

    void ColorChange() {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SphereRenderer.material.color == Color.red)
            {
                SphereRenderer.material.color = Color.blue;
            } else
            {
                SphereRenderer.material.color = Color.red;
            }
        }
    }

    void OnTriggerEnter(Collider Target) {

        if (Target.tag == "BlueWall")
        {
            Debug.Log("Sphere Hit the Blue Wall");

            if (SphereRenderer.material.color == Color.blue)
            {
                Destroy(Target.gameObject);
            }
            else
            {
                Debug.Log("GAME OVER!");
            }
        }

        if (Target.tag == "RedWall")
        {
            Debug.Log("Sphere Hit the Red Wall");

            if (SphereRenderer.material.color == Color.red)
            {
                Destroy(Target.gameObject);
            }
            else
            {
                Debug.Log("GAME OVER!");
            }
        }

    }
}
