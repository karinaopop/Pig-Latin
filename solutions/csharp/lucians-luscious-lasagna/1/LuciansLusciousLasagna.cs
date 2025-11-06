class Lasagna
{
    // Returns how many minutes the lasagna should be in the oven.
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // Returns how many minutes are left based on how long it's already been in the oven.
    public int RemainingMinutesInOven(int actualMinutesInOven)
    {
        return ExpectedMinutesInOven() - actualMinutesInOven;
    }

    // Returns how many minutes it takes to prepare the lasagna based on the number of layers.
    public int PreparationTimeInMinutes(int numberOfLayers)
    {
        return numberOfLayers * 2;
    }

    // Returns the total time spent preparing and baking so far.
    public int ElapsedTimeInMinutes(int numberOfLayers, int actualMinutesInOven)
    {
        return PreparationTimeInMinutes(numberOfLayers) + actualMinutesInOven;
    }
}
