// See https://aka.ms/new-console-template for more information
using System;

public class Ball
{
    private float x;
    private float y;
    private int radius;
    private float xDelta;
    private float yDelta;

    public Ball(float x, float y, int radius, float xDelta, float yDelta)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
        this.xDelta = xDelta;
        this.yDelta = yDelta;
    }

    public void SetX(float x)
    {
        this.x = x;
    }

    public float GetX()
    {
        return x;
    }

    public void SetY(float y)
    {
        this.y = y;
    }

    public float GetY()
    {
        return y;
    }

    public void SetRadius(int radius)
    {
        this.radius = radius;
    }

    public int GetRadius()
    {
        return radius;
    }

    public void SetXDelta(float xDelta)
    {
        this.xDelta = xDelta;
    }

    public float GetXDelta()
    {
        return xDelta;
    }

    public void SetYDelta(float yDelta)
    {
        this.yDelta = yDelta;
    }

    public float GetYDelta()
    {
        return yDelta;
    }

    public void ReflectHorizontal()
    {
        xDelta = -xDelta;
    }

    public void ReflectVertical()
    {
        yDelta = -yDelta;
    }

    public void Move()
    {
        x += xDelta;
        y += yDelta;
    }

    public override string ToString()
    {
        return $"Ball[({x},{y}),speed=({xDelta},{yDelta})]";
    }
}

public class TestMain
{
    public static void Main(string[] args)
    {
        // Test constructor and ToString()
        Ball ball = new Ball(1.1f, 2.2f, 10, 3.3f, 4.4f);
        Console.WriteLine(ball);  // ToString()

        // Test Setters and Getters
        ball.SetX(80.0f);
        ball.SetY(35.0f);
        ball.SetRadius(5);
        ball.SetXDelta(4.0f);
        ball.SetYDelta(6.0f);
        Console.WriteLine(ball);  // ToString()
        Console.WriteLine("x is: " + ball.GetX());
        Console.WriteLine("y is: " + ball.GetY());
        Console.WriteLine("radius is: " + ball.GetRadius());
        Console.WriteLine("xDelta is: " + ball.GetXDelta());
        Console.WriteLine("yDelta is: " + ball.GetYDelta());

        // Bounce the ball within the boundary
        float xMin = 0.0f;
        float xMax = 100.0f;
        float yMin = 0.0f;
        float yMax = 50.0f;
        for (int i = 0; i < 15; i++)
        {
            ball.Move();
            Console.WriteLine(ball);
            float xNew = ball.GetX();
            float yNew = ball.GetY();
            int radius = ball.GetRadius();
            // Check boundary value to bounce back
            if ((xNew + radius) > xMax || (xNew - radius) < xMin)
            {
                ball.ReflectHorizontal();
            }
            if ((yNew + radius) > yMax || (yNew - radius) < yMin)
            {
                ball.ReflectVertical();
            }
        }
    }
}
