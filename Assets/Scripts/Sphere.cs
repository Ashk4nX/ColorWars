using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

    private Rigidbody SphereBody;
    private Renderer SphereRenderer;
	private Score score;
	private ExplosionSource Explosion;

    public float SpeedX;

	// Use this for initialization
	void Start () {

        SphereBody = gameObject.GetComponent<Rigidbody> ();
		SphereRenderer = gameObject.GetComponent<Renderer> ();
		Explosion = gameObject.GetComponent<ExplosionSource> ();
		Explosion.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {

        SphereMove();
        ColorChange();
		
	}

    void SphereMove() {

        gameObject.transform.position += new Vector3(SpeedX * Time.deltaTime, 0, 0);

        SpeedX += 0.2f * Time.deltaTime;

    }

    void ColorChange() {

        if (Input.GetKeyDown(KeyCode.Space))
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
				Explosion.Force = Random.Range(30f, 60f);
    			print (Explosion.InfluenceRadius);
            }
            else
            {
            	Explosion.Force = 0;
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
