using System;

public class Checkpoint
{
	public Checkpoint()
	{
	}

    float sum(float a, float b)
    {
        return (a + b);
    }

    float prod(float a, float b)
    {
        return (a * b);
    }

    float div(float a, float b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error");
            return 0;
        }
        else
        {
            return (a / b);
        }
    }
}
