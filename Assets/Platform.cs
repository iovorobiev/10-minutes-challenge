using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    public Ball ball;

	// Update is called once per frame
	void Update () {
        var position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(position.x, transform.position.y);
        ball.updatePosition(transform.position);
	}
}
