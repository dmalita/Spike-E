#pragma strict

var speed : float = 1;

function Start () {

}

function Update () {
    if (Input.touchCount > 0 && 
        Input.GetTouch(0).phase == TouchPhase.Moved) {


        // Get movement of the finger since last frame
        var touchDeltaPosition:Vector2 = Input.GetTouch(0).deltaPosition;

        var touchPosition:Vector3;

        touchPosition.Set(touchDeltaPosition.x, 
                           transform.position.y, 
                           touchDeltaPosition.y);


        // Move object across XY plane
        transform.position = Vector3.Lerp(transform.position,
                                                touchPosition, 
                                                Time.deltaTime*speed);
    }

}