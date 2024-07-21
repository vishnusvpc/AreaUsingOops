using AreaUsingOops.Model;

namespace AreaUsingOops.Calculation
{
    public class AreaCalculation
    {
        double area;
        public double Area(ShapeData shapeData)
        {
            
            switch (shapeData.shape.ToLower())
            {
                case "square":
                    if(shapeData.length.HasValue && shapeData.width.HasValue)
                    {
                        area = shapeData.length.Value * shapeData.width.Value;
                    }
                    else
                    {
                        throw new Exception("Error");
                    }
                    
                    break;
                case "rectangle":
                    if (shapeData.length.HasValue && shapeData.width.HasValue)
                    {
                        area = shapeData.length.Value * shapeData.width.Value;
                    }
                    else
                    {
                        throw new Exception("Error");
                    }
                    break;
                case "triangle":
                    if(shapeData.height.HasValue && shapeData.length.HasValue)
                    {
                        area = .5 * shapeData.height.Value * shapeData.length.Value;
                    }
                    else
                    {
                        throw new Exception("Error");
                    }
                    break;
                case "circle":
                    if (shapeData.radius.HasValue)
                    {
                        area = Math.PI * Math.Pow(shapeData.radius.Value,2);
                    }
                    break;
        
            }
            return area;
            
        }
    }
}
