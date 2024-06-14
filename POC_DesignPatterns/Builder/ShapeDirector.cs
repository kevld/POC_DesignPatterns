namespace POC_DesignPatterns.Builder;

public class ShapeDirector
{
    private IShapeBuilder _shapeBuilder;

    public IShapeBuilder ShapeBuilder
    {
        set { _shapeBuilder = value; }
    }

    public void BuildShape()
    {
        _shapeBuilder.CreateShape();
    }

    public void BuildShapeWithColor()
    {
        _shapeBuilder.CreateShape();
        _shapeBuilder.WithColor();
    }

    public void BuildShapeWithTexture()
    {
        _shapeBuilder.CreateShape();
        _shapeBuilder.WithTexture();
    }

    public void BuildFullShape()
    {
        _shapeBuilder.CreateShape();
        _shapeBuilder.WithColor();
        _shapeBuilder.WithTexture();
    }
}