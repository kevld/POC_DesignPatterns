namespace POC_DesignPatterns.Builder;

public class ShapeBuilder : IShapeBuilder
{
    private Shape _shape = new Shape();

    public ShapeBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _shape = new Shape();
    }

    public void CreateShape()
    {
        _shape.AddConfigToShape("Circle");
    }

    public void WithColor()
    {
        _shape.AddConfigToShape("green");
    }

    public void WithTexture()
    {
        _shape.AddConfigToShape("grass");
    }

    public Shape Build()
    {
        var result = this._shape;
        Reset();
        return result;
    }
}
