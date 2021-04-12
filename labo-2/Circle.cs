namespace labo_2
{
    public class Circle:Shape{

        
        private  int Radio;
        public Circle(int r){
            Radio=r;     
            Name="Circle";
        }

        public override double Area()
        {
           return Radio * Radio * 3.1415;
        }
    }
}