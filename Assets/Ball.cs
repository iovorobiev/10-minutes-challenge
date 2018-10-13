using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

    bool isSticked = true;

    public void updatePosition(Vector2 position) {
        if (isSticked)
        {
            transform.position = new Vector2(position.x, transform.position.y);
        }
    }

	// Update is called once per frame
	void Update () {
        if (!isSticked) return;
        if (Input.GetMouseButtonDown(0)) {
            var body = GetComponent<Rigidbody2D>();
            body.isKinematic = false;
            body.velocity = new Vector2(0f, 10f);
            isSticked = false;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
