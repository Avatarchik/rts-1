using UnityEngine;

public struct Destination {
    private Vector2 from;
    private Vector2 to;

    public Vector2 From {
        get { return from; }
    }

    public Vector2 To {
        get { return to; }
    }

    public Destination(Vector2 from, Vector2 to) {
        this.from = from;
        this.to = to;
    }
}