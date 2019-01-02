
using UnityEngine;

[System.Serializable]
public class Car
{
    public float speed;
    public string color;
    public int highestSpeed;

    public Car( float speed, string color, int highestSpeed ) {
        this.speed = speed;
        this.color = color;
        this.highestSpeed = highestSpeed;
    }

    public float getSpeed() {
        return this.speed;
    }

    public void setSpeed( float speed ) {
        this.speed = speed;
    }

    void Move() {
        Debug.Log("Moving");
    }

    void ApplyBrake() {
        Debug.Log("Applying break");
    }

    public void CarSpeed() {
        Debug.Log( speed );
    }

    public void PrintCarDetails() {
        Debug.Log( "Speed = " + speed );
        Debug.Log( "Color = " + color );
        Debug.Log( "High Speed = " + highestSpeed );
    }
}
