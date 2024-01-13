using Godot;
using System;
using static Godot.GD;

public class Player : KinematicBody2D
{
    private Vector2 velocity = Vector2.Zero;
    [Export]
    private int speed = 2;

    public override void _PhysicsProcess(float delta)
    {

        Vector2 inputVector = Vector2.Zero;
        inputVector.x = Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left");
        inputVector.y = Input.GetActionStrength("move_down") - Input.GetActionStrength("move_up");

        if (inputVector != Vector2.Zero)
        {
            velocity = inputVector * speed;
        }
        else
        {
            velocity = Vector2.Zero;
        }

        MoveAndCollide(velocity);
    }

}
