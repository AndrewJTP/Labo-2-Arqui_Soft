namespace labo_2
{
    public class Square:Shape,IPolygon{

        public int Side;
        public Square(int l){
            Side=l;         
            Name="Square";
        }

        public override double Area()
        {
           return Side*Side;
        }
        public int NumeroLados()
        {
            return 4;
        }
    }
}