public enum MaterialType
{
    Mud,
    Rock,
    Wood
}

public class Material
{
    public Material(MaterialType type, int quantity)
    {
        this.type = type;
        this.quantity = quantity;
    }

    private int quantity;
    public int Quantity { get; set; }

    private MaterialType type;
    public MaterialType Type { get; }
}
