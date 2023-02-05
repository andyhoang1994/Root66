public enum MaterialType
{
    Wood, Iron
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
    public MaterialType Type { get; set; }
}
