namespace POC_DesignPatterns.Builder;

public interface IShapeBuilder
{
    void CreateShape();

    void WithColor();

    void WithTexture();
}