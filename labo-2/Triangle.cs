namespace labo_2
{
    public class Triangle:Shape, IPolygon{

        private int Base;
        private  int Height;
        public Triangle(int b, int h){
            Base=b;
            Height=h;     
            Name="Triangle";
        }

        public override double Area()
        {
           return (Base*Height)/2;
        }
        public int NumeroLados(){
            return 3;
        }
    }
}