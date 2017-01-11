using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

	public float SpeedX;

    private Rigidbody SphereBody;
    private Renderer SphereRenderer;
	private Score score;
	private ExplosionSource Explosion;

	// Use this for initialization
	void Start () {

        SphereBody = gameObject.GetComponent<Rigidbody> ();
		SphereRenderer = gameObject.GetComponent<Renderer> ();
		Explosion = gameObject.GetComponent<ExplosionSource> ();

		Explosion.enabled = false;
		Explosion.Force = 25f;
    }
	
	// Update is called once per frame
	void Update () {

        SphereMove();

        ColorChange();
		
	}

    void SphereMove() {

        gameObject.transform.position += new Vector3(SpeedX * Time.deltaTime, 0, 0);

        SpeedX += 0.2f * Time.deltaTime;

		Explosion.Force += 1f * Time.deltaTime;

    }

    void ColorChange() {

		if (Input.GetMouseButtonDown(0))
        {
            if (SphereRenderer.material.color == Color.red) {

                SphereRenderer.material.color = Color.blue;

            } else {

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
				Explosion.enabled = true;
            }
            else
            {
				Explosion.enabled = false;;
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

    void OnTriggerExit ()
    {

    	Explosion.enabled = false;

    }
}
